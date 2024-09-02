
namespace Gui
{
    partial class Form1
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
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.comboBoxFunction = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.renderShapeButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxZ = new System.Windows.Forms.TextBox();
            this.comboBoxSelectShape = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(9, 208);
            this.textBoxOutput.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxOutput.MaxLength = 17;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(124, 20);
            this.textBoxOutput.TabIndex = 4;
            // 
            // comboBoxFunction
            // 
            this.comboBoxFunction.FormattingEnabled = true;
            this.comboBoxFunction.Items.AddRange(new object[] {
            "Circumference",
            "Surface Area",
            "Volume"});
            this.comboBoxFunction.Location = new System.Drawing.Point(9, 168);
            this.comboBoxFunction.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxFunction.Name = "comboBoxFunction";
            this.comboBoxFunction.Size = new System.Drawing.Size(92, 21);
            this.comboBoxFunction.TabIndex = 6;
            this.comboBoxFunction.SelectedIndexChanged += new System.EventHandler(this.comboBoxFunction_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Select Shape";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Input Dimensions";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 152);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Select Function";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 192);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Output";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(269, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(496, 326);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // renderShapeButton
            // 
            this.renderShapeButton.Location = new System.Drawing.Point(160, 162);
            this.renderShapeButton.Margin = new System.Windows.Forms.Padding(2);
            this.renderShapeButton.Name = "renderShapeButton";
            this.renderShapeButton.Size = new System.Drawing.Size(85, 27);
            this.renderShapeButton.TabIndex = 12;
            this.renderShapeButton.Text = "Render Shape";
            this.renderShapeButton.UseVisualStyleBackColor = true;
            this.renderShapeButton.Click += new System.EventHandler(this.renderShapeButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 72);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "(x)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 122);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 108);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "(z)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(102, 72);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "(y)";
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(104, 89);
            this.textBoxY.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxY.MaxLength = 9;
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(92, 20);
            this.textBoxY.TabIndex = 27;
            this.textBoxY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxY_KeyPress);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(160, 204);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(2);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(85, 27);
            this.calculateButton.TabIndex = 28;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(9, 89);
            this.textBoxX.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxX.MaxLength = 9;
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(92, 20);
            this.textBoxX.TabIndex = 29;
            this.textBoxX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxX_KeyPress);
            // 
            // textBoxZ
            // 
            this.textBoxZ.Location = new System.Drawing.Point(9, 126);
            this.textBoxZ.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxZ.MaxLength = 9;
            this.textBoxZ.Name = "textBoxZ";
            this.textBoxZ.Size = new System.Drawing.Size(92, 20);
            this.textBoxZ.TabIndex = 30;
            this.textBoxZ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxZ_KeyPress);
            // 
            // comboBoxSelectShape
            // 
            this.comboBoxSelectShape.FormattingEnabled = true;
            this.comboBoxSelectShape.Items.AddRange(new object[] {
            "Circle",
            "Triangle",
            "Square",
            "Sphere",
            "Pyramid",
            "Cube"});
            this.comboBoxSelectShape.Location = new System.Drawing.Point(9, 29);
            this.comboBoxSelectShape.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxSelectShape.Name = "comboBoxSelectShape";
            this.comboBoxSelectShape.Size = new System.Drawing.Size(92, 21);
            this.comboBoxSelectShape.TabIndex = 31;
            this.comboBoxSelectShape.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 362);
            this.Controls.Add(this.comboBoxSelectShape);
            this.Controls.Add(this.comboBoxFunction);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.textBoxZ);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.renderShapeButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.textBoxOutput);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Geometry solver 1.0.3";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxSelectShape;
        private System.Windows.Forms.ComboBox comboBoxFunction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxZ;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button renderShapeButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox textBoxOutput;

    }
}

