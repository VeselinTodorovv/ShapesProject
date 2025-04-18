using System.ComponentModel;
using System.Drawing;

namespace ShapesProject.Forms;

partial class CreateShapeForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new Container();
        toolTip = new ToolTip(components);
        panelShadow = new Panel();
        lblTitle = new Label();
        btnRectangle = new Button();
        btnCircle = new Button();
        btnTriangle = new Button();
        btnRhombus = new Button();
        btnParallelogram = new Button();
        btnTrapezoid = new Button();
        panelShadow.SuspendLayout();
        SuspendLayout();
        // 
        // panelShadow
        // 
        panelShadow.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        panelShadow.BackColor = SystemColors.Control;
        panelShadow.BorderStyle = BorderStyle.FixedSingle;
        panelShadow.Controls.Add(lblTitle);
        panelShadow.Controls.Add(btnRectangle);
        panelShadow.Controls.Add(btnCircle);
        panelShadow.Controls.Add(btnTriangle);
        panelShadow.Controls.Add(btnRhombus);
        panelShadow.Controls.Add(btnParallelogram);
        panelShadow.Controls.Add(btnTrapezoid);
        panelShadow.Location = new Point(10, 10);
        panelShadow.Name = "panelShadow";
        panelShadow.Size = new Size(255, 370);
        panelShadow.TabIndex = 0;
        // 
        // lblTitle
        // 
        lblTitle.BackColor = Color.Transparent;
        lblTitle.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
        lblTitle.ForeColor = Color.Black;
        lblTitle.Location = new Point(3, 10);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(230, 45);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Add Shape";
        lblTitle.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // btnRectangle
        // 
        btnRectangle.Location = new Point(19, 96);
        btnRectangle.Name = "btnRectangle";
        btnRectangle.Size = new Size(92, 23);
        btnRectangle.TabIndex = 1;
        btnRectangle.Text = "Rectangle";
        btnRectangle.Click += btnRectangle_Click;
        // 
        // btnCircle
        // 
        btnCircle.Location = new Point(141, 96);
        btnCircle.Name = "btnCircle";
        btnCircle.Size = new Size(92, 23);
        btnCircle.TabIndex = 2;
        btnCircle.Text = "Circle";
        btnCircle.Click += btnCircle_Click;
        // 
        // btnTriangle
        // 
        btnTriangle.Location = new Point(19, 168);
        btnTriangle.Name = "btnTriangle";
        btnTriangle.Size = new Size(92, 23);
        btnTriangle.TabIndex = 3;
        btnTriangle.Text = "Triangle";
        btnTriangle.Click += btnTriangle_Click;
        // 
        // btnRhombus
        // 
        btnRhombus.Location = new Point(19, 246);
        btnRhombus.Name = "btnRhombus";
        btnRhombus.Size = new Size(92, 23);
        btnRhombus.TabIndex = 4;
        btnRhombus.Text = "Rhombus";
        btnRhombus.Click += btnRhombus_Click;
        // 
        // btnParallelogram
        // 
        btnParallelogram.Location = new Point(141, 168);
        btnParallelogram.Name = "btnParallelogram";
        btnParallelogram.Size = new Size(92, 23);
        btnParallelogram.TabIndex = 5;
        btnParallelogram.Text = "Parallelogram";
        btnParallelogram.Click += btnParallelogram_Click;
        // 
        // btnTrapezoid
        // 
        btnTrapezoid.Location = new Point(141, 246);
        btnTrapezoid.Name = "btnTrapezoid";
        btnTrapezoid.Size = new Size(92, 23);
        btnTrapezoid.TabIndex = 6;
        btnTrapezoid.Text = "Trapezoid";
        btnTrapezoid.Click += btnTrapezoid_Click;
        // 
        // CreateShapeForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.Control;
        ClientSize = new Size(275, 390);
        Controls.Add(panelShadow);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "CreateShapeForm";
        ShowIcon = false;
        StartPosition = FormStartPosition.CenterParent;
        Text = "Add Shape";
        panelShadow.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private Label lblTitle;
    private Button btnRectangle;
    private Button btnCircle;
    private Button btnTriangle;
    private Button btnRhombus;
    private Button btnParallelogram;
    private Button btnTrapezoid;
    private ToolTip toolTip;
    private Panel panelShadow;

    /// <summary>
    /// Helper method to initialize all button style properties consistently.
    /// </summary>
    private void ConfigureShapeButton(Button b, string text, string emoji, Color accent, int top, int tabIndex, string tip)
    {
        b.Size = new Size(210, 45);
        b.Location = new Point(22, top);
        b.BackColor = Color.FromArgb(44, 62, 80);
        b.FlatStyle = FlatStyle.Flat;
        b.Font = new Font("Segoe UI", 13.5F, FontStyle.Bold, GraphicsUnit.Point);
        b.ForeColor = accent;
        b.TextAlign = ContentAlignment.MiddleLeft;
        b.TabIndex = tabIndex;
        b.Text = $"  {emoji}    {text}";
        b.FlatAppearance.BorderSize = 0;
        b.FlatAppearance.MouseDownBackColor = Color.FromArgb(36, 49, 60);
        b.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 73, 94);
        b.Cursor = Cursors.Hand;
        toolTip.SetToolTip(b, tip);
    }
}