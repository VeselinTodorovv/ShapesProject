using System.Drawing;
using ShapesProject.Domain.Primitives;

namespace Infrastructure.Converters;

public abstract class PointConverter
{
    public static CustomPoint ToDomainPoint(Point point) => new(point.X, point.Y);
}