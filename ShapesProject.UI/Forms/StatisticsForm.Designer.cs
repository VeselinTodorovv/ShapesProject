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
        tabControlStats = new TabControl();
        tabPageOverview = new TabPage();
        dataGridViewStatistics = new DataGridView();
        labelTotalCount = new Label();
        labelTotalArea = new Label();
        tabPageAdvanced = new TabPage();
        labelTopThreeLargest = new Label();
        listBoxTopThreeLargest = new ListBox();
        labelAvgByType = new Label();
        listBoxAvgByType = new ListBox();
        labelAllAboveMin = new Label();
        listBoxAllAboveMin = new ListBox();
        labelMostCommonTypeTitle = new Label();
        labelMostCommonType = new Label();
        tabControlStats.SuspendLayout();
        tabPageOverview.SuspendLayout();
        ((ISupportInitialize)dataGridViewStatistics).BeginInit();
        tabPageAdvanced.SuspendLayout();
        SuspendLayout();
        // 
        // tabControlStats
        // 
        tabControlStats.Controls.Add(tabPageOverview);
        tabControlStats.Controls.Add(tabPageAdvanced);
        tabControlStats.Dock = DockStyle.Fill;
        tabControlStats.Location = new Point(0, 0);
        tabControlStats.Margin = new Padding(3, 2, 3, 2);
        tabControlStats.Name = "tabControlStats";
        tabControlStats.SelectedIndex = 0;
        tabControlStats.Size = new Size(612, 262);
        tabControlStats.TabIndex = 0;
        // 
        // tabPageOverview
        // 
        tabPageOverview.Controls.Add(dataGridViewStatistics);
        tabPageOverview.Controls.Add(labelTotalCount);
        tabPageOverview.Controls.Add(labelTotalArea);
        tabPageOverview.Location = new Point(4, 24);
        tabPageOverview.Margin = new Padding(3, 2, 3, 2);
        tabPageOverview.Name = "tabPageOverview";
        tabPageOverview.Padding = new Padding(3, 2, 3, 2);
        tabPageOverview.Size = new Size(604, 234);
        tabPageOverview.TabIndex = 0;
        tabPageOverview.Text = "Overview";
        tabPageOverview.UseVisualStyleBackColor = true;
        // 
        // dataGridViewStatistics
        // 
        dataGridViewStatistics.AllowUserToAddRows = false;
        dataGridViewStatistics.AllowUserToDeleteRows = false;
        dataGridViewStatistics.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dataGridViewStatistics.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewStatistics.Location = new Point(10, 9);
        dataGridViewStatistics.Margin = new Padding(3, 2, 3, 2);
        dataGridViewStatistics.Name = "dataGridViewStatistics";
        dataGridViewStatistics.ReadOnly = true;
        dataGridViewStatistics.Size = new Size(402, 150);
        dataGridViewStatistics.TabIndex = 0;
        // 
        // labelTotalCount
        // 
        labelTotalCount.AutoSize = true;
        labelTotalCount.Location = new Point(10, 169);
        labelTotalCount.Name = "labelTotalCount";
        labelTotalCount.Size = new Size(71, 15);
        labelTotalCount.TabIndex = 1;
        labelTotalCount.Text = "Total Count:";
        // 
        // labelTotalArea
        // 
        labelTotalArea.AutoSize = true;
        labelTotalArea.Location = new Point(10, 191);
        labelTotalArea.Name = "labelTotalArea";
        labelTotalArea.Size = new Size(62, 15);
        labelTotalArea.TabIndex = 2;
        labelTotalArea.Text = "Total Area:";
        // 
        // tabPageAdvanced
        // 
        tabPageAdvanced.Controls.Add(labelTopThreeLargest);
        tabPageAdvanced.Controls.Add(listBoxTopThreeLargest);
        tabPageAdvanced.Controls.Add(labelAvgByType);
        tabPageAdvanced.Controls.Add(listBoxAvgByType);
        tabPageAdvanced.Controls.Add(labelAllAboveMin);
        tabPageAdvanced.Controls.Add(listBoxAllAboveMin);
        tabPageAdvanced.Controls.Add(labelMostCommonTypeTitle);
        tabPageAdvanced.Controls.Add(labelMostCommonType);
        tabPageAdvanced.Location = new Point(4, 24);
        tabPageAdvanced.Margin = new Padding(3, 2, 3, 2);
        tabPageAdvanced.Name = "tabPageAdvanced";
        tabPageAdvanced.Padding = new Padding(3, 2, 3, 2);
        tabPageAdvanced.Size = new Size(604, 234);
        tabPageAdvanced.TabIndex = 1;
        tabPageAdvanced.Text = "Advanced";
        tabPageAdvanced.UseVisualStyleBackColor = true;
        // 
        // labelTopThreeLargest
        // 
        labelTopThreeLargest.AutoSize = true;
        labelTopThreeLargest.Location = new Point(13, 11);
        labelTopThreeLargest.Name = "labelTopThreeLargest";
        labelTopThreeLargest.Size = new Size(119, 15);
        labelTopThreeLargest.TabIndex = 0;
        labelTopThreeLargest.Text = "Top 3 Largest Shapes:";
        // 
        // listBoxTopThreeLargest
        // 
        listBoxTopThreeLargest.FormattingEnabled = true;
        listBoxTopThreeLargest.ItemHeight = 15;
        listBoxTopThreeLargest.Location = new Point(13, 28);
        listBoxTopThreeLargest.Margin = new Padding(3, 2, 3, 2);
        listBoxTopThreeLargest.Name = "listBoxTopThreeLargest";
        listBoxTopThreeLargest.Size = new Size(263, 49);
        listBoxTopThreeLargest.TabIndex = 1;
        // 
        // labelAvgByType
        // 
        labelAvgByType.AutoSize = true;
        labelAvgByType.Location = new Point(306, 11);
        labelAvgByType.Name = "labelAvgByType";
        labelAvgByType.Size = new Size(104, 15);
        labelAvgByType.TabIndex = 2;
        labelAvgByType.Text = "Avg. Area by Type:";
        // 
        // listBoxAvgByType
        // 
        listBoxAvgByType.FormattingEnabled = true;
        listBoxAvgByType.ItemHeight = 15;
        listBoxAvgByType.Location = new Point(306, 28);
        listBoxAvgByType.Margin = new Padding(3, 2, 3, 2);
        listBoxAvgByType.Name = "listBoxAvgByType";
        listBoxAvgByType.Size = new Size(263, 49);
        listBoxAvgByType.TabIndex = 3;
        // 
        // labelAllAboveMin
        // 
        labelAllAboveMin.AutoSize = true;
        labelAllAboveMin.Location = new Point(13, 90);
        labelAllAboveMin.Name = "labelAllAboveMin";
        labelAllAboveMin.Size = new Size(134, 15);
        labelAllAboveMin.TabIndex = 4;
        labelAllAboveMin.Text = "Types where all area > 100:";
        // 
        // listBoxAllAboveMin
        // 
        listBoxAllAboveMin.FormattingEnabled = true;
        listBoxAllAboveMin.ItemHeight = 15;
        listBoxAllAboveMin.Location = new Point(13, 107);
        listBoxAllAboveMin.Margin = new Padding(3, 2, 3, 2);
        listBoxAllAboveMin.Name = "listBoxAllAboveMin";
        listBoxAllAboveMin.Size = new Size(263, 49);
        listBoxAllAboveMin.TabIndex = 5;
        // 
        // labelMostCommonTypeTitle
        // 
        labelMostCommonTypeTitle.AutoSize = true;
        labelMostCommonTypeTitle.Location = new Point(13, 167);
        labelMostCommonTypeTitle.Name = "labelMostCommonTypeTitle";
        labelMostCommonTypeTitle.Size = new Size(126, 15);
        labelMostCommonTypeTitle.TabIndex = 6;
        labelMostCommonTypeTitle.Text = "Most Common Shape:";
        // 
        // labelMostCommonType
        // 
        labelMostCommonType.AutoSize = true;
        labelMostCommonType.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        labelMostCommonType.Location = new Point(145, 167);
        labelMostCommonType.Name = "labelMostCommonType";
        labelMostCommonType.Size = new Size(12, 15);
        labelMostCommonType.TabIndex = 7;
        labelMostCommonType.Text = "-";
        // 
        // StatisticsForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(612, 262);
        Controls.Add(tabControlStats);
        Margin = new Padding(3, 2, 3, 2);
        Name = "StatisticsForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Shape Statistics";
        Load += StatisticsForm_Load;
        tabControlStats.ResumeLayout(false);
        tabPageOverview.ResumeLayout(false);
        tabPageOverview.PerformLayout();
        ((ISupportInitialize)dataGridViewStatistics).EndInit();
        tabPageAdvanced.ResumeLayout(false);
        tabPageAdvanced.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private TabControl tabControlStats;
    private TabPage tabPageOverview;
    private TabPage tabPageAdvanced;
    private DataGridView dataGridViewStatistics;
    private Label labelTotalCount;
    private Label labelTotalArea;
    private ListBox listBoxTopThreeLargest;
    private ListBox listBoxAvgByType;
    private ListBox listBoxAllAboveMin;
    private Label labelMostCommonType;
    private Label labelTopThreeLargest;
    private Label labelAvgByType;
    private Label labelAllAboveMin;
    private Label labelMostCommonTypeTitle;
}