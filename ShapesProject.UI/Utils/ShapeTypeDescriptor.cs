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
            .Where(pd => pd.Name != "TempOffsetX" &&
                         pd.Name != "TempOffsetY" &&
                         pd.Name != "IsSelected" &&
                         pd.Name != "FillColor" &&
                         pd.Name != "BorderColor" &&
                         pd.Name != "SelectionBorderWidth")
            .ToArray(), true);
    }
}