using ShapesProject.Domain.Shapes;
using ShapesProject.Forms.Renderers;

namespace ShapesProject.Forms;

public partial class EditShapeForm : Form
{
    private readonly Shape _shape;

    public EditShapeForm(Shape shape)
    {
        InitializeComponent();

        _shape = shape;
        propertyGrid.SelectedObject = _shape;

        propertyGrid.PropertyValueChanged += (_, _) => previewPanel.Invalidate();

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

    private void previewPanel_Paint(object sender, PaintEventArgs e)
    {
        e.Graphics.Clear(previewPanel.BackColor);

        var renderer = new PreviewRenderer(e.Graphics, previewPanel.ClientSize);
        _shape.Accept(renderer);
    }
}