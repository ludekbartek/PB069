namespace Kartoteka
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.obrazekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.otevritToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ulozitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.konecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jizdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kruhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obdelnikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.obrazekToolStripMenuItem,
            this.jizdaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // obrazekToolStripMenuItem
            // 
            this.obrazekToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novyToolStripMenuItem,
            this.toolStripMenuItem1,
            this.otevritToolStripMenuItem,
            this.ulozitToolStripMenuItem,
            this.toolStripMenuItem2,
            this.konecToolStripMenuItem});
            this.obrazekToolStripMenuItem.Name = "obrazekToolStripMenuItem";
            this.obrazekToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.obrazekToolStripMenuItem.Text = "Obrazek";
            // 
            // novyToolStripMenuItem
            // 
            this.novyToolStripMenuItem.Name = "novyToolStripMenuItem";
            this.novyToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.novyToolStripMenuItem.Text = "Nova";
            this.novyToolStripMenuItem.Click += new System.EventHandler(this.novyToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(107, 6);
            // 
            // otevritToolStripMenuItem
            // 
            this.otevritToolStripMenuItem.Name = "otevritToolStripMenuItem";
            this.otevritToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.otevritToolStripMenuItem.Text = "Otevrit";
            // 
            // ulozitToolStripMenuItem
            // 
            this.ulozitToolStripMenuItem.Name = "ulozitToolStripMenuItem";
            this.ulozitToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.ulozitToolStripMenuItem.Text = "Ulozit";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(107, 6);
            // 
            // konecToolStripMenuItem
            // 
            this.konecToolStripMenuItem.Name = "konecToolStripMenuItem";
            this.konecToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.konecToolStripMenuItem.Text = "Konec";
            // 
            // jizdaToolStripMenuItem
            // 
            this.jizdaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.caraToolStripMenuItem,
            this.kruhToolStripMenuItem,
            this.obdelnikToolStripMenuItem});
            this.jizdaToolStripMenuItem.Name = "jizdaToolStripMenuItem";
            this.jizdaToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.jizdaToolStripMenuItem.Text = "Tvar";
            // 
            // caraToolStripMenuItem
            // 
            this.caraToolStripMenuItem.Name = "caraToolStripMenuItem";
            this.caraToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.caraToolStripMenuItem.Text = "Cara";
            this.caraToolStripMenuItem.Click += new System.EventHandler(this.caraToolStripMenuItem_Click);
            // 
            // kruhToolStripMenuItem
            // 
            this.kruhToolStripMenuItem.Name = "kruhToolStripMenuItem";
            this.kruhToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.kruhToolStripMenuItem.Text = "Kruh";
            this.kruhToolStripMenuItem.Click += new System.EventHandler(this.kruhToolStripMenuItem_Click);
            // 
            // obdelnikToolStripMenuItem
            // 
            this.obdelnikToolStripMenuItem.Name = "obdelnikToolStripMenuItem";
            this.obdelnikToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.obdelnikToolStripMenuItem.Text = "Obdelnik";
            this.obdelnikToolStripMenuItem.Click += new System.EventHandler(this.obdelnikToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(2, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(799, 421);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem obrazekToolStripMenuItem;
        private ToolStripMenuItem novyToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem otevritToolStripMenuItem;
        private ToolStripMenuItem ulozitToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem konecToolStripMenuItem;
        private ToolStripMenuItem jizdaToolStripMenuItem;
        private ToolStripMenuItem caraToolStripMenuItem;
        private ToolStripMenuItem kruhToolStripMenuItem;
        private ToolStripMenuItem obdelnikToolStripMenuItem;
        private PictureBox pictureBox1;
    }
}