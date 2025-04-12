using System.ComponentModel;
using System.Drawing;

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
        propertyGrid = new PropertyGrid();
        btnApply = new Button();
        btnCancel = new Button();
        SuspendLayout();
        // 
        // propertyGrid1
        // 
        propertyGrid.HelpVisible = false;
        propertyGrid.Location = new Point(12, 12);
        propertyGrid.Name = "propertyGrid";
        propertyGrid.PropertySort = PropertySort.Categorized;
        propertyGrid.Size = new Size(324, 278);
        propertyGrid.TabIndex = 0;
        propertyGrid.ToolbarVisible = false;
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
        btnCancel.Click += btnCancel_Click;
        // 
        // EditShapeForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        AutoSize = true;
        AutoSizeMode = AutoSizeMode.GrowAndShrink;
        ClientSize = new Size(348, 331);
        Controls.Add(btnCancel);
        Controls.Add(btnApply);
        Controls.Add(propertyGrid);
        Name = "EditShapeForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "EditShapeForm";
        ResumeLayout(false);
    }

    #endregion

    private PropertyGrid propertyGrid;
    private Button btnApply;
    private Button btnCancel;
}