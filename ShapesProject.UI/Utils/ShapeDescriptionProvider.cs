using System.ComponentModel;

namespace ShapesProject.Utils;

public class ShapeDescriptionProvider : TypeDescriptionProvider
{
    public ShapeDescriptionProvider(TypeDescriptionProvider parent)
        : base(parent)
    {
    }

    public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object? instance)
    {
        var descriptor = base.GetTypeDescriptor(objectType, instance)
                         ?? throw new InvalidOperationException();

        return new ShapeTypeDescriptor(descriptor);
    }
}