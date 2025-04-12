using ShapesProject.Domain.Shapes;

namespace ShapesProject.Forms;

public partial class EditShapeForm : Form
{
    public EditShapeForm(Shape shape)
    {
        InitializeComponent();

        propertyGrid.SelectedObject = shape;

        btnApply.Click += btnApply_Click;
        btnCancel.Click += btnCancel_Click;
    }

    private void btnApply_Click(object? sender, EventArgs e)
    {
        DialogResult = DialogResult.OK;
        Close();
    }

    private void btnCancel_Click(object? sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
        Close();
    }
}