namespace Kartoteka_drag_n_drop
{
    partial class AddObject
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dxUpDown = new System.Windows.Forms.NumericUpDown();
            this.dyUpDown = new System.Windows.Forms.NumericUpDown();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dxUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dyUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(19, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(145, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "Typ objektu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Délka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Výška";
            // 
            // dxUpDown
            // 
            this.dxUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.dxUpDown.Location = new System.Drawing.Point(70, 53);
            this.dxUpDown.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.dxUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.dxUpDown.Name = "dxUpDown";
            this.dxUpDown.Size = new System.Drawing.Size(94, 20);
            this.dxUpDown.TabIndex = 3;
            this.dxUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // dyUpDown
            // 
            this.dyUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.dyUpDown.Location = new System.Drawing.Point(70, 77);
            this.dyUpDown.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.dyUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.dyUpDown.Name = "dyUpDown";
            this.dyUpDown.Size = new System.Drawing.Size(94, 20);
            this.dyUpDown.TabIndex = 4;
            this.dyUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(192, 17);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 5;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(192, 46);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // AddObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 110);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.dyUpDown);
            this.Controls.Add(this.dxUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "AddObject";
            this.Text = "AddObject";
            ((System.ComponentModel.ISupportInitialize)(this.dxUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dyUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown dxUpDown;
        private System.Windows.Forms.NumericUpDown dyUpDown;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
    }
}