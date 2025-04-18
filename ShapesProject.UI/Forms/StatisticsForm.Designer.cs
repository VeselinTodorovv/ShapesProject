using System.ComponentModel;

namespace ShapesProject.Forms;

partial class StatisticsForm
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
        dataGridViewStatistics = new DataGridView();
        labelTotalCount = new Label();
        labelTotalArea = new Label();
        ((ISupportInitialize)dataGridViewStatistics).BeginInit();
        SuspendLayout();
        // 
        // dataGridViewStatistics
        // 
        dataGridViewStatistics.AllowUserToAddRows = false;
        dataGridViewStatistics.AllowUserToDeleteRows = false;
        dataGridViewStatistics.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewStatistics.Location = new Point(12, 12);
        dataGridViewStatistics.Name = "dataGridViewStatistics";
        dataGridViewStatistics.ReadOnly = true;
        dataGridViewStatistics.RowHeadersWidth = 51;
        dataGridViewStatistics.RowTemplate.Height = 29;
        dataGridViewStatistics.Size = new Size(460, 200);
        dataGridViewStatistics.TabIndex = 0;
        dataGridViewStatistics.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dataGridViewStatistics.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
        // 
        // labelTotalCount
        // 
        labelTotalCount.AutoSize = true;
        labelTotalCount.Location = new Point(12, 225);
        labelTotalCount.Name = "labelTotalCount";
        labelTotalCount.Size = new Size(71, 15);
        labelTotalCount.TabIndex = 1;
        labelTotalCount.Text = "Total Count:";
        // 
        // labelTotalArea
        // 
        this.labelTotalArea.AutoSize = true;
        this.labelTotalArea.Location = new System.Drawing.Point(12, 255);
        this.labelTotalArea.Name = "labelTotalArea";
        this.labelTotalArea.Size = new System.Drawing.Size(77, 20);
        this.labelTotalArea.TabIndex = 2;
        this.labelTotalArea.Text = "Total Area:";
        // 
        // StatisticsForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(484, 291);
        this.Controls.Add(this.labelTotalArea);
        this.Controls.Add(this.labelTotalCount);
        this.Controls.Add(this.dataGridViewStatistics);
        this.Name = "StatisticsForm";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        this.Text = "Shape Statistics";
        this.Load += new System.EventHandler(this.StatisticsForm_Load);
        ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStatistics)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private DataGridView dataGridViewStatistics;
    private Label labelTotalCount;
    private Label labelTotalArea;
}