using System.ComponentModel;

namespace ShapesProject.Utils;

public class ShapeTypeDescriptor : CustomTypeDescriptor
{
    public ShapeTypeDescriptor(ICustomTypeDescriptor parent)
        : base(parent)
    {
    }
    
    public override PropertyDescriptorCollection GetProperties()
    {
        return FilterProperties(base.GetProperties());
    }

    public override PropertyDescriptorCollection GetProperties(Attribute[]? attributes)
    {
        return FilterProperties(base.GetProperties(attributes));
    }

    private static PropertyDescriptorCollection FilterProperties(PropertyDescriptorCollection originalProperties)
    {
        return new PropertyDescriptorCollection(originalProperties
            .Cast<PropertyDescriptor>()
            .Where(pd =>!IsExcluded(pd)) 
            .ToArray(), true);
    }

    private static bool IsExcluded(PropertyDescriptor property)
    {
        return ExcludedPropertyNames.Contains(property.Name);
    }
    
    private static readonly HashSet<string> ExcludedPropertyNames = new()
    {
        "TempOffsetX",
        "TempOffsetY",
        "IsSelected",
        "FillColor",
        "BorderColor",
        "SelectionBorderWidth",
        "X",
        "Y"
    };
}