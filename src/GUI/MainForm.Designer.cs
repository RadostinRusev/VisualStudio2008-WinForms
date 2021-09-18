namespace Draw
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.currentStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.speedMenu = new System.Windows.Forms.ToolStrip();
            this.drawRectangleSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.pickUpSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.drawcircle = new System.Windows.Forms.ToolStripButton();
            this.AddLine = new System.Windows.Forms.ToolStripButton();
            this.AddTriangle = new System.Windows.Forms.ToolStripButton();
            this.Addstring = new System.Windows.Forms.ToolStripButton();
            this.FillColorBox = new System.Windows.Forms.ToolStripButton();
            this.BorderColorBox = new System.Windows.Forms.ToolStripButton();
            this.MatrixRotationBeta = new System.Windows.Forms.ToolStripButton();
            this.MultipleSelectionPlaceholder = new System.Windows.Forms.ToolStripButton();
            this.SaveAsBitmap = new System.Windows.Forms.ToolStripButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.viewPort = new Draw.DoubleBufferedPanel();
            this.mainMenu.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.speedMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.imageToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(924, 30);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 26);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(123, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(123, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 26);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(65, 26);
            this.imageToolStripMenuItem.Text = "Image";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 26);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.aboutToolStripMenuItem.Text = "About...";
            // 
            // statusBar
            // 
            this.statusBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentStatusLabel});
            this.statusBar.Location = new System.Drawing.Point(0, 499);
            this.statusBar.Name = "statusBar";
            this.statusBar.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusBar.Size = new System.Drawing.Size(924, 22);
            this.statusBar.TabIndex = 2;
            this.statusBar.Text = "statusStrip1";
            // 
            // currentStatusLabel
            // 
            this.currentStatusLabel.Name = "currentStatusLabel";
            this.currentStatusLabel.Size = new System.Drawing.Size(0, 16);
            // 
            // speedMenu
            // 
            this.speedMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.speedMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drawRectangleSpeedButton,
            this.pickUpSpeedButton,
            this.drawcircle,
            this.AddLine,
            this.AddTriangle,
            this.Addstring,
            this.FillColorBox,
            this.BorderColorBox,
            this.MatrixRotationBeta,
            this.MultipleSelectionPlaceholder,
            this.SaveAsBitmap});
            this.speedMenu.Location = new System.Drawing.Point(0, 30);
            this.speedMenu.Name = "speedMenu";
            this.speedMenu.Size = new System.Drawing.Size(924, 31);
            this.speedMenu.TabIndex = 3;
            this.speedMenu.Text = "toolStrip1";
            // 
            // drawRectangleSpeedButton
            // 
            this.drawRectangleSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawRectangleSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("drawRectangleSpeedButton.Image")));
            this.drawRectangleSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawRectangleSpeedButton.Name = "drawRectangleSpeedButton";
            this.drawRectangleSpeedButton.Size = new System.Drawing.Size(29, 28);
            this.drawRectangleSpeedButton.Text = "DrawRectangleButton";
            this.drawRectangleSpeedButton.Click += new System.EventHandler(this.DrawRectangleSpeedButtonClick);
            // 
            // pickUpSpeedButton
            // 
            this.pickUpSpeedButton.CheckOnClick = true;
            this.pickUpSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pickUpSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("pickUpSpeedButton.Image")));
            this.pickUpSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pickUpSpeedButton.Name = "pickUpSpeedButton";
            this.pickUpSpeedButton.Size = new System.Drawing.Size(29, 28);
            this.pickUpSpeedButton.Text = "toolStripButton1";
            // 
            // drawcircle
            // 
            this.drawcircle.CheckOnClick = true;
            this.drawcircle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawcircle.Image = ((System.Drawing.Image)(resources.GetObject("drawcircle.Image")));
            this.drawcircle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawcircle.Name = "drawcircle";
            this.drawcircle.Size = new System.Drawing.Size(29, 28);
            this.drawcircle.Text = "drawcircle";
            this.drawcircle.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // AddLine
            // 
            this.AddLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddLine.Image = ((System.Drawing.Image)(resources.GetObject("AddLine.Image")));
            this.AddLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddLine.Name = "AddLine";
            this.AddLine.Size = new System.Drawing.Size(29, 28);
            this.AddLine.Text = "AddLine";
            this.AddLine.ToolTipText = "AddLine";
            this.AddLine.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // AddTriangle
            // 
            this.AddTriangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddTriangle.Image = ((System.Drawing.Image)(resources.GetObject("AddTriangle.Image")));
            this.AddTriangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddTriangle.Name = "AddTriangle";
            this.AddTriangle.Size = new System.Drawing.Size(29, 28);
            this.AddTriangle.Text = "AddTriangle";
            this.AddTriangle.ToolTipText = "AddTriangle";
            this.AddTriangle.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // Addstring
            // 
            this.Addstring.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Addstring.Image = ((System.Drawing.Image)(resources.GetObject("Addstring.Image")));
            this.Addstring.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Addstring.Name = "Addstring";
            this.Addstring.Size = new System.Drawing.Size(29, 28);
            this.Addstring.Text = "Addstring";
            this.Addstring.ToolTipText = "Addstring";
            this.Addstring.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // FillColorBox
            // 
            this.FillColorBox.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FillColorBox.Image = ((System.Drawing.Image)(resources.GetObject("FillColorBox.Image")));
            this.FillColorBox.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FillColorBox.Name = "FillColorBox";
            this.FillColorBox.Size = new System.Drawing.Size(29, 28);
            this.FillColorBox.Text = "FillColorBox";
            this.FillColorBox.ToolTipText = "FillColorBox";
            this.FillColorBox.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // BorderColorBox
            // 
            this.BorderColorBox.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BorderColorBox.Image = ((System.Drawing.Image)(resources.GetObject("BorderColorBox.Image")));
            this.BorderColorBox.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BorderColorBox.Name = "BorderColorBox";
            this.BorderColorBox.Size = new System.Drawing.Size(29, 28);
            this.BorderColorBox.Text = "BorderColorBox";
            this.BorderColorBox.ToolTipText = "BorderColorBox";
            this.BorderColorBox.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // MatrixRotationBeta
            // 
            this.MatrixRotationBeta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MatrixRotationBeta.Image = ((System.Drawing.Image)(resources.GetObject("MatrixRotationBeta.Image")));
            this.MatrixRotationBeta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MatrixRotationBeta.Name = "MatrixRotationBeta";
            this.MatrixRotationBeta.Size = new System.Drawing.Size(29, 28);
            this.MatrixRotationBeta.Text = "MatrixRotationBeta";
            this.MatrixRotationBeta.Click += new System.EventHandler(this.toolStripButton7_Click);
            // 
            // MultipleSelectionPlaceholder
            // 
            this.MultipleSelectionPlaceholder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MultipleSelectionPlaceholder.Image = ((System.Drawing.Image)(resources.GetObject("MultipleSelectionPlaceholder.Image")));
            this.MultipleSelectionPlaceholder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MultipleSelectionPlaceholder.Name = "MultipleSelectionPlaceholder";
            this.MultipleSelectionPlaceholder.Size = new System.Drawing.Size(29, 28);
            this.MultipleSelectionPlaceholder.Text = "MultipleSelectionPlaceholder";
            this.MultipleSelectionPlaceholder.ToolTipText = "MultipleSelectionPlaceholder";
            this.MultipleSelectionPlaceholder.Click += new System.EventHandler(this.toolStripButton8_Click);
            // 
            // SaveAsBitmap
            // 
            this.SaveAsBitmap.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveAsBitmap.Image = ((System.Drawing.Image)(resources.GetObject("SaveAsBitmap.Image")));
            this.SaveAsBitmap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveAsBitmap.Name = "SaveAsBitmap";
            this.SaveAsBitmap.Size = new System.Drawing.Size(29, 28);
            this.SaveAsBitmap.Text = "SaveAsValue";
            this.SaveAsBitmap.ToolTipText = "SaveAsBitMap";
            this.SaveAsBitmap.Click += new System.EventHandler(this.toolStripButton9_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(736, 246);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(736, 274);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 6;
            // 
            // viewPort
            // 
            this.viewPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewPort.Location = new System.Drawing.Point(0, 61);
            this.viewPort.Margin = new System.Windows.Forms.Padding(5);
            this.viewPort.Name = "viewPort";
            this.viewPort.Size = new System.Drawing.Size(924, 438);
            this.viewPort.TabIndex = 4;
            this.viewPort.Load += new System.EventHandler(this.viewPort_Load);
            this.viewPort.Paint += new System.Windows.Forms.PaintEventHandler(this.viewPort_Paint);
            this.viewPort.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseDown);
            this.viewPort.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseMove);
            this.viewPort.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseUp);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 521);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.viewPort);
            this.Controls.Add(this.speedMenu);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.mainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Draw";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.speedMenu.ResumeLayout(false);
            this.speedMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		
		private System.Windows.Forms.ToolStripStatusLabel currentStatusLabel;
		private Draw.DoubleBufferedPanel viewPort;
		private System.Windows.Forms.ToolStripButton pickUpSpeedButton;
		private System.Windows.Forms.ToolStripButton drawRectangleSpeedButton;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStrip speedMenu;
		private System.Windows.Forms.StatusStrip statusBar;
		private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripButton drawcircle;
        private System.Windows.Forms.ToolStripButton AddLine;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ToolStripButton AddTriangle;
        private System.Windows.Forms.ToolStripButton Addstring;
        private System.Windows.Forms.ToolStripButton FillColorBox;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripButton BorderColorBox;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.ToolStripButton MatrixRotationBeta;
        private System.Windows.Forms.ToolStripButton MultipleSelectionPlaceholder;
        private System.Windows.Forms.ToolStripButton SaveAsBitmap;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    }
}
