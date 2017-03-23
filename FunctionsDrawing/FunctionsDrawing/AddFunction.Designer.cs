namespace FunctionsDrawing
{
    partial class AddFunction
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.aUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.fUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.colorCombo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.aUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // aUpDown1
            // 
            this.aUpDown1.Location = new System.Drawing.Point(15, 23);
            this.aUpDown1.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.aUpDown1.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.aUpDown1.Name = "aUpDown1";
            this.aUpDown1.Size = new System.Drawing.Size(54, 20);
            this.aUpDown1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "*";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "sin",
            "cos"});
            this.comboBox1.Location = new System.Drawing.Point(92, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(71, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = "function";
            // 
            // fUpDown
            // 
            this.fUpDown.Location = new System.Drawing.Point(169, 23);
            this.fUpDown.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.fUpDown.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            -2147483648});
            this.fUpDown.Name = "fUpDown";
            this.fUpDown.Size = new System.Drawing.Size(38, 20);
            this.fUpDown.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "x";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(247, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(247, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // colorCombo
            // 
            this.colorCombo.FormattingEnabled = true;
            this.colorCombo.Location = new System.Drawing.Point(15, 63);
            this.colorCombo.Name = "colorCombo";
            this.colorCombo.Size = new System.Drawing.Size(121, 21);
            this.colorCombo.TabIndex = 7;
            // 
            // AddFunction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 106);
            this.Controls.Add(this.colorCombo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fUpDown);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aUpDown1);
            this.Name = "AddFunction";
            this.Text = "AddFunction";
            this.Load += new System.EventHandler(this.AddFunction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown aUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown fUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox colorCombo;
    }
}