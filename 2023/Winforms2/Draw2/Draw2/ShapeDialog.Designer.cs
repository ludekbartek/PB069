namespace Draw2 {
    partial class ShapeDialog {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            label1 = new Label();
            label2 = new Label();
            WidthUpDown = new NumericUpDown();
            HeightUpDown2 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)WidthUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HeightUpDown2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 19);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Width";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 51);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 1;
            label2.Text = "Height";
            // 
            // WidthUpDown
            // 
            WidthUpDown.Location = new Point(77, 17);
            WidthUpDown.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            WidthUpDown.Name = "WidthUpDown";
            WidthUpDown.Size = new Size(120, 23);
            WidthUpDown.TabIndex = 2;
            WidthUpDown.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // HeightUpDown2
            // 
            HeightUpDown2.Location = new Point(77, 49);
            HeightUpDown2.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            HeightUpDown2.Name = "HeightUpDown2";
            HeightUpDown2.Size = new Size(120, 23);
            HeightUpDown2.TabIndex = 3;
            HeightUpDown2.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // ShapeDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 282);
            Controls.Add(HeightUpDown2);
            Controls.Add(WidthUpDown);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ShapeDialog";
            Text = "ShapeDialog";
            ((System.ComponentModel.ISupportInitialize)WidthUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)HeightUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private NumericUpDown WidthUpDown;
        private NumericUpDown HeightUpDown2;
    }
}