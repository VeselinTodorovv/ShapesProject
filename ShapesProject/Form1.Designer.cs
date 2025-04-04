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
            editToolStripMenuItem = new ToolStripMenuItem();
            undoToolStripMenuItem = new ToolStripMenuItem();
            redoToolStripMenuItem = new ToolStripMenuItem();
            deleteShapeToolStripMenuItem = new ToolStripMenuItem();
            changeFillColorToolStripMenuItem = new ToolStripMenuItem();
            changeBorderColorToolStripMenuItem = new ToolStripMenuItem();
            shapesToolStripMenuItem = new ToolStripMenuItem();
            addRectangleToolStripMenuItem = new ToolStripMenuItem();
            addCircleToolStripMenuItem = new ToolStripMenuItem();
            addTriangleToolStripMenuItem = new ToolStripMenuItem();
            addRhombusToolStripMenuItem = new ToolStripMenuItem();
            addParallelogramToolStripMenuItem = new ToolStripMenuItem();
            addTrapezoidToolStripMenuItem = new ToolStripMenuItem();
            toolStrip = new ToolStrip();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            rectangleToolStripMenuItem = new ToolStripMenuItem();
            circleToolStripMenuItem = new ToolStripMenuItem();
            triangleToolStripMenuItem = new ToolStripMenuItem();
            rhombusToolStripMenuItem = new ToolStripMenuItem();
            parallelogramToolStripMenuItem = new ToolStripMenuItem();
            trapezoidToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            toolStripButton1 = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            toolStripButton2 = new ToolStripButton();
            toolStripSeparator5 = new ToolStripSeparator();
            toolStripButton3 = new ToolStripButton();
            toolStripSeparator7 = new ToolStripSeparator();
            toolStripButton4 = new ToolStripButton();
            toolStripSeparator8 = new ToolStripSeparator();
            editToolStripButton = new ToolStripButton();
            toolStripSeparator6 = new ToolStripSeparator();
            toolStripButton5 = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripComboBox1 = new ToolStripComboBox();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripComboBox2 = new ToolStripComboBox();
            menuStrip.SuspendLayout();
            toolStrip.SuspendLayout();
            SuspendLayout();
            // 
            // scenePanel
            // 
            scenePanel.Location = new Point(570, 52);
            scenePanel.Name = "scenePanel";
            scenePanel.Size = new Size(627, 491);
            scenePanel.TabIndex = 0;
            scenePanel.Paint += panel1_Paint;
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { file, editToolStripMenuItem, shapesToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
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
            file.Click += whatToolStripMenuItem_Click;
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(100, 22);
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(100, 22);
            saveToolStripMenuItem.Text = "Save";
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.Size = new Size(100, 22);
            loadToolStripMenuItem.Text = "Load";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(100, 22);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { undoToolStripMenuItem, redoToolStripMenuItem, deleteShapeToolStripMenuItem, changeFillColorToolStripMenuItem, changeBorderColorToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.Size = new Size(185, 22);
            undoToolStripMenuItem.Text = "Undo";
            // 
            // redoToolStripMenuItem
            // 
            redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            redoToolStripMenuItem.Size = new Size(185, 22);
            redoToolStripMenuItem.Text = "Redo";
            // 
            // deleteShapeToolStripMenuItem
            // 
            deleteShapeToolStripMenuItem.Name = "deleteShapeToolStripMenuItem";
            deleteShapeToolStripMenuItem.Size = new Size(185, 22);
            deleteShapeToolStripMenuItem.Text = "Delete Shape";
            // 
            // changeFillColorToolStripMenuItem
            // 
            changeFillColorToolStripMenuItem.Name = "changeFillColorToolStripMenuItem";
            changeFillColorToolStripMenuItem.Size = new Size(185, 22);
            changeFillColorToolStripMenuItem.Text = "Change Fill Color";
            // 
            // changeBorderColorToolStripMenuItem
            // 
            changeBorderColorToolStripMenuItem.Name = "changeBorderColorToolStripMenuItem";
            changeBorderColorToolStripMenuItem.Size = new Size(185, 22);
            changeBorderColorToolStripMenuItem.Text = "Change Border Color";
            // 
            // shapesToolStripMenuItem
            // 
            shapesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addRectangleToolStripMenuItem, addCircleToolStripMenuItem, addTriangleToolStripMenuItem, addRhombusToolStripMenuItem, addParallelogramToolStripMenuItem, addTrapezoidToolStripMenuItem });
            shapesToolStripMenuItem.Name = "shapesToolStripMenuItem";
            shapesToolStripMenuItem.Size = new Size(56, 20);
            shapesToolStripMenuItem.Text = "Shapes";
            // 
            // addRectangleToolStripMenuItem
            // 
            addRectangleToolStripMenuItem.Name = "addRectangleToolStripMenuItem";
            addRectangleToolStripMenuItem.Size = new Size(172, 22);
            addRectangleToolStripMenuItem.Text = "Add Rectangle";
            // 
            // addCircleToolStripMenuItem
            // 
            addCircleToolStripMenuItem.Name = "addCircleToolStripMenuItem";
            addCircleToolStripMenuItem.Size = new Size(172, 22);
            addCircleToolStripMenuItem.Text = "Add Circle";
            // 
            // addTriangleToolStripMenuItem
            // 
            addTriangleToolStripMenuItem.Name = "addTriangleToolStripMenuItem";
            addTriangleToolStripMenuItem.Size = new Size(172, 22);
            addTriangleToolStripMenuItem.Text = "Add Triangle";
            // 
            // addRhombusToolStripMenuItem
            // 
            addRhombusToolStripMenuItem.Name = "addRhombusToolStripMenuItem";
            addRhombusToolStripMenuItem.Size = new Size(172, 22);
            addRhombusToolStripMenuItem.Text = "Add Rhombus";
            // 
            // addParallelogramToolStripMenuItem
            // 
            addParallelogramToolStripMenuItem.Name = "addParallelogramToolStripMenuItem";
            addParallelogramToolStripMenuItem.Size = new Size(172, 22);
            addParallelogramToolStripMenuItem.Text = "Add Parallelogram";
            // 
            // addTrapezoidToolStripMenuItem
            // 
            addTrapezoidToolStripMenuItem.Name = "addTrapezoidToolStripMenuItem";
            addTrapezoidToolStripMenuItem.Size = new Size(172, 22);
            addTrapezoidToolStripMenuItem.Text = "Add Trapezoid";
            // 
            // toolStrip
            // 
            toolStrip.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton1, toolStripSeparator3, toolStripButton1, toolStripSeparator4, toolStripButton2, toolStripSeparator5, toolStripButton3, toolStripSeparator7, toolStripButton4, toolStripSeparator8, editToolStripButton, toolStripSeparator6, toolStripButton5, toolStripSeparator1, toolStripComboBox1, toolStripSeparator2, toolStripComboBox2 });
            toolStrip.Location = new Point(0, 24);
            toolStrip.Name = "toolStrip";
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
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(41, 22);
            toolStripButton1.Text = "Move";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 25);
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(43, 22);
            toolStripButton2.Text = "Resize";
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(6, 25);
            // 
            // toolStripButton3
            // 
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(56, 22);
            toolStripButton3.Text = "Undo";
            toolStripButton3.Click += toolStripButton3_Click;
            // 
            // toolStripSeparator7
            // 
            toolStripSeparator7.Name = "toolStripSeparator7";
            toolStripSeparator7.Size = new Size(6, 25);
            // 
            // toolStripButton4
            // 
            toolStripButton4.Image = (Image)resources.GetObject("toolStripButton4.Image");
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(54, 22);
            toolStripButton4.Text = "Redo";
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
            // toolStripButton5
            // 
            toolStripButton5.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton5.Image = (Image)resources.GetObject("toolStripButton5.Image");
            toolStripButton5.ImageTransparentColor = Color.Magenta;
            toolStripButton5.Name = "toolStripButton5";
            toolStripButton5.Size = new Size(79, 22);
            toolStripButton5.Text = "Delete Shape";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // toolStripComboBox1
            // 
            toolStripComboBox1.Items.AddRange(new object[] { "White", "Red", "Green", "Blue", "Yellow", "Black" });
            toolStripComboBox1.Name = "toolStripComboBox1";
            toolStripComboBox1.Size = new Size(121, 25);
            toolStripComboBox1.Text = "Fill Color";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // toolStripComboBox2
            // 
            toolStripComboBox2.Items.AddRange(new object[] { "White", "Red", "Green", "Blue", "Yellow", "Black" });
            toolStripComboBox2.Name = "toolStripComboBox2";
            toolStripComboBox2.Size = new Size(121, 25);
            toolStripComboBox2.Text = "Border Color";
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
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem redoToolStripMenuItem;
        private ToolStripMenuItem deleteShapeToolStripMenuItem;
        private ToolStripMenuItem changeFillColorToolStripMenuItem;
        private ToolStripMenuItem changeBorderColorToolStripMenuItem;
        private ToolStripMenuItem shapesToolStripMenuItem;
        private ToolStripMenuItem addRectangleToolStripMenuItem;
        private ToolStripMenuItem addCircleToolStripMenuItem;
        private ToolStripMenuItem addTriangleToolStripMenuItem;
        private ToolStripMenuItem addRhombusToolStripMenuItem;
        private ToolStripMenuItem addParallelogramToolStripMenuItem;
        private ToolStripMenuItem addTrapezoidToolStripMenuItem;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem rectangleToolStripMenuItem;
        private ToolStripMenuItem circleToolStripMenuItem;
        private ToolStripMenuItem triangleToolStripMenuItem;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton4;
        private ToolStripButton toolStripButton5;
        private ToolStripComboBox toolStripComboBox1;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripComboBox toolStripComboBox2;
        private ToolStripMenuItem rhombusToolStripMenuItem;
        private ToolStripMenuItem parallelogramToolStripMenuItem;
        private ToolStripMenuItem trapezoidToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator8;
        private ToolStripButton editToolStripButton;
    }
}
