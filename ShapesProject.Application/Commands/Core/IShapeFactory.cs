using ShapesProject.Domain.Shapes;

namespace ShapeProject.Application.Commands.Core;

public interface IShapeFactory
{
    Shape Create(params int[] args);
}