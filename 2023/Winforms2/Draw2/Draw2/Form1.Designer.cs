namespace Draw2 {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            souborToolStripMenuItem = new ToolStripMenuItem();
            novyToolStripMenuItem = new ToolStripMenuItem();
            nacistToolStripMenuItem = new ToolStripMenuItem();
            ulozitToolStripMenuItem = new ToolStripMenuItem();
            konecToolStripMenuItem = new ToolStripMenuItem();
            tvarToolStripMenuItem = new ToolStripMenuItem();
            caraToolStripMenuItem = new ToolStripMenuItem();
            obdelnikToolStripMenuItem = new ToolStripMenuItem();
            elipsaToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            NewButton = new ToolStripButton();
            OpenButton = new ToolStripButton();
            SaveButton = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            LineButton = new ToolStripButton();
            RectangleButton = new ToolStripButton();
            CircleButton = new ToolStripButton();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { souborToolStripMenuItem, tvarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // souborToolStripMenuItem
            // 
            souborToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novyToolStripMenuItem, nacistToolStripMenuItem, ulozitToolStripMenuItem, konecToolStripMenuItem });
            souborToolStripMenuItem.Name = "souborToolStripMenuItem";
            souborToolStripMenuItem.Size = new Size(57, 20);
            souborToolStripMenuItem.Text = "Soubor";
            // 
            // novyToolStripMenuItem
            // 
            novyToolStripMenuItem.Name = "novyToolStripMenuItem";
            novyToolStripMenuItem.Size = new Size(180, 22);
            novyToolStripMenuItem.Text = "Novy";
            novyToolStripMenuItem.Click += novyToolStripMenuItem_Click;
            // 
            // nacistToolStripMenuItem
            // 
            nacistToolStripMenuItem.Name = "nacistToolStripMenuItem";
            nacistToolStripMenuItem.Size = new Size(180, 22);
            nacistToolStripMenuItem.Text = "Nacist";
            // 
            // ulozitToolStripMenuItem
            // 
            ulozitToolStripMenuItem.Name = "ulozitToolStripMenuItem";
            ulozitToolStripMenuItem.Size = new Size(180, 22);
            ulozitToolStripMenuItem.Text = "Ulozit";
            // 
            // konecToolStripMenuItem
            // 
            konecToolStripMenuItem.Name = "konecToolStripMenuItem";
            konecToolStripMenuItem.Size = new Size(180, 22);
            konecToolStripMenuItem.Text = "Konec";
            konecToolStripMenuItem.Click += konecToolStripMenuItem_Click;
            // 
            // tvarToolStripMenuItem
            // 
            tvarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { caraToolStripMenuItem, obdelnikToolStripMenuItem, elipsaToolStripMenuItem });
            tvarToolStripMenuItem.Name = "tvarToolStripMenuItem";
            tvarToolStripMenuItem.Size = new Size(40, 20);
            tvarToolStripMenuItem.Text = "Tvar";
            // 
            // caraToolStripMenuItem
            // 
            caraToolStripMenuItem.Name = "caraToolStripMenuItem";
            caraToolStripMenuItem.Size = new Size(122, 22);
            caraToolStripMenuItem.Text = "Cara";
            // 
            // obdelnikToolStripMenuItem
            // 
            obdelnikToolStripMenuItem.Name = "obdelnikToolStripMenuItem";
            obdelnikToolStripMenuItem.Size = new Size(122, 22);
            obdelnikToolStripMenuItem.Text = "Obdelnik";
            // 
            // elipsaToolStripMenuItem
            // 
            elipsaToolStripMenuItem.Name = "elipsaToolStripMenuItem";
            elipsaToolStripMenuItem.Size = new Size(122, 22);
            elipsaToolStripMenuItem.Text = "Elipsa";
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { NewButton, OpenButton, SaveButton, toolStripSeparator1, LineButton, RectangleButton, CircleButton });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // NewButton
            // 
            NewButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            NewButton.Image = (Image)resources.GetObject("NewButton.Image");
            NewButton.ImageTransparentColor = Color.Magenta;
            NewButton.Name = "NewButton";
            NewButton.Size = new Size(39, 22);
            NewButton.Text = "Novy";
            // 
            // OpenButton
            // 
            OpenButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            OpenButton.Image = (Image)resources.GetObject("OpenButton.Image");
            OpenButton.ImageTransparentColor = Color.Magenta;
            OpenButton.Name = "OpenButton";
            OpenButton.Size = new Size(47, 22);
            OpenButton.Text = "Otevrit";
            // 
            // SaveButton
            // 
            SaveButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            SaveButton.Image = (Image)resources.GetObject("SaveButton.Image");
            SaveButton.ImageTransparentColor = Color.Magenta;
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(41, 22);
            SaveButton.Text = "Ulozit";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // LineButton
            // 
            LineButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            LineButton.Image = (Image)resources.GetObject("LineButton.Image");
            LineButton.ImageTransparentColor = Color.Magenta;
            LineButton.Name = "LineButton";
            LineButton.Size = new Size(35, 22);
            LineButton.Text = "Cara";
            // 
            // RectangleButton
            // 
            RectangleButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            RectangleButton.Image = (Image)resources.GetObject("RectangleButton.Image");
            RectangleButton.ImageTransparentColor = Color.Magenta;
            RectangleButton.Name = "RectangleButton";
            RectangleButton.Size = new Size(59, 22);
            RectangleButton.Text = "Obdelnik";
            // 
            // CircleButton
            // 
            CircleButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            CircleButton.Image = (Image)resources.GetObject("CircleButton.Image");
            CircleButton.ImageTransparentColor = Color.Magenta;
            CircleButton.Name = "CircleButton";
            CircleButton.Size = new Size(36, 22);
            CircleButton.Text = "Kruh";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(10, 55);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(778, 383);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem souborToolStripMenuItem;
        private ToolStripMenuItem novyToolStripMenuItem;
        private ToolStripMenuItem nacistToolStripMenuItem;
        private ToolStripMenuItem ulozitToolStripMenuItem;
        private ToolStripMenuItem konecToolStripMenuItem;
        private ToolStripMenuItem tvarToolStripMenuItem;
        private ToolStripMenuItem caraToolStripMenuItem;
        private ToolStripMenuItem obdelnikToolStripMenuItem;
        private ToolStripMenuItem elipsaToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton NewButton;
        private ToolStripButton OpenButton;
        private ToolStripButton SaveButton;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton LineButton;
        private ToolStripButton RectangleButton;
        private ToolStripButton CircleButton;
        private PictureBox pictureBox1;
    }
}