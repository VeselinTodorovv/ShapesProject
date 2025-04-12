using ShapeProject.Application.Services;
using ShapesProject.Forms.Renderers;

namespace ShapesProject;

public class Scene
{
    private readonly ShapeManager _shapeManager;

    public Scene(ShapeManager shapeManager)
    {
        _shapeManager = shapeManager;
    }

    public void DrawShapes(Graphics g)
    {
        var renderer = new GraphicsRenderer(g);
        foreach (var shape in _shapeManager.GetShapes())
        {
            shape.Accept(renderer);
        }
    }
}