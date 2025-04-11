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
            scenePanel = new System.Windows.Forms.Panel();
            menuStrip = new System.Windows.Forms.MenuStrip();
            file = new System.Windows.Forms.ToolStripMenuItem();
            newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStrip = new System.Windows.Forms.ToolStrip();
            toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            rectangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            circleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            triangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            rhombusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            parallelogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            trapezoidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            undoToolStripButton = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            redoToolStripButton = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            editToolStripButton = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            deleteStripButton = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            fillColorButton = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            borderColorToolStripComboBox = new System.Windows.Forms.ToolStripButton();
            menuStrip.SuspendLayout();
            toolStrip.SuspendLayout();
            SuspendLayout();
            // 
            // scenePanel
            // 
            scenePanel.Location = new System.Drawing.Point(12, 52);
            scenePanel.Name = "scenePanel";
            scenePanel.Size = new System.Drawing.Size(1185, 491);
            scenePanel.TabIndex = 0;
            scenePanel.Paint += panel1_Paint;
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { file });
            menuStrip.Location = new System.Drawing.Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            menuStrip.Size = new System.Drawing.Size(1209, 24);
            menuStrip.TabIndex = 3;
            menuStrip.Text = "menuStrip1";
            menuStrip.ItemClicked += menuStrip1_ItemClicked;
            // 
            // file
            // 
            file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { newToolStripMenuItem, saveToolStripMenuItem, loadToolStripMenuItem, exitToolStripMenuItem });
            file.Name = "file";
            file.Size = new System.Drawing.Size(37, 20);
            file.Text = "File";
            file.Click += fileToolStripMenuItem_Click;
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            newToolStripMenuItem.Text = "New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            loadToolStripMenuItem.Text = "Load";
            loadToolStripMenuItem.Click += loadToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // toolStrip
            // 
            toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripDropDownButton1, toolStripSeparator3, undoToolStripButton, toolStripSeparator7, redoToolStripButton, toolStripSeparator8, editToolStripButton, toolStripSeparator6, deleteStripButton, toolStripSeparator1, fillColorButton, toolStripSeparator2, borderColorToolStripComboBox });
            toolStrip.Location = new System.Drawing.Point(0, 24);
            toolStrip.Name = "toolStrip";
            toolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            toolStrip.Size = new System.Drawing.Size(1209, 25);
            toolStrip.TabIndex = 4;
            toolStrip.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { rectangleToolStripMenuItem, circleToolStripMenuItem, triangleToolStripMenuItem, rhombusToolStripMenuItem, parallelogramToolStripMenuItem, trapezoidToolStripMenuItem });
            toolStripDropDownButton1.Image = ((System.Drawing.Image)resources.GetObject("toolStripDropDownButton1.Image"));
            toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new System.Drawing.Size(57, 22);
            toolStripDropDownButton1.Text = "Shapes";
            toolStripDropDownButton1.Click += toolStripDropDownButton1_Click;
            // 
            // rectangleToolStripMenuItem
            // 
            rectangleToolStripMenuItem.Name = "rectangleToolStripMenuItem";
            rectangleToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            rectangleToolStripMenuItem.Text = "Rectangle";
            rectangleToolStripMenuItem.Click += rectangleToolStripMenuItem_Click;
            // 
            // circleToolStripMenuItem
            // 
            circleToolStripMenuItem.Name = "circleToolStripMenuItem";
            circleToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            circleToolStripMenuItem.Text = "Circle";
            circleToolStripMenuItem.Click += circleToolStripMenuItem_Click;
            // 
            // triangleToolStripMenuItem
            // 
            triangleToolStripMenuItem.Name = "triangleToolStripMenuItem";
            triangleToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            triangleToolStripMenuItem.Text = "Triangle";
            triangleToolStripMenuItem.Click += triangleToolStripMenuItem_Click;
            // 
            // rhombusToolStripMenuItem
            // 
            rhombusToolStripMenuItem.Name = "rhombusToolStripMenuItem";
            rhombusToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            rhombusToolStripMenuItem.Text = "Rhombus";
            rhombusToolStripMenuItem.Click += rhombusToolStripMenuItem_Click;
            // 
            // parallelogramToolStripMenuItem
            // 
            parallelogramToolStripMenuItem.Name = "parallelogramToolStripMenuItem";
            parallelogramToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            parallelogramToolStripMenuItem.Text = "Parallelogram";
            parallelogramToolStripMenuItem.Click += parallelogramToolStripMenuItem_Click;
            // 
            // trapezoidToolStripMenuItem
            // 
            trapezoidToolStripMenuItem.Name = "trapezoidToolStripMenuItem";
            trapezoidToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            trapezoidToolStripMenuItem.Text = "Trapezoid";
            trapezoidToolStripMenuItem.Click += trapezoidToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // undoToolStripButton
            // 
            undoToolStripButton.Image = ((System.Drawing.Image)resources.GetObject("undoToolStripButton.Image"));
            undoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            undoToolStripButton.Name = "undoToolStripButton";
            undoToolStripButton.Size = new System.Drawing.Size(56, 22);
            undoToolStripButton.Text = "Undo";
            undoToolStripButton.Click += undoToolStripButton_Click;
            // 
            // toolStripSeparator7
            // 
            toolStripSeparator7.Name = "toolStripSeparator7";
            toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // redoToolStripButton
            // 
            redoToolStripButton.Image = ((System.Drawing.Image)resources.GetObject("redoToolStripButton.Image"));
            redoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            redoToolStripButton.Name = "redoToolStripButton";
            redoToolStripButton.Size = new System.Drawing.Size(54, 22);
            redoToolStripButton.Text = "Redo";
            redoToolStripButton.Click += redoToolStripButton_Click;
            // 
            // toolStripSeparator8
            // 
            toolStripSeparator8.Name = "toolStripSeparator8";
            toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // editToolStripButton
            // 
            editToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            editToolStripButton.Image = ((System.Drawing.Image)resources.GetObject("editToolStripButton.Image"));
            editToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            editToolStripButton.Name = "editToolStripButton";
            editToolStripButton.Size = new System.Drawing.Size(31, 22);
            editToolStripButton.Text = "Edit";
            editToolStripButton.Click += editToolStripButton_Click;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // deleteStripButton
            // 
            deleteStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            deleteStripButton.Image = ((System.Drawing.Image)resources.GetObject("deleteStripButton.Image"));
            deleteStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            deleteStripButton.Name = "deleteStripButton";
            deleteStripButton.Size = new System.Drawing.Size(79, 22);
            deleteStripButton.Text = "Delete Shape";
            deleteStripButton.Click += deleteStripButton_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // fillColorButton
            // 
            fillColorButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            fillColorButton.Image = ((System.Drawing.Image)resources.GetObject("fillColorButton.Image"));
            fillColorButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            fillColorButton.Name = "fillColorButton";
            fillColorButton.Size = new System.Drawing.Size(58, 22);
            fillColorButton.Text = "Fill Color";
            fillColorButton.Click += fillColorButton_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // borderColorToolStripComboBox
            // 
            borderColorToolStripComboBox.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            borderColorToolStripComboBox.Image = ((System.Drawing.Image)resources.GetObject("borderColorToolStripComboBox.Image"));
            borderColorToolStripComboBox.ImageTransparentColor = System.Drawing.Color.Magenta;
            borderColorToolStripComboBox.Name = "borderColorToolStripComboBox";
            borderColorToolStripComboBox.Size = new System.Drawing.Size(78, 22);
            borderColorToolStripComboBox.Text = "Border Color";
            borderColorToolStripComboBox.Click += borderColorToolStripComboBox_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1209, 555);
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
