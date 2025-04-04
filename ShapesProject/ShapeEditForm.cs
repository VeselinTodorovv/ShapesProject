using ShapesProject.Models;

namespace ShapesProject
{
    public partial class ShapeEditForm : Form
    {
        private readonly Shape _shape;

        public ShapeEditForm(Shape shape)
        {
            InitializeComponent();
            _shape = shape ?? throw new ArgumentNullException(nameof(shape));
        }

        private void ShapeEditForm_Load(object sender, EventArgs e)
        {
        }
    }
}