using System.ComponentModel;
using ShapesProject.Domain.Shapes;

namespace ShapesProject.Utils;

public static class ProviderRegistration
{
    public static void RegisterProvider()
    {
        TypeDescriptor.AddProvider(
            new ShapeDescriptionProvider(TypeDescriptor.GetProvider(typeof(Shape))),
            typeof(Shape));
    }
}