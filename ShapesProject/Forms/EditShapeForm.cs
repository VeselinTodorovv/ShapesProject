using ShapesProject.Models;

namespace ShapesProject.Forms;

public partial class EditShapeForm : Form
{
    private readonly Shape _shape;

    public EditShapeForm(Shape shape)
    {
        InitializeComponent();

        _shape = shape;
        propertyGrid1.SelectedObject = _shape;
    }

    private void propertyGrid1_Click(object sender, EventArgs e)
    {

    }

    private void btnApply_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.OK;
        Close();
    }
}