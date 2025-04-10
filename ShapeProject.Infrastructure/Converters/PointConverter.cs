using System.Drawing;
using ShapesProject.Domain.Primitives;

namespace Infrastructure.Converters;

public class PointConverter
{
    public static CustomPoint ToDomainPoint(Point point) => new(point.X, point.Y);

    public static Point ToSystemPoint(CustomPoint point) => new(point.X, point.Y);
}