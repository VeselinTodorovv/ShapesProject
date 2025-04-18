using System.Drawing;

namespace ShapesProject.Forms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            scenePanel = new Panel();
            menuStrip = new MenuStrip();
            file = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            loadToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            toolStrip = new ToolStrip();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            rectangleToolStripMenuItem = new ToolStripMenuItem();
            circleToolStripMenuItem = new ToolStripMenuItem();
            triangleToolStripMenuItem = new ToolStripMenuItem();
            rhombusToolStripMenuItem = new ToolStripMenuItem();
            parallelogramToolStripMenuItem = new ToolStripMenuItem();
            trapezoidToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            undoToolStripButton = new ToolStripButton();
            toolStripSeparator7 = new ToolStripSeparator();
            redoToolStripButton = new ToolStripButton();
            toolStripSeparator8 = new ToolStripSeparator();
            editToolStripButton = new ToolStripButton();
            toolStripSeparator6 = new ToolStripSeparator();
            deleteToolStripButton = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            fillColorToolStripButton = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            borderColorToolStripButton = new ToolStripButton();
            calcAreaToolStripButton = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            folderBrowserDialog1 = new FolderBrowserDialog();
            toolStripSeparator5 = new ToolStripSeparator();
            statstoolStripButton = new ToolStripButton();
            menuStrip.SuspendLayout();
            toolStrip.SuspendLayout();
            SuspendLayout();
            // 
            // scenePanel
            // 
            scenePanel.BackColor = Color.White;
            scenePanel.Location = new Point(12, 52);
            scenePanel.Name = "scenePanel";
            scenePanel.Size = new Size(875, 491);
            scenePanel.TabIndex = 0;
            scenePanel.Paint += panel1_Paint;
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { file });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.RenderMode = ToolStripRenderMode.Professional;
            menuStrip.Size = new Size(899, 24);
            menuStrip.TabIndex = 3;
            menuStrip.Text = "menuStrip1";
            // 
            // file
            // 
            file.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, saveToolStripMenuItem, loadToolStripMenuItem, exitToolStripMenuItem });
            file.Name = "file";
            file.Size = new Size(37, 20);
            file.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(100, 22);
            newToolStripMenuItem.Text = "New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(100, 22);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.Size = new Size(100, 22);
            loadToolStripMenuItem.Text = "Load";
            loadToolStripMenuItem.Click += loadToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(100, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // toolStrip
            // 
            toolStrip.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton1, toolStripSeparator3, undoToolStripButton, toolStripSeparator7, redoToolStripButton, toolStripSeparator8, editToolStripButton, toolStripSeparator6, deleteToolStripButton, toolStripSeparator1, fillColorToolStripButton, toolStripSeparator2, borderColorToolStripButton, toolStripSeparator4, calcAreaToolStripButton, toolStripSeparator5, statstoolStripButton });
            toolStrip.Location = new Point(0, 24);
            toolStrip.Name = "toolStrip";
            toolStrip.RenderMode = ToolStripRenderMode.Professional;
            toolStrip.Size = new Size(899, 25);
            toolStrip.TabIndex = 4;
            toolStrip.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { rectangleToolStripMenuItem, circleToolStripMenuItem, triangleToolStripMenuItem, rhombusToolStripMenuItem, parallelogramToolStripMenuItem, trapezoidToolStripMenuItem });
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(57, 22);
            toolStripDropDownButton1.Text = "Shapes";
            // 
            // rectangleToolStripMenuItem
            // 
            rectangleToolStripMenuItem.Name = "rectangleToolStripMenuItem";
            rectangleToolStripMenuItem.Size = new Size(147, 22);
            rectangleToolStripMenuItem.Text = "Rectangle";
            rectangleToolStripMenuItem.Click += rectangleToolStripMenuItem_Click;
            // 
            // circleToolStripMenuItem
            // 
            circleToolStripMenuItem.Name = "circleToolStripMenuItem";
            circleToolStripMenuItem.Size = new Size(147, 22);
            circleToolStripMenuItem.Text = "Circle";
            circleToolStripMenuItem.Click += circleToolStripMenuItem_Click;
            // 
            // triangleToolStripMenuItem
            // 
            triangleToolStripMenuItem.Name = "triangleToolStripMenuItem";
            triangleToolStripMenuItem.Size = new Size(147, 22);
            triangleToolStripMenuItem.Text = "Triangle";
            triangleToolStripMenuItem.Click += triangleToolStripMenuItem_Click;
            // 
            // rhombusToolStripMenuItem
            // 
            rhombusToolStripMenuItem.Name = "rhombusToolStripMenuItem";
            rhombusToolStripMenuItem.Size = new Size(147, 22);
            rhombusToolStripMenuItem.Text = "Rhombus";
            rhombusToolStripMenuItem.Click += rhombusToolStripMenuItem_Click;
            // 
            // parallelogramToolStripMenuItem
            // 
            parallelogramToolStripMenuItem.Name = "parallelogramToolStripMenuItem";
            parallelogramToolStripMenuItem.Size = new Size(147, 22);
            parallelogramToolStripMenuItem.Text = "Parallelogram";
            parallelogramToolStripMenuItem.Click += parallelogramToolStripMenuItem_Click;
            // 
            // trapezoidToolStripMenuItem
            // 
            trapezoidToolStripMenuItem.Name = "trapezoidToolStripMenuItem";
            trapezoidToolStripMenuItem.Size = new Size(147, 22);
            trapezoidToolStripMenuItem.Text = "Trapezoid";
            trapezoidToolStripMenuItem.Click += trapezoidToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 25);
            // 
            // undoToolStripButton
            // 
            undoToolStripButton.Image = (Image)resources.GetObject("undoToolStripButton.Image");
            undoToolStripButton.ImageTransparentColor = Color.Magenta;
            undoToolStripButton.Name = "undoToolStripButton";
            undoToolStripButton.Size = new Size(56, 22);
            undoToolStripButton.Text = "Undo";
            undoToolStripButton.Click += undoToolStripButton_Click;
            // 
            // toolStripSeparator7
            // 
            toolStripSeparator7.Name = "toolStripSeparator7";
            toolStripSeparator7.Size = new Size(6, 25);
            // 
            // redoToolStripButton
            // 
            redoToolStripButton.Image = (Image)resources.GetObject("redoToolStripButton.Image");
            redoToolStripButton.ImageTransparentColor = Color.Magenta;
            redoToolStripButton.Name = "redoToolStripButton";
            redoToolStripButton.Size = new Size(54, 22);
            redoToolStripButton.Text = "Redo";
            redoToolStripButton.Click += redoToolStripButton_Click;
            // 
            // toolStripSeparator8
            // 
            toolStripSeparator8.Name = "toolStripSeparator8";
            toolStripSeparator8.Size = new Size(6, 25);
            // 
            // editToolStripButton
            // 
            editToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            editToolStripButton.Image = (Image)resources.GetObject("editToolStripButton.Image");
            editToolStripButton.ImageTransparentColor = Color.Magenta;
            editToolStripButton.Name = "editToolStripButton";
            editToolStripButton.Size = new Size(31, 22);
            editToolStripButton.Text = "Edit";
            editToolStripButton.Click += editToolStripButton_Click;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(6, 25);
            // 
            // deleteToolStripButton
            // 
            deleteToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            deleteToolStripButton.Image = (Image)resources.GetObject("deleteToolStripButton.Image");
            deleteToolStripButton.ImageTransparentColor = Color.Magenta;
            deleteToolStripButton.Name = "deleteToolStripButton";
            deleteToolStripButton.Size = new Size(79, 22);
            deleteToolStripButton.Text = "Delete Shape";
            deleteToolStripButton.Click += deleteStripButton_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // fillColorToolStripButton
            // 
            fillColorToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            fillColorToolStripButton.Image = (Image)resources.GetObject("fillColorToolStripButton.Image");
            fillColorToolStripButton.ImageTransparentColor = Color.Magenta;
            fillColorToolStripButton.Name = "fillColorToolStripButton";
            fillColorToolStripButton.Size = new Size(58, 22);
            fillColorToolStripButton.Text = "Fill Color";
            fillColorToolStripButton.Click += fillColorButton_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // borderColorToolStripButton
            // 
            borderColorToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            borderColorToolStripButton.Image = (Image)resources.GetObject("borderColorToolStripButton.Image");
            borderColorToolStripButton.ImageTransparentColor = Color.Magenta;
            borderColorToolStripButton.Name = "borderColorToolStripButton";
            borderColorToolStripButton.Size = new Size(78, 22);
            borderColorToolStripButton.Text = "Border Color";
            borderColorToolStripButton.Click += borderColorToolStripComboBox_Click;
            // 
            // calcAreaToolStripButton
            // 
            calcAreaToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            calcAreaToolStripButton.Image = (Image)resources.GetObject("calcAreaToolStripButton.Image");
            calcAreaToolStripButton.ImageTransparentColor = Color.Magenta;
            calcAreaToolStripButton.Name = "calcAreaToolStripButton";
            calcAreaToolStripButton.Size = new Size(87, 22);
            calcAreaToolStripButton.Text = "Calculate Area";
            calcAreaToolStripButton.ToolTipText = "Calculate Area";
            calcAreaToolStripButton.Click += calcAreaToolStripButton_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 25);
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(6, 25);
            // 
            // statstoolStripButton
            // 
            statstoolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            statstoolStripButton.Image = (Image)resources.GetObject("statstoolStripButton.Image");
            statstoolStripButton.ImageTransparentColor = Color.Magenta;
            statstoolStripButton.Name = "statstoolStripButton";
            statstoolStripButton.Size = new Size(57, 22);
            statstoolStripButton.Text = "Statistics";
            statstoolStripButton.Click += statsToolStripButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 555);
            Controls.Add(toolStrip);
            Controls.Add(scenePanel);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "MainForm";
            Text = "Shapes Project";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel scenePanel;
        private MenuStrip menuStrip;
        private ToolStripMenuItem file;
        private ToolStrip toolStrip;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem rectangleToolStripMenuItem;
        private ToolStripMenuItem circleToolStripMenuItem;
        private ToolStripMenuItem triangleToolStripMenuItem;
        private ToolStripButton undoToolStripButton;
        private ToolStripButton redoToolStripButton;
        private ToolStripButton deleteToolStripButton;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem rhombusToolStripMenuItem;
        private ToolStripMenuItem parallelogramToolStripMenuItem;
        private ToolStripMenuItem trapezoidToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator8;
        private ToolStripButton editToolStripButton;
        private ToolStripButton fillColorToolStripButton;
        private ToolStripButton borderColorToolStripButton;
        private ToolStripButton calcAreaToolStripButton;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripButton statstoolStripButton;
        private FolderBrowserDialog folderBrowserDialog1;
    }
}
