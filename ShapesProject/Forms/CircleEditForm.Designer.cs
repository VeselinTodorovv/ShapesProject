using System.ComponentModel;

namespace ShapesProject.Forms;

partial class CircleEditForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        lblRadius = new Label();
        numRadius = new NumericUpDown();
        lblFillColor = new Label();
        pnlFillColor = new Panel();
        btnPickFill = new Button();
        btnPickBorder = new Button();
        pnlBorderColor = new Panel();
        lblBorderColor = new Label();
        btnOK = new Button();
        btnCancel = new Button();
        ((ISupportInitialize)numRadius).BeginInit();
        SuspendLayout();
        // 
        // lblRadius
        // 
        lblRadius.AutoSize = true;
        lblRadius.Location = new Point(12, 14);
        lblRadius.Name = "lblRadius";
        lblRadius.Size = new Size(45, 15);
        lblRadius.TabIndex = 0;
        lblRadius.Text = "Radius:";
        // 
        // numRadius
        // 
        numRadius.Location = new Point(75, 12);
        numRadius.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
        numRadius.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numRadius.Name = "numRadius";
        numRadius.Size = new Size(64, 23);
        numRadius.TabIndex = 1;
        numRadius.Value = new decimal(new int[] { 1, 0, 0, 0 });
        numRadius.ValueChanged += numRadius_ValueChanged;
        // 
        // lblFillColor
        // 
        lblFillColor.AutoSize = true;
        lblFillColor.Location = new Point(12, 61);
        lblFillColor.Name = "lblFillColor";
        lblFillColor.Size = new Size(57, 15);
        lblFillColor.TabIndex = 2;
        lblFillColor.Text = "Fill Color:";
        // 
        // pnlFillColor
        // 
        pnlFillColor.BackColor = Color.White;
        pnlFillColor.Location = new Point(173, 56);
        pnlFillColor.Name = "pnlFillColor";
        pnlFillColor.Size = new Size(30, 29);
        pnlFillColor.TabIndex = 3;
        // 
        // btnPickFill
        // 
        btnPickFill.Location = new Point(93, 52);
        btnPickFill.Name = "btnPickFill";
        btnPickFill.Size = new Size(64, 33);
        btnPickFill.TabIndex = 4;
        btnPickFill.Text = "Pick...";
        btnPickFill.UseVisualStyleBackColor = true;
        btnPickFill.Click += btnPickFill_Click;
        // 
        // btnPickBorder
        // 
        btnPickBorder.Location = new Point(93, 99);
        btnPickBorder.Name = "btnPickBorder";
        btnPickBorder.Size = new Size(64, 33);
        btnPickBorder.TabIndex = 7;
        btnPickBorder.Text = "Pick...";
        btnPickBorder.UseVisualStyleBackColor = true;
        btnPickBorder.Click += btnPickBorder_Click;
        // 
        // pnlBorderColor
        // 
        pnlBorderColor.BackColor = Color.White;
        pnlBorderColor.Location = new Point(173, 103);
        pnlBorderColor.Name = "pnlBorderColor";
        pnlBorderColor.Size = new Size(30, 29);
        pnlBorderColor.TabIndex = 6;
        // 
        // lblBorderColor
        // 
        lblBorderColor.AutoSize = true;
        lblBorderColor.Location = new Point(10, 108);
        lblBorderColor.Name = "lblBorderColor";
        lblBorderColor.Size = new Size(77, 15);
        lblBorderColor.TabIndex = 5;
        lblBorderColor.Text = "Border Color:";
        // 
        // btnOK
        // 
        btnOK.Location = new Point(12, 184);
        btnOK.Name = "btnOK";
        btnOK.Size = new Size(75, 23);
        btnOK.TabIndex = 8;
        btnOK.Text = "OK";
        btnOK.UseVisualStyleBackColor = true;
        btnOK.Click += btnOK_Click;
        // 
        // btnCancel
        // 
        btnCancel.Location = new Point(93, 184);
        btnCancel.Name = "btnCancel";
        btnCancel.Size = new Size(75, 23);
        btnCancel.TabIndex = 9;
        btnCancel.Text = "Cancel";
        btnCancel.UseVisualStyleBackColor = true;
        btnCancel.Click += btnCancel_Click;
        // 
        // CircleEditForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(215, 219);
        Controls.Add(btnCancel);
        Controls.Add(btnOK);
        Controls.Add(btnPickBorder);
        Controls.Add(pnlBorderColor);
        Controls.Add(lblBorderColor);
        Controls.Add(btnPickFill);
        Controls.Add(pnlFillColor);
        Controls.Add(lblFillColor);
        Controls.Add(numRadius);
        Controls.Add(lblRadius);
        Name = "CircleEditForm";
        Text = "CircleEditForm";
        Load += CircleEditForm_Load;
        ((ISupportInitialize)numRadius).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblRadius;
    private NumericUpDown numRadius;
    private Label lblFillColor;
    private Panel pnlFillColor;
    private Button btnPickFill;
    private Button btnPickBorder;
    private Panel pnlBorderColor;
    private Label lblBorderColor;
    private Button btnOK;
    private Button btnCancel;
}