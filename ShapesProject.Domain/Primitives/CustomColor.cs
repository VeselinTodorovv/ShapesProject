namespace ShapesProject.Domain.Primitives;

public struct CustomColor
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

    public static CustomColor White => new CustomColor(255, 255, 255);
    public static CustomColor Black => new CustomColor(0, 0, 0);
}