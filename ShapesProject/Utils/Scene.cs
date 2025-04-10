namespace ShapesProject.Utils;

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
            shape.Draw(g);
        }
    }
}