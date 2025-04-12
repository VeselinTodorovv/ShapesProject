using System.Drawing;
using ShapesProject.Domain.Primitives;

namespace Infrastructure.Converters;

public static class ColorConverter
{
    public static CustomColor ToDomainColor(Color color) => new(color.R, color.G, color.B, color.A);

    public static Color ToSystemColor(CustomColor color) => Color.FromArgb(color.A, color.R, color.G, color.B);
}