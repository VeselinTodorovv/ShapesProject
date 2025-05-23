﻿namespace ShapesProject.Domain.Primitives;

public class CustomPoint
{
    public int X { get; set; }
    public int Y { get; set; }

    public CustomPoint(int x, int y)
    {
        X = x;
        Y = y;
    }

    public override string ToString() => $"{X}, {Y}";
}