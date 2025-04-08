namespace ShapesProject
{
    partial class Form1
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            deleteStripButton = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            fillColorButton = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            borderColorToolStripComboBox = new ToolStripButton();
            menuStrip.SuspendLayout();
            toolStrip.SuspendLayout();
            SuspendLayout();
            // 
            // scenePanel
            // 
            scenePanel.Location = new Point(12, 52);
            scenePanel.Name = "scenePanel";
            scenePanel.Size = new Size(1185, 491);
            scenePanel.TabIndex = 0;
            scenePanel.Paint += panel1_Paint;
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { file });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.RenderMode = ToolStripRenderMode.Professional;
            menuStrip.Size = new Size(1209, 24);
            menuStrip.TabIndex = 3;
            menuStrip.Text = "menuStrip1";
            menuStrip.ItemClicked += menuStrip1_ItemClicked;
            // 
            // file
            // 
            file.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, saveToolStripMenuItem, loadToolStripMenuItem, exitToolStripMenuItem });
            file.Name = "file";
            file.Size = new Size(37, 20);
            file.Text = "File";
            file.Click += fileToolStripMenuItem_Click;
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
            toolStrip.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton1, toolStripSeparator3, undoToolStripButton, toolStripSeparator7, redoToolStripButton, toolStripSeparator8, editToolStripButton, toolStripSeparator6, deleteStripButton, toolStripSeparator1, fillColorButton, toolStripSeparator2, borderColorToolStripComboBox });
            toolStrip.Location = new Point(0, 24);
            toolStrip.Name = "toolStrip";
            toolStrip.RenderMode = ToolStripRenderMode.Professional;
            toolStrip.Size = new Size(1209, 25);
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
            toolStripDropDownButton1.Click += toolStripDropDownButton1_Click;
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
            // deleteStripButton
            // 
            deleteStripButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            deleteStripButton.Image = (Image)resources.GetObject("deleteStripButton.Image");
            deleteStripButton.ImageTransparentColor = Color.Magenta;
            deleteStripButton.Name = "deleteStripButton";
            deleteStripButton.Size = new Size(79, 22);
            deleteStripButton.Text = "Delete Shape";
            deleteStripButton.Click += deleteStripButton_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // fillColorButton
            // 
            fillColorButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            fillColorButton.Image = (Image)resources.GetObject("fillColorButton.Image");
            fillColorButton.ImageTransparentColor = Color.Magenta;
            fillColorButton.Name = "fillColorButton";
            fillColorButton.Size = new Size(58, 22);
            fillColorButton.Text = "Fill Color";
            fillColorButton.Click += fillColorButton_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // borderColorToolStripComboBox
            // 
            borderColorToolStripComboBox.DisplayStyle = ToolStripItemDisplayStyle.Text;
            borderColorToolStripComboBox.Image = (Image)resources.GetObject("borderColorToolStripComboBox.Image");
            borderColorToolStripComboBox.ImageTransparentColor = Color.Magenta;
            borderColorToolStripComboBox.Name = "borderColorToolStripComboBox";
            borderColorToolStripComboBox.Size = new Size(78, 22);
            borderColorToolStripComboBox.Text = "Border Color";
            borderColorToolStripComboBox.Click += borderColorToolStripComboBox_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1209, 555);
            Controls.Add(toolStrip);
            Controls.Add(scenePanel);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "Form1";
            Text = "Form1";
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
        private ToolStripButton deleteStripButton;
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
        private ToolStripButton fillColorButton;
        private ToolStripButton borderColorToolStripComboBox;
    }
}
