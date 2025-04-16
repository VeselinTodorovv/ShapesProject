using System.ComponentModel;
using System.Drawing;
using ShapesProject.Domain.Primitives;

namespace Infrastructure.Converters;

public class CustomPointConverter : TypeConverter
{
    public override bool GetPropertiesSupported(ITypeDescriptorContext? context) => true;

    public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext? context, object value, Attribute[]? attributes)
    {
        return TypeDescriptor.GetProperties(typeof(CustomPoint), attributes);
    }

    public static CustomPoint ToDomainPoint(Point point) => new(point.X, point.Y);
}