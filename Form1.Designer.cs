
namespace kertesius
{
    partial class Kartesius
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
            this.grid = new System.Windows.Forms.PictureBox();
            this.Algoritma_selector = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.Koordinat_1 = new System.Windows.Forms.GroupBox();
            this.y1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.x1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.Koordinat_2 = new System.Windows.Forms.GroupBox();
            this.y2 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.x2 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.dr_line = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.Algoritma_selector.SuspendLayout();
            this.Koordinat_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.y1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x1)).BeginInit();
            this.Koordinat_2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.y2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x2)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grid.BackColor = System.Drawing.Color.White;
            this.grid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grid.Location = new System.Drawing.Point(219, 12);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(600, 600);
            this.grid.TabIndex = 0;
            this.grid.TabStop = false;
            // 
            // Algoritma_selector
            // 
            this.Algoritma_selector.Controls.Add(this.radioButton4);
            this.Algoritma_selector.Controls.Add(this.radioButton3);
            this.Algoritma_selector.Controls.Add(this.radioButton2);
            this.Algoritma_selector.Controls.Add(this.radioButton1);
            this.Algoritma_selector.Location = new System.Drawing.Point(12, 12);
            this.Algoritma_selector.Name = "Algoritma_selector";
            this.Algoritma_selector.Size = new System.Drawing.Size(137, 119);
            this.Algoritma_selector.TabIndex = 3;
            this.Algoritma_selector.TabStop = false;
            this.Algoritma_selector.Text = "Algoritma";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Checked = true;
            this.radioButton4.Location = new System.Drawing.Point(7, 16);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(94, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "built In method";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 85);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(124, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "Algoritma Bresenham";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 62);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(94, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Algoritma DDA";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 39);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(97, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "Algoritma naive";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Koordinat_1
            // 
            this.Koordinat_1.Controls.Add(this.y1);
            this.Koordinat_1.Controls.Add(this.label2);
            this.Koordinat_1.Controls.Add(this.x1);
            this.Koordinat_1.Controls.Add(this.label1);
            this.Koordinat_1.Location = new System.Drawing.Point(12, 149);
            this.Koordinat_1.Name = "Koordinat_1";
            this.Koordinat_1.Size = new System.Drawing.Size(158, 78);
            this.Koordinat_1.TabIndex = 4;
            this.Koordinat_1.TabStop = false;
            this.Koordinat_1.Text = "Koordinat 1";
            // 
            // y1
            // 
            this.y1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.y1.Location = new System.Drawing.Point(27, 44);
            this.y1.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.y1.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            -2147483648});
            this.y1.Name = "y1";
            this.y1.Size = new System.Drawing.Size(120, 20);
            this.y1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Y";
            // 
            // x1
            // 
            this.x1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.x1.Location = new System.Drawing.Point(27, 18);
            this.x1.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.x1.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            -2147483648});
            this.x1.Name = "x1";
            this.x1.Size = new System.Drawing.Size(120, 20);
            this.x1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            // 
            // Koordinat_2
            // 
            this.Koordinat_2.Controls.Add(this.y2);
            this.Koordinat_2.Controls.Add(this.label3);
            this.Koordinat_2.Controls.Add(this.x2);
            this.Koordinat_2.Controls.Add(this.label4);
            this.Koordinat_2.Location = new System.Drawing.Point(12, 245);
            this.Koordinat_2.Name = "Koordinat_2";
            this.Koordinat_2.Size = new System.Drawing.Size(158, 78);
            this.Koordinat_2.TabIndex = 5;
            this.Koordinat_2.TabStop = false;
            this.Koordinat_2.Text = "Koordinat 2";
            // 
            // y2
            // 
            this.y2.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.y2.Location = new System.Drawing.Point(27, 44);
            this.y2.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.y2.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            -2147483648});
            this.y2.Name = "y2";
            this.y2.Size = new System.Drawing.Size(120, 20);
            this.y2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Y";
            // 
            // x2
            // 
            this.x2.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.x2.Location = new System.Drawing.Point(27, 18);
            this.x2.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.x2.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            -2147483648});
            this.x2.Name = "x2";
            this.x2.Size = new System.Drawing.Size(120, 20);
            this.x2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "X";
            // 
            // dr_line
            // 
            this.dr_line.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.dr_line.Location = new System.Drawing.Point(39, 329);
            this.dr_line.Name = "dr_line";
            this.dr_line.Size = new System.Drawing.Size(75, 23);
            this.dr_line.TabIndex = 6;
            this.dr_line.Text = "Draw line";
            this.dr_line.UseVisualStyleBackColor = true;
            this.dr_line.Click += new System.EventHandler(this.dr_line_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(39, 358);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 7;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // Kartesius
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 623);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.dr_line);
            this.Controls.Add(this.Koordinat_2);
            this.Controls.Add(this.Koordinat_1);
            this.Controls.Add(this.Algoritma_selector);
            this.Controls.Add(this.grid);
            this.Name = "Kartesius";
            this.Text = "kartesius";
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.Algoritma_selector.ResumeLayout(false);
            this.Algoritma_selector.PerformLayout();
            this.Koordinat_1.ResumeLayout(false);
            this.Koordinat_1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.y1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x1)).EndInit();
            this.Koordinat_2.ResumeLayout(false);
            this.Koordinat_2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.y2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox grid;
        private System.Windows.Forms.GroupBox Algoritma_selector;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox Koordinat_1;
        private System.Windows.Forms.NumericUpDown y1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown x1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Koordinat_2;
        private System.Windows.Forms.NumericUpDown y2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown x2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button dr_line;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Button buttonClear;
    }
}

