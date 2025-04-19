using System.Reflection;
using ShapesProject.Domain.Shapes;
using ShapesProject.Forms.Renderers;

namespace ShapesProject.Forms;

public partial class EditShapeForm : Form
{
    private readonly Shape _shape;

    public EditShapeForm(Shape shape)
    {
        InitializeComponent();
        
        typeof(Panel).InvokeMember("DoubleBuffered",
        BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
        null, previewPanel, new object[] { true });

        _shape = shape;
        propertyGrid.SelectedObject = _shape;

        propertyGrid.PropertyValueChanged += (_, _) =>
        {
            var error = shape.Validate();
            if (error != null)
            {
                MessageBox.Show(error, @"Invalid value",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                return;
            }
            
            previewPanel.Invalidate();
        };

        btnApply.Click += btnApply_Click;
        btnCancel.Click += btnCancel_Click;
    }

    private void btnApply_Click(object? sender, EventArgs e)
    {
        var error = _shape.Validate();
        if (error != null)
        {
            MessageBox.Show(error, @"Invalid value",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
            return;
        }
        
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