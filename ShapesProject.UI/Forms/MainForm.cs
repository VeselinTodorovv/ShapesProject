using System.Drawing.Drawing2D;
using System.Reflection;
using Infrastructure.Converters;
using Infrastructure.Factories.Commands;
using Infrastructure.Factories.Shapes;
using ShapeProject.Application.Commands.AddRemove;
using ShapeProject.Application.Commands.Colors;
using ShapeProject.Application.Commands.Movement;
using ShapeProject.Application.Commands.Selection;
using ShapeProject.Application.Services;
using ShapesProject.Domain.Shapes;

namespace ShapesProject.Forms;

public partial class MainForm : Form
{
    private readonly ShapeManager _shapeManager;
    private readonly Scene _scene;

    private MoveCommand? _currentMoveCommand;
    private bool _isDragging;

    private Point _dragStartPosition;

    public MainForm()
    {
        InitializeComponent();

        // Fix for flickering while moving shapes
        typeof(Panel).InvokeMember("DoubleBuffered",
            BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
            null, scenePanel, new object[] { true });

        _shapeManager = new ShapeManager();
        _scene = new Scene(_shapeManager);

        RegisterCommandFactories();
        RegisterShapeFactories();

        scenePanel.Paint += panel1_Paint;
        scenePanel.MouseDown += scenePanel_MouseDown;
        scenePanel.MouseMove += scenePanel_MouseMove;
        scenePanel.MouseUp += scenePanel_MouseUp;

        _shapeManager.CommandExecuted += (_, _) =>
        {
            UpdateUndoRedoButtons();
            scenePanel.Invalidate();
        };
    }

    private static void RegisterCommandFactories()
    {
        EditCommandFactoryRegistry.Register<Circle>(new CircleEditCommandFactory());
        EditCommandFactoryRegistry.Register<Parallelogram>(new ParallelogramEditCommandFactory());
        EditCommandFactoryRegistry.Register<RectangleShape>(new RectangleEditCommandFactory());
        EditCommandFactoryRegistry.Register<Rhombus>(new RhombusEditCommandFactory());
        EditCommandFactoryRegistry.Register<Trapezoid>(new TrapezoidEditCommandFactory());
        EditCommandFactoryRegistry.Register<Triangle>(new TriangleEditCommandFactory());
    }

    private static void RegisterShapeFactories()
    {
        ShapeFactory.RegisterFactory<Circle>(new CircleFactory());
        ShapeFactory.RegisterFactory<Parallelogram>(new ParallelogramFactory());
        ShapeFactory.RegisterFactory<RectangleShape>(new RectangleFactory());
        ShapeFactory.RegisterFactory<Rhombus>(new RhombusFactory());
        ShapeFactory.RegisterFactory<Trapezoid>(new TrapezoidFactory());
        ShapeFactory.RegisterFactory<Triangle>(new TriangleFactory());
    }

    private void panel1_Paint(object? sender, PaintEventArgs e)
    {
        e.Graphics.Clear(scenePanel.BackColor);
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        _scene.DrawShapes(e.Graphics);
    }

    private void addToolStripButton_Click(object sender, EventArgs e)
    {
        using var createForm = new CreateShapeForm(_shapeManager);
        createForm.ShowDialog();
    }

    private void scenePanel_MouseDown(object? sender, MouseEventArgs e)
    {
        if (e.Button != MouseButtons.Left)
        {
            return;
        }

        _shapeManager.ClearSelection();

        var point = CustomPointConverter.ToDomainPoint(e.Location);
        var newSelection = _shapeManager.GetShapes()
            .FirstOrDefault(shape => shape.Contains(point));

        if (newSelection == null)
        {
            return;
        }

        var selectCommand = new SelectCommand(newSelection, true);

        _shapeManager.ExecuteCommand(selectCommand);

        _dragStartPosition = e.Location;
        _isDragging = true;
    }

    private void scenePanel_MouseMove(object? sender, MouseEventArgs e)
    {
        var selectedShape = _shapeManager.SelectedShape;

        if (!_isDragging || selectedShape == null || e.Button != MouseButtons.Left)
        {
            return;
        }

        var dx = e.X - _dragStartPosition.X;
        var dy = e.Y - _dragStartPosition.Y;


        if (_currentMoveCommand != null)
        {
            _currentMoveCommand.AccumulateMovement(dx, dy);
        }
        else
        {
            _currentMoveCommand = new MoveCommand(selectedShape, dx, dy);
        }

        var totalDx = _currentMoveCommand.TotalDx;
        var totalDy = _currentMoveCommand.TotalDy;

        selectedShape.ModifyTempOffset(totalDx, totalDy);

        _dragStartPosition = e.Location;

        // To visualize the shape's dragging
        scenePanel.Invalidate();
    }

    private void scenePanel_MouseUp(object? sender, MouseEventArgs e)
    {
        var selectedShape = _shapeManager.SelectedShape;

        if (_isDragging && selectedShape != null)
        {
            // Clear
            selectedShape.ModifyTempOffset(0, 0);

            if (_currentMoveCommand != null)
            {
                _shapeManager.ExecuteCommand(_currentMoveCommand);
            }
        }

        _currentMoveCommand = null;
        _isDragging = false;
        _dragStartPosition = Point.Empty;
    }

    private void editToolStripButton_Click(object? sender, EventArgs e)
    {
        var selectedShape = _shapeManager.SelectedShape;
        if (selectedShape == null)
        {
            MessageBox.Show(@"Please select a shape to edit.", @"Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

            return;
        }

        var oldState = (Shape)selectedShape.Clone();

        using var editForm = new EditShapeForm(selectedShape);

        if (editForm.ShowDialog() != DialogResult.OK)
        {
            return;
        }
        
        var factory = EditCommandFactoryRegistry.GetFactory(selectedShape.GetType());
        
        try
        {
            var command = factory.Create(selectedShape, oldState);
            _shapeManager.ExecuteCommand(command);
        }
        catch (ArgumentException ex)
        {
            MessageBox.Show($@"{ex.Message}", @"Error",
                MessageBoxButtons.OK);
        }
    }

    private void undoToolStripButton_Click(object sender, EventArgs e)
    {
        _shapeManager.Undo();
    }
    
    private void redoToolStripButton_Click(object sender, EventArgs e)
    {
        _shapeManager.Redo();
    }
    
    private void UpdateUndoRedoButtons()
    {
        undoToolStripButton.Enabled = _shapeManager.CanUndo;
        redoToolStripButton.Enabled = _shapeManager.CanRedo;
    }

    private void deleteStripButton_Click(object sender, EventArgs e)
    {
        var selectedShape = _shapeManager.SelectedShape;
        if (selectedShape == null)
        {
            return;
        }

        var deleteCommand = new DeleteShapeCommand(_shapeManager, selectedShape);
        _shapeManager.ExecuteCommand(deleteCommand);
    }

    private void fillColorButton_Click(object sender, EventArgs e)
    {
        var selectedShape = _shapeManager.SelectedShape;
        if (selectedShape == null)
        {
            MessageBox.Show(@"Please select a color.", @"Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

            return;
        }

        using var colorDialog = new ColorDialog();
        if (colorDialog.ShowDialog() != DialogResult.OK)
        {
            return;
        }

        var customColor = CustomColorConverter.ToDomainColor(colorDialog.Color);

        var command = new ChangeFillColorCommand(selectedShape, customColor);
        _shapeManager.ExecuteCommand(command);
    }

    private void borderColorToolStripComboBox_Click(object sender, EventArgs e)
    {
        var selectedShape = _shapeManager.SelectedShape;
        if (selectedShape == null)
        {
            MessageBox.Show(@"Please select a shape.", @"Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

            return;
        }

        using var colorDialog = new ColorDialog();
        if (colorDialog.ShowDialog() != DialogResult.OK)
        {
            return;
        }

        var customColor = CustomColorConverter.ToDomainColor(colorDialog.Color);

        var command = new ChangeBorderColorCommand(selectedShape, customColor);
        _shapeManager.ExecuteCommand(command);
    }

    private void saveToolStripMenuItem_Click(object sender, EventArgs e)
    {
        using var saveFileDialog = new SaveFileDialog();
        
        saveFileDialog.Filter = @"JSON files (*.json)|*.json";
        saveFileDialog.DefaultExt = "json";
        saveFileDialog.Title = @"Select a file to save";
        
        if (saveFileDialog.ShowDialog() != DialogResult.OK)
        {
            return;
        }
        
        try
        {
            _shapeManager.SaveToFile(saveFileDialog.FileName);
        }
        catch (Exception ex)
        {
            MessageBox.Show(@$"Failed to save file: {ex.Message}", @"Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    
    private void loadToolStripMenuItem_Click(object sender, EventArgs e)
    {
        using var openFileDialog = new OpenFileDialog();
        
        openFileDialog.Filter = @"JSON files (*.json)|*.json";
        openFileDialog.DefaultExt = "json";
        openFileDialog.Title = @"Select a file to load";
        
        if (openFileDialog.ShowDialog() != DialogResult.OK)
        {
            return;
        }

        try
        {
            _shapeManager.LoadFromFile(openFileDialog.FileName);
        }
        catch (Exception ex)
        {
            MessageBox.Show(@$"Failed to load file: {ex.Message}", @"Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        _shapeManager.ClearSelection();
        UpdateUndoRedoButtons();
        
        scenePanel.Invalidate();
    }

    private void newToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var result = MessageBox.Show(@"Do you want to save before starting a new canvas?", @"Confirm Action",
            MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

        if (result == DialogResult.Cancel)
        {
            return;
        }
        
        if (result == DialogResult.Yes)
        {
            using var saveFileDialog = new SaveFileDialog();
            
            saveFileDialog.Filter = @"JSON files (*.json)|*.json";
            saveFileDialog.DefaultExt = "json";
            saveFileDialog.Title = @"Save your work";

            if (saveFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            
            _shapeManager.SaveToFile(saveFileDialog.FileName);
        }

        _shapeManager.Clear();
        scenePanel.Invalidate();
    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var result = MessageBox.Show(@"Do you want to save before exiting?", @"Confirm Exit",
            MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

        if (result == DialogResult.Cancel)
        {
            return;
        }
        
        if (result == DialogResult.Yes)
        {
            using var saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = @"JSON files (*.json)|*.json";
            saveFileDialog.DefaultExt = "json";
            saveFileDialog.Title = @"Select a file to save";

            if (saveFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            
            _shapeManager.SaveToFile(saveFileDialog.FileName);
        }

        Application.Exit();
    }

    private void calcAreaToolStripButton_Click(object sender, EventArgs e)
    {
        var selectedShape = _shapeManager.SelectedShape;
        if (selectedShape == null)
        {
            MessageBox.Show(@"Please select a shape to calculate area.", @"Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        var area = selectedShape.CalculateArea();
        MessageBox.Show(@$"Selected {selectedShape.GetType().Name} area: {area:f2}", @"Area",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void statsToolStripButton_Click(object sender, EventArgs e)
    {
        var shapes = _shapeManager.GetShapes();
        if (shapes.Count == 0)
        {
            return;
        }
        
        using var statsForm = new StatisticsForm(shapes);

        statsForm.ShowDialog();
    }
}