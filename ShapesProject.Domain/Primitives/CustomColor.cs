namespace ShapesProject.Domain.Primitives;

public class CustomColor
{
    public byte R { get; }
    public byte G { get; }
    public byte B { get; }
    public byte A { get; }

    public CustomColor(byte r, byte g, byte b, byte a = 255)
    {
        R = r;
        G = g;
        B = b;
        A = a;
    }

    internal static CustomColor White => new(255, 255, 255);
    internal static CustomColor Black => new(0, 0, 0);
}