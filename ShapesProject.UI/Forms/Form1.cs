using System.Drawing.Drawing2D;
using System.Reflection;
using Infrastructure.Factories.Commands;
using Infrastructure.Factories.Shapes;
using ShapeProject.Application.Commands.AddRemove;
using ShapeProject.Application.Commands.Colors;
using ShapeProject.Application.Commands.Core;
using ShapeProject.Application.Commands.Movement;
using ShapeProject.Application.Commands.Selection;
using ShapeProject.Application.Services;
using ShapesProject.Domain.Shapes;
using ShapesProject.Utils;

using ColorConverter=Infrastructure.Converters.ColorConverter;
using PointConverter=Infrastructure.Converters.PointConverter;

namespace ShapesProject.Forms;

public partial class Form1 : Form
{
    private readonly ShapeManager _shapeManager;
    private readonly Scene _scene;
    private readonly Dictionary<Type, IEditCommandFactory> _editCommandFactories = new();
    
    private MoveCommand? _currentMoveCommand;
    private bool _isDragging;
    
    private Point _dragStartPosition;
    
    public Form1()
    {
        InitializeComponent();
        
        // Fix for flickering while moving shapes
        typeof(Panel).InvokeMember("DoubleBuffered",
        BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
        null, scenePanel, new object[] { true });
        
        _shapeManager = new ShapeManager();
        _scene = new Scene(_shapeManager);
        
        // TODO: (Bad Practice) Try to move these outside the UI project, so the ShapesProject.UI.Domain reference can be removed
        _editCommandFactories.Add(typeof(Circle), new CircleEditCommandFactory());
        _editCommandFactories.Add(typeof(Parallelogram), new ParallelogramEditCommandFactory());
        _editCommandFactories.Add(typeof(RectangleShape), new RectangleEditCommandFactory());
        _editCommandFactories.Add(typeof(Rhombus), new RhombusEditCommandFactory());
        _editCommandFactories.Add(typeof(Trapezoid), new TrapezoidEditCommandFactory());
        _editCommandFactories.Add(typeof(Triangle), new TriangleEditCommandFactory());
        
        scenePanel.Paint += panel1_Paint;
        scenePanel.MouseDown += scenePanel_MouseDown;
        scenePanel.MouseMove += scenePanel_MouseMove;
        scenePanel.MouseUp += scenePanel_MouseUp;

        _shapeManager.ShapeAdded += (_, _) => scenePanel.Invalidate();
        _shapeManager.ShapeDeleted += (_, _) => scenePanel.Invalidate();
        _shapeManager.SelectionChanged += (_, _) => scenePanel.Invalidate();
        _shapeManager.CommandExecuted += (_, _) => scenePanel.Invalidate();

        editToolStripButton.Click += editToolStripButton_Click;
    }

    private void panel1_Paint(object? sender, PaintEventArgs e)
    {
        e.Graphics.Clear(scenePanel.BackColor);
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        _scene.DrawShapes(e.Graphics);
    }

    private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {

    }

    private void fileToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }

    private void toolStripDropDownButton1_Click(object sender, EventArgs e)
    {

    }

    private void rectangleToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var rectangle = ShapeFactory.CreateShape("RectangleShape", 0, 0, 100, 50);

        var command = new AddShapeCommand(_shapeManager, rectangle);
        _shapeManager.ExecuteCommand(command);
    }

    private void circleToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var circle = ShapeFactory.CreateShape("Circle", 200, 200, 50);

        var command = new AddShapeCommand(_shapeManager, circle);
        _shapeManager.ExecuteCommand(command);
    }

    private void triangleToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var triangle = ShapeFactory.CreateShape("Triangle",
                                                        300, 300,   //P1
                                                        350, 350,   //P2
                                                        250, 350);  //P3

        var command = new AddShapeCommand(_shapeManager, triangle);
        _shapeManager.ExecuteCommand(command);
    }

    private void rhombusToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var rhombus = ShapeFactory.CreateShape("Rhombus", 250, 250, 120, 120);

        var command = new AddShapeCommand(_shapeManager, rhombus);
        _shapeManager.ExecuteCommand(command);
    }

    private void parallelogramToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var parallelogram = ShapeFactory.CreateShape("Parallelogram", 150, 150, 120, 120, 30);

        var command = new AddShapeCommand(_shapeManager, parallelogram);
        _shapeManager.ExecuteCommand(command);
    }

    private void trapezoidToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var trapezoid = ShapeFactory.CreateShape("Trapezoid", 150, 250, 220, 180, 100);

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

        var point = PointConverter.ToDomainPoint(e.Location);
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
        if (!_isDragging || _shapeManager.SelectedShape == null || e.Button != MouseButtons.Left)
        {
            return;
        }

        var dx = e.X - _dragStartPosition.X;
        var dy = e.Y - _dragStartPosition.Y;

        var selectedShape = _shapeManager.SelectedShape;
        if (dx == 0 && dy == 0)
        {
            return;
        }

        if (_currentMoveCommand == null)
        {
            _currentMoveCommand = new MoveCommand(selectedShape, dx, dy);
        }
        else
        {
            _currentMoveCommand.AccumulateMovement(dx, dy);
        }

        selectedShape.TempOffsetX = _currentMoveCommand.TotalDx;
        selectedShape.TempOffsetY = _currentMoveCommand.TotalDy;

        _dragStartPosition = e.Location;

        scenePanel.Invalidate();
    }

    private void scenePanel_MouseUp(object? sender, MouseEventArgs e)
    {
        var selectedShape = _shapeManager.SelectedShape;

        if (_isDragging && selectedShape != null)
        {
            // Clear
            selectedShape.TempOffsetX = 0;
            selectedShape.TempOffsetY = 0;

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
            MessageBox.Show(@"Please select a shape to edit.");
            return;
        }

        var oldState = selectedShape.Clone();

        using var editForm = new EditShapeForm(selectedShape);

        if (editForm.ShowDialog() != DialogResult.OK)
        {
            return;
        }
        
        var shapeType = selectedShape.GetType();
        if (!_editCommandFactories.TryGetValue(shapeType, out var factory))
        {
            return;
        }
        
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

        var customColor = ColorConverter.ToDomainColor(colorDialog.Color);

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

        var customColor = ColorConverter.ToDomainColor(colorDialog.Color);

        var command = new ChangeBorderColorCommand(selectedShape, customColor);
        _shapeManager.ExecuteCommand(command);
    }

    private void saveToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }

    private void newToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }

    private void loadToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
    }
}