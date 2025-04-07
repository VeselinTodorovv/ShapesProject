using ShapesProject.Models;
using ShapesProject.Utils;
using ShapesProject.Utils.Commands;
using System.Drawing.Drawing2D;
using System.Reflection;

namespace ShapesProject;

public partial class Form1 : Form
{
    private readonly ShapeManager _shapeManager;
    private readonly Scene _scene;

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

    private void whatToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }

    private void toolStripDropDownButton1_Click(object sender, EventArgs e)
    {

    }

    private void toolStripButton1_Click(object sender, EventArgs e)
    {

    }

    private void rectangleToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var rectangle = new RectangleShape(50, 50, 100, 50);

        var command = new AddShapeCommand(_shapeManager, rectangle);
        _shapeManager.ExecuteCommand(command);
    }

    private void circleToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var circle = new Circle(200, 200, 50);

        var command = new AddShapeCommand(_shapeManager, circle);
        _shapeManager.ExecuteCommand(command);
    }

    private void triangleToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var triangle = new Triangle(new Point(300, 300), new Point(350, 350), new Point(250, 350));

        var command = new AddShapeCommand(_shapeManager, triangle);
        _shapeManager.ExecuteCommand(command);

    }

    private void rhombusToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var rhombus = new Rhombus(250, 250, 120, 120);

        var command = new AddShapeCommand(_shapeManager, rhombus);
        _shapeManager.ExecuteCommand(command);
    }

    private void parallelogramToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var parallelogram = new Parallelogram(150, 150, 120, 120, 30);

        var command = new AddShapeCommand(_shapeManager, parallelogram);
        _shapeManager.ExecuteCommand(command);
    }

    private void trapezoidToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var trapezoid = new Trapezoid(150, 250, 220, 180, 100);

        var command = new AddShapeCommand(_shapeManager, trapezoid);
        _shapeManager.ExecuteCommand(command);
    }

    private void scenePanel_MouseDown(object? sender, MouseEventArgs e)
    {
        _shapeManager.ClearSelection();

        var newSelection = _shapeManager.GetShapes()
            .FirstOrDefault(shape => shape.Contains(e.Location));

        if (newSelection != null)
        {
            var selectCommand = new SelectCommand(newSelection, true);

            _shapeManager.ExecuteCommand(selectCommand);
            _dragStartPosition = e.Location;
        }
        else
        {
            _shapeManager.ClearSelection();
        }
    }

    private void scenePanel_MouseUp(object? sender, MouseEventArgs e)
    {
        _dragStartPosition = Point.Empty;
    }

    private void scenePanel_MouseMove(object? sender, MouseEventArgs e)
    {
        if (_shapeManager.SelectedShape == null || e.Button != MouseButtons.Left)
        {
            return;
        }

        var dx = e.X - _dragStartPosition.X;
        var dy = e.Y - _dragStartPosition.Y;

        if (dx == 0 && dy == 0)
        {
            return;
        }

        var moveCommand = new MoveCommand(_shapeManager.SelectedShape, dx, dy);

        _shapeManager.ExecuteCommand(moveCommand);
        _dragStartPosition = e.Location;
    }

    private void editToolStripButton_Click(object? sender, EventArgs e)
    {
    }

    private void toolStripButton3_Click(object sender, EventArgs e)
    {

    }

    private void deleteStripButton_Click(object sender, EventArgs e)
    {
        if (_shapeManager.SelectedShape == null)
        {
            return;
        }

        var deleteCommand = new DeleteShapeCommand(_shapeManager, _shapeManager.SelectedShape);
        _shapeManager.ExecuteCommand(deleteCommand);
    }
}