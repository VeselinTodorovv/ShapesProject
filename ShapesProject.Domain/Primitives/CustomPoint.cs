namespace ShapesProject.Domain.Primitives;

public struct CustomPoint
{
    public int X { get; }
    public int Y { get; }

    public CustomPoint(int x, int y)
    {
        X = x;
        Y = y;
    }
}