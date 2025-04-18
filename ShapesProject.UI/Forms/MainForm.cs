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
    private readonly EditCommandFactoryRegistry _editCommandRegistry = new();

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

        _shapeManager.CommandExecuted += (_, _) => scenePanel.Invalidate();
    }

    private void RegisterCommandFactories()
    {
        _editCommandRegistry.Register<Circle>(new CircleEditCommandFactory());
        _editCommandRegistry.Register<Parallelogram>(new ParallelogramEditCommandFactory());
        _editCommandRegistry.Register<RectangleShape>(new RectangleEditCommandFactory());
        _editCommandRegistry.Register<Rhombus>(new RhombusEditCommandFactory());
        _editCommandRegistry.Register<Trapezoid>(new TrapezoidEditCommandFactory());
        _editCommandRegistry.Register<Triangle>(new TriangleEditCommandFactory());
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

    private void rectangleToolStripMenuItem_Click(object sender, EventArgs e)
    {
        // TODO: Move shape creation to a new form
        // TODO: Think of a way to allow creation of shapes with different sizes
        var rectangle = ShapeFactory.CreateShape<RectangleShape>(0, 0, 100, 50);

        var command = new AddShapeCommand(_shapeManager, rectangle);
        _shapeManager.ExecuteCommand(command);
    }

    private void circleToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var circle = ShapeFactory.CreateShape<Circle>(200, 200, 50);

        var command = new AddShapeCommand(_shapeManager, circle);
        _shapeManager.ExecuteCommand(command);
    }

    private void triangleToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var triangle = ShapeFactory.CreateShape<Triangle>(
                                                        300, 300,   //P1
                                                        350, 350,   //P2
                                                        250, 350);  //P3

        var command = new AddShapeCommand(_shapeManager, triangle);
        _shapeManager.ExecuteCommand(command);
    }

    private void rhombusToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var rhombus = ShapeFactory.CreateShape<Rhombus>(250, 250, 120, 120);

        var command = new AddShapeCommand(_shapeManager, rhombus);
        _shapeManager.ExecuteCommand(command);
    }

    private void parallelogramToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var parallelogram = ShapeFactory.CreateShape<Parallelogram>(150, 150, 120, 120, 30);

        var command = new AddShapeCommand(_shapeManager, parallelogram);
        _shapeManager.ExecuteCommand(command);
    }

    private void trapezoidToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var trapezoid = ShapeFactory.CreateShape<Trapezoid>(150, 250, 220, 180, 100);

        var command = new AddShapeCommand(_shapeManager, trapezoid);
        _shapeManager.ExecuteCommand(command);
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
            MessageBox.Show(@"Please select a shape to edit.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        var oldState = selectedShape.Clone();

        using var editForm = new EditShapeForm(selectedShape);

        if (editForm.ShowDialog() != DialogResult.OK)
        {
            return;
        }
        
        var factory = _editCommandRegistry.GetFactory(selectedShape.GetType());
        var command = factory.Create(selectedShape, oldState);
        _shapeManager.ExecuteCommand(command);
    }

    private void undoToolStripButton_Click(object sender, EventArgs e)
    {
        _shapeManager.Undo();
    }
    
    private void redoToolStripButton_Click(object sender, EventArgs e)
    {
        _shapeManager.Redo();
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
        
        _shapeManager.SaveToFile(saveFileDialog.FileName);
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
        
        _shapeManager.LoadFromFile(openFileDialog.FileName);
        _shapeManager.ClearSelection();
        
        scenePanel.Invalidate();
    }

    private void newToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }


    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
    }

    private void calcAreaToolStripButton_Click(object sender, EventArgs e)
    {
        var selectedShape = _shapeManager.SelectedShape;
        if (selectedShape == null)
        {
            MessageBox.Show(@"Please select a shape to calculate area.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        var area = selectedShape.CalculateArea();
        MessageBox.Show(@$"Selected {selectedShape.GetType().Name} area: {area:f2}", @"Area", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void statsToolStripButton_Click(object sender, EventArgs e)
    {
        var shapes = _shapeManager.GetShapes();
        using var statsForm = new StatisticsForm(shapes);
        
        statsForm.ShowDialog();
    }
}