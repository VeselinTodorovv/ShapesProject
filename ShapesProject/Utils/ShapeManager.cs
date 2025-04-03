using ShapesProject.Models;

namespace ShapesProject.Utils;

public class ShapeManager
{
    private readonly List<Shape> _shapes = new();
    private Shape? _selectedShape;

    public event EventHandler<ShapeEventArgs>? ShapeSelected;
    public event EventHandler<ShapeEventArgs>? ShapeMoved;
    public event EventHandler<ShapeEventArgs>? ShapeAdded;
    public event EventHandler<ShapeEventArgs>? ShapeDeleted;

    public IReadOnlyList<Shape> GetShapes() => _shapes.AsReadOnly();

    public void AddShape(Shape shape)
    {
        _shapes.Add(shape);
        ShapeAdded?.Invoke(this, new ShapeEventArgs(shape));
    }

    public void DeleteShape(Shape shape)
    {
        if (_shapes.Remove(shape))
        {
            ShapeDeleted?.Invoke(this, new ShapeEventArgs(shape));
        }
    }

    public void SelectShape(Shape shape)
    {
        ShapeSelected?.Invoke(this, new ShapeEventArgs(shape));
    }

    public void MoveShape(Shape shape, int x, int y)
    {
        shape.Move(x, y);
        ShapeMoved?.Invoke(this, new ShapeEventArgs(shape));
    }

    internal void DeselectShape()
    {
        if (_selectedShape != null)
        {
            var deselectedShape = _selectedShape;
            _selectedShape = null;

            ShapeSelected?.Invoke(this, new ShapeEventArgs(deselectedShape));
        }
    }
}