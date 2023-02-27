namespace SimpleGraphics {
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
            shapeComboBox = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            xStripStatusLabel = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            yStripStatusLabel = new ToolStripStatusLabel();
            label1 = new Label();
            dxTextBox = new TextBox();
            label2 = new Label();
            dyTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // shapeComboBox
            // 
            shapeComboBox.FormattingEnabled = true;
            shapeComboBox.Items.AddRange(new object[] { "Cara", "Obdelnik", "Elipsa" });
            shapeComboBox.Location = new Point(17, 7);
            shapeComboBox.Name = "shapeComboBox";
            shapeComboBox.Size = new Size(121, 23);
            shapeComboBox.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(153, 6);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Vybrat";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(705, 5);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "Konec";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(5, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(793, 402);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, xStripStatusLabel, toolStripStatusLabel2, yStripStatusLabel });
            statusStrip1.Location = new Point(0, 447);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 4;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(17, 17);
            toolStripStatusLabel1.Text = "X:";
            // 
            // xStripStatusLabel
            // 
            xStripStatusLabel.Name = "xStripStatusLabel";
            xStripStatusLabel.Size = new Size(13, 17);
            xStripStatusLabel.Text = "0";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(17, 17);
            toolStripStatusLabel2.Text = "Y:";
            // 
            // yStripStatusLabel
            // 
            yStripStatusLabel.Name = "yStripStatusLabel";
            yStripStatusLabel.Size = new Size(13, 17);
            yStripStatusLabel.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(234, 9);
            label1.Name = "label1";
            label1.Size = new Size(25, 15);
            label1.TabIndex = 5;
            label1.Text = "DX:";
            // 
            // dxTextBox
            // 
            dxTextBox.Location = new Point(265, 7);
            dxTextBox.Name = "dxTextBox";
            dxTextBox.Size = new Size(100, 23);
            dxTextBox.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(380, 9);
            label2.Name = "label2";
            label2.Size = new Size(25, 15);
            label2.TabIndex = 7;
            label2.Text = "DY:";
            // 
            // dyTextBox
            // 
            dyTextBox.Location = new Point(415, 5);
            dyTextBox.Name = "dyTextBox";
            dyTextBox.Size = new Size(100, 23);
            dyTextBox.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 469);
            Controls.Add(dyTextBox);
            Controls.Add(label2);
            Controls.Add(dxTextBox);
            Controls.Add(label1);
            Controls.Add(statusStrip1);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(shapeComboBox);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox shapeComboBox;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel xStripStatusLabel;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel yStripStatusLabel;
        private Label label1;
        private TextBox dxTextBox;
        private Label label2;
        private TextBox dyTextBox;
    }
}