using ShapesProject.Utils;

namespace ShapesProject.Models;

public class Scene
{
    private readonly ShapeManager _shapeManager;

    public Scene(ShapeManager shapeManager)
    {
        _shapeManager = shapeManager;
    }

    public void DrawShapes(Graphics g)
    {
        foreach (var shape in _shapeManager.GetShapes())
        {
            Console.WriteLine($@"{shape.GetType().Name}: {shape.CalculateArea()}");
            shape.Draw(g);
        }
    }
}