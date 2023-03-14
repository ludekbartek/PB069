namespace BooksFile
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
            label1 = new Label();
            authorBox = new TextBox();
            label2 = new Label();
            titleBox = new TextBox();
            label3 = new Label();
            publishedUpDown = new NumericUpDown();
            button1 = new Button();
            button2 = new Button();
            textBox3 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)publishedUpDown).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 27);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Autor:";
            // 
            // authorBox
            // 
            authorBox.Location = new Point(58, 23);
            authorBox.Name = "authorBox";
            authorBox.Size = new Size(188, 23);
            authorBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(276, 26);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 2;
            label2.Text = "Titul:";
            // 
            // titleBox
            // 
            titleBox.Location = new Point(326, 20);
            titleBox.Name = "titleBox";
            titleBox.Size = new Size(153, 23);
            titleBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(499, 25);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 4;
            label3.Text = "Vydano:";
            // 
            // publishedUpDown
            // 
            publishedUpDown.Location = new Point(566, 23);
            publishedUpDown.Maximum = new decimal(new int[] { 2022, 0, 0, 0 });
            publishedUpDown.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
            publishedUpDown.Name = "publishedUpDown";
            publishedUpDown.Size = new Size(120, 23);
            publishedUpDown.TabIndex = 5;
            publishedUpDown.Value = new decimal(new int[] { 1900, 0, 0, 0 });
            // 
            // button1
            // 
            button1.Location = new Point(703, 20);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Pridat";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(345, 415);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 7;
            button2.Text = "Konec";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(15, 74);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(773, 312);
            textBox3.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(publishedUpDown);
            Controls.Add(label3);
            Controls.Add(titleBox);
            Controls.Add(label2);
            Controls.Add(authorBox);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)publishedUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox authorBox;
        private Label label2;
        private TextBox titleBox;
        private Label label3;
        private NumericUpDown publishedUpDown;
        private Button button1;
        private Button button2;
        private TextBox textBox3;
    }
}