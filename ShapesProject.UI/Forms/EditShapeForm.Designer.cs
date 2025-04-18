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
        previewPanel = new Panel();
        SuspendLayout();
        // 
        // propertyGrid
        // 
        propertyGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        propertyGrid.BackColor = SystemColors.Window;
        propertyGrid.CategoryForeColor = Color.FromArgb(0, 51, 102);
        propertyGrid.CategorySplitterColor = Color.FromArgb(200, 200, 200);
        propertyGrid.CommandsActiveLinkColor = Color.FromArgb(0, 102, 204);
        propertyGrid.CommandsBackColor = Color.FromArgb(238, 238, 238);
        propertyGrid.CommandsBorderColor = SystemColors.Control;
        propertyGrid.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
        propertyGrid.HelpVisible = false;
        propertyGrid.LineColor = Color.FromArgb(230, 230, 230);
        propertyGrid.Location = new Point(24, 15);
        propertyGrid.Margin = new Padding(12);
        propertyGrid.Name = "propertyGrid";
        propertyGrid.PropertySort = PropertySort.Categorized;
        propertyGrid.SelectedItemWithFocusBackColor = Color.FromArgb(0, 102, 204);
        propertyGrid.SelectedItemWithFocusForeColor = Color.White;
        propertyGrid.Size = new Size(250, 300);
        propertyGrid.TabIndex = 0;
        propertyGrid.ToolbarVisible = false;
        propertyGrid.ViewBackColor = Color.FromArgb(248, 248, 248);
        propertyGrid.ViewForeColor = SystemColors.ControlText;
        // 
        // btnApply
        // 
        btnApply.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btnApply.BackColor = Color.FromArgb(0, 102, 204);
        btnApply.FlatAppearance.BorderColor = Color.FromArgb(0, 51, 102);
        btnApply.FlatStyle = FlatStyle.Flat;
        btnApply.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
        btnApply.ForeColor = Color.White;
        btnApply.Location = new Point(403, 324);
        btnApply.Margin = new Padding(3, 3, 12, 12);
        btnApply.Name = "btnApply";
        btnApply.Size = new Size(75, 30);
        btnApply.TabIndex = 1;
        btnApply.Text = "Apply";
        btnApply.UseVisualStyleBackColor = false;
        // 
        // btnCancel
        // 
        btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btnCancel.BackColor = Color.FromArgb(200, 200, 200);
        btnCancel.DialogResult = DialogResult.Cancel;
        btnCancel.FlatAppearance.BorderColor = Color.FromArgb(150, 150, 150);
        btnCancel.FlatStyle = FlatStyle.Flat;
        btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
        btnCancel.ForeColor = Color.Black;
        btnCancel.Location = new Point(484, 324);
        btnCancel.Margin = new Padding(3, 3, 12, 12);
        btnCancel.Name = "btnCancel";
        btnCancel.Size = new Size(75, 30);
        btnCancel.TabIndex = 2;
        btnCancel.Text = "Cancel";
        btnCancel.UseVisualStyleBackColor = false;
        // 
        // previewPanel
        // 
        previewPanel.Location = new Point(306, 15);
        previewPanel.Name = "previewPanel";
        previewPanel.Size = new Size(250, 300);
        previewPanel.TabIndex = 3;
        previewPanel.Paint += previewPanel_Paint;
        // 
        // EditShapeForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.Control;
        ClientSize = new Size(571, 366);
        Controls.Add(previewPanel);
        Controls.Add(btnCancel);
        Controls.Add(btnApply);
        Controls.Add(propertyGrid);
        Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "EditShapeForm";
        Padding = new Padding(12);
        ShowIcon = false;
        StartPosition = FormStartPosition.CenterParent;
        Text = "Edit Shape Properties";
        ResumeLayout(false);
    }

    #endregion

    private PropertyGrid propertyGrid;
    private Button btnApply;
    private Button btnCancel;
    private Panel previewPanel;
}