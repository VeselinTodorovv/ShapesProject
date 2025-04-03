using ShapesProject.Models;
using ShapesProject.Utils;
using System.Drawing.Drawing2D;
using System.Reflection;

namespace ShapesProject
{
    public partial class Form1 : Form
    {
        private readonly ShapeManager _shapeManager;
        private readonly Scene _scene;

        private Shape? _selectedShape;
        private Point _dragStartPosition;

        public Form1()
        {
            InitializeComponent();

            typeof(Panel).InvokeMember("DoubleBuffered",
                BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
                null,
                scenePanel,
                new object[] { true });


            _shapeManager = new ShapeManager();
            _scene = new Scene(_shapeManager);

            scenePanel.Paint += panel1_Paint;
            scenePanel.MouseDown += scenePanel_MouseDown;
            scenePanel.MouseMove += scenePanel_MouseMove;
            scenePanel.MouseUp += scenePanel_MouseUp;

            _shapeManager.ShapeAdded += (s, e) => scenePanel.Invalidate();
            _shapeManager.ShapeDeleted += (s, e) => scenePanel.Invalidate();
            _shapeManager.ShapeMoved += (s, e) => scenePanel.Invalidate();
            _shapeManager.ShapeSelected += (s, e) => scenePanel.Invalidate();

            editToolStripButton.Click += new EventHandler(editToolStripButton_Click);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(scenePanel.BackColor);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            _scene.DrawShapes(e.Graphics);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void whatToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void rectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rectangle = new RectangleShape(50, 50, 100, 50);
            _shapeManager.AddShape(rectangle);
            scenePanel.Invalidate();
        }

        private void circleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var circle = new Circle(200, 200, 50);
            _shapeManager.AddShape(circle);
            scenePanel.Invalidate();
        }

        private void triangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var triangle = new Triangle(new Point(300, 300), new Point(350, 350), new Point(250, 350));
            _shapeManager.AddShape(triangle);
            scenePanel.Invalidate();
        }

        private void rhombusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rhombus = new Rhombus(250, 250, 120, 120);
            _shapeManager.AddShape(rhombus);
            scenePanel.Invalidate();
        }

        private void parallelogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var parallelogram = new Parallelogram(150, 150, 120, 120, 30);
            _shapeManager.AddShape(parallelogram);
            scenePanel.Invalidate();
        }

        private void trapezoidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var trapezoid = new Trapezoid(150, 250, 220, 180, 100);
            _shapeManager.AddShape(trapezoid);
            scenePanel.Invalidate();
        }

        private void scenePanel_MouseDown(object sender, MouseEventArgs e)
        {
            foreach (var shape in _shapeManager.GetShapes())
            {
                if (shape.Contains(e.Location))
                {
                    _selectedShape = shape;
                    _shapeManager.SelectShape(shape);
                    _dragStartPosition = e.Location;

                    break;
                }
            }
        }

        private void scenePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (_selectedShape != null && e.Button == MouseButtons.Left)
            {
                var dx = e.X - _dragStartPosition.X;
                var dy = e.Y - _dragStartPosition.Y;

                _shapeManager.MoveShape(_selectedShape, dx, dy);

                _dragStartPosition = e.Location;

                scenePanel.Invalidate();
            }
        }

        private void scenePanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (_selectedShape != null && !_selectedShape.Contains(e.Location))
            {
                _selectedShape = null;
                _shapeManager.DeselectShape();
            }
        }

        private void editToolStripButton_Click(object sender, EventArgs e)
        {
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }
    }
}