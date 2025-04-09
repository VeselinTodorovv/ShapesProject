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

        btnApply.Click += btnApply_Click!;
        btnCancel.Click += btnCancel_Click!;
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
