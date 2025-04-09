using ShapesProject.Models;

namespace ShapesProject.Forms;

public partial class CircleEditForm : Form
{
    public int NewRadius { get; private set; }
    public Color NewFillColor { get; private set; }
    public Color NewBorderColor { get; private set; }

    private Circle _circle;

    public CircleEditForm(Circle circle)
    {
        InitializeComponent();

        _circle = circle
            ?? throw new ArgumentNullException(nameof(circle));

        numRadius.Value = _circle.Radius;
        pnlFillColor.BackColor = _circle.FillColor;
        pnlBorderColor.BackColor = _circle.BorderColor;
    }

    private void CircleEditForm_Load(object sender, EventArgs e)
    {

    }

    private void btnPickFill_Click(object sender, EventArgs e)
    {
        using var dialog = new ColorDialog();
        dialog.Color = pnlFillColor.BackColor;

        if (dialog.ShowDialog() == DialogResult.OK)
        {
            pnlFillColor.BackColor = dialog.Color;
        }
    }

    private void btnPickBorder_Click(object sender, EventArgs e)
    {
        using var dialog = new ColorDialog();
        dialog.Color = pnlBorderColor.BackColor;

        if (dialog.ShowDialog() == DialogResult.OK)
        {
            pnlBorderColor.BackColor = dialog.Color;
        }
    }

    private void btnOK_Click(object sender, EventArgs e)
    {
        NewRadius = Convert.ToInt32(numRadius.Value);
        NewFillColor = pnlFillColor.BackColor;
        NewBorderColor = pnlBorderColor.BackColor;
        DialogResult = DialogResult.OK;

        _circle.Radius = NewRadius;
        _circle.FillColor = NewFillColor;
        _circle.BorderColor = NewBorderColor;
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
    }

    private void numRadius_ValueChanged(object sender, EventArgs e)
    {

    }
}