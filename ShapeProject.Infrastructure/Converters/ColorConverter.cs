using ShapesProject.Domain.Primitives;

namespace Infrastructure.Converters;

public static class ColorConverter
{
    public static CustomColor ToDomainColor(System.Drawing.Color color) => new(color.R, color.G, color.B, color.A);

    public static System.Drawing.Color ToSystemColor(CustomColor color) => System.Drawing.Color.FromArgb(color.A, color.R, color.G, color.B);
}