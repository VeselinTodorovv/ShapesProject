
namespace ShapesProject.Models
{
    class Trapezoid : Shape
    {
        public int Base1 { get; protected set; }
        public int Base2 { get; protected set; }
        public int Height { get; protected set; }

        public Trapezoid(int x, int y, int base1, int base2, int height) : base(x, y)
        {
            if (base1 <= 0 || base2 <= 0 || height <= 0)
            {
                throw new ArgumentException("Base lengths and height must be positive.");
            }

            Base1 = base1;
            Base2 = base2;
            Height = height;
        }

        public override double CalculateArea() => (Base1 + Base2) * Height / 2.0;

        public override void Draw(Graphics g)
        {
            using Pen pen = new(BorderColor);
            using SolidBrush brush = new(FillColor);

            // Correctly calculate the points for the trapezoid
            Point[] points = {
                new(X, Y),  // Top-left corner
                new(X + Base1, Y),  // Top-right corner
                new(X + Base1 - Base2 + (Base1 - Base2) / 2, Y + Height),  // Bottom-right corner
                new(X + (Base1 - Base2) / 2, Y + Height)  // Bottom-left corner
            };

            g.FillPolygon(brush, points);
            g.DrawPolygon(pen, points);
        }

        public override void EditSize(params int[] parameters)
        {
            if (parameters.Length == 3 && parameters[0] > 0 && parameters[1] > 0 && parameters[2] > 0)
            {
                Base1 = parameters[0];
                Base2 = parameters[1];
                Height = parameters[2];
            }
            else
            {
                throw new ArgumentException("Values must be positive.");
            }
        }

        public override bool Contains(Point p)
        {
            // Check if the point is within the bounding rectangle of the trapezoid
            return p.X >= X && p.X <= X + Math.Max(Base1, Base2) &&
                   p.Y >= Y && p.Y <= Y + Height;
        }
    }
}