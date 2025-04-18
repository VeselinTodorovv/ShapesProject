using Infrastructure.Factories.Shapes;
using ShapeProject.Application.Commands.AddRemove;
using ShapeProject.Application.Services;
using ShapesProject.Domain.Shapes;

namespace ShapesProject.Forms;

public partial class CreateShapeForm : Form
{
    private readonly ShapeManager _shapeManager;

    public CreateShapeForm(ShapeManager shapeManager)
    {
        InitializeComponent();
        _shapeManager = shapeManager;

    }

    private void btnRectangle_Click(object? sender, EventArgs e)
    {
        var rectangle = ShapeFactory.CreateShape<RectangleShape>(0, 0, 100, 50);

        var command = new AddShapeCommand(_shapeManager, rectangle);
        _shapeManager.ExecuteCommand(command);

        DialogResult = DialogResult.OK;
        Close();
    }

    private void btnCircle_Click(object? sender, EventArgs e)
    {
        var circle = ShapeFactory.CreateShape<Circle>(200, 200, 50);

        var command = new AddShapeCommand(_shapeManager, circle);
        _shapeManager.ExecuteCommand(command);

        DialogResult = DialogResult.OK;
        Close();
    }

    private void btnTriangle_Click(object? sender, EventArgs e)
    {
        var triangle = ShapeFactory.CreateShape<Triangle>(
            300, 300,   // P1
            350, 350,   // P2
            250, 350);  // P3

        var command = new AddShapeCommand(_shapeManager, triangle);
        _shapeManager.ExecuteCommand(command);

        DialogResult = DialogResult.OK;
        Close();
    }

    private void btnRhombus_Click(object? sender, EventArgs e)
    {
        var rhombus = ShapeFactory.CreateShape<Rhombus>(250, 250, 120, 120);

        var command = new AddShapeCommand(_shapeManager, rhombus);
        _shapeManager.ExecuteCommand(command);

        DialogResult = DialogResult.OK;
        Close();
    }

    private void btnParallelogram_Click(object? sender, EventArgs e)
    {
        var parallelogram = ShapeFactory.CreateShape<Parallelogram>(150, 150, 120, 120, 30);

        var command = new AddShapeCommand(_shapeManager, parallelogram);
        _shapeManager.ExecuteCommand(command);

        DialogResult = DialogResult.OK;
        Close();
    }

    private void btnTrapezoid_Click(object? sender, EventArgs e)
    {
        var trapezoid = ShapeFactory.CreateShape<Trapezoid>(150, 250, 220, 180, 100);

        var command = new AddShapeCommand(_shapeManager, trapezoid);
        _shapeManager.ExecuteCommand(command);

        DialogResult = DialogResult.OK;
        Close();
    }
}