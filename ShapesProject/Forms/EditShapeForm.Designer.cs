using System.ComponentModel;

namespace ShapesProject.Forms;

partial class EditShapeForm
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
        propertyGrid1 = new PropertyGrid();
        btnApply = new Button();
        btnCancel = new Button();
        SuspendLayout();
        // 
        // propertyGrid1
        // 
        propertyGrid1.Location = new Point(12, 12);
        propertyGrid1.Name = "propertyGrid1";
        propertyGrid1.Size = new Size(324, 278);
        propertyGrid1.TabIndex = 0;
        propertyGrid1.Click += propertyGrid1_Click;
        // 
        // btnApply
        // 
        btnApply.Location = new Point(12, 296);
        btnApply.Name = "btnApply";
        btnApply.Size = new Size(75, 23);
        btnApply.TabIndex = 1;
        btnApply.Text = "Apply";
        btnApply.UseVisualStyleBackColor = true;
        btnApply.Click += btnApply_Click;
        // 
        // btnCancel
        // 
        btnCancel.Location = new Point(93, 296);
        btnCancel.Name = "btnCancel";
        btnCancel.Size = new Size(75, 23);
        btnCancel.TabIndex = 2;
        btnCancel.Text = "Cancel";
        btnCancel.UseVisualStyleBackColor = true;
        // 
        // EditShapeForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(348, 331);
        Controls.Add(btnCancel);
        Controls.Add(btnApply);
        Controls.Add(propertyGrid1);
        Name = "EditShapeForm";
        Text = "EditShapeForm";
        ResumeLayout(false);
    }

    #endregion

    private PropertyGrid propertyGrid1;
    private Button btnApply;
    private Button btnCancel;
}