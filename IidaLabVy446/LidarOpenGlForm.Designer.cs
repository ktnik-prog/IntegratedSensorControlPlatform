﻿namespace IidaLabVy446
{
    partial class LidarOpenGlForm
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
            this.glControl1 = new OpenTK.GLControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GlBodySpeedTxtBox = new System.Windows.Forms.TextBox();
            this.GlBodyHeadingTxtBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.GlElapsedTxtBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GlTmZTxtBox = new System.Windows.Forms.TextBox();
            this.GlTmYTxtBox = new System.Windows.Forms.TextBox();
            this.GlTmXTxtBox = new System.Windows.Forms.TextBox();
            this.GlCurCntTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GlReadCntTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.GlAvgCropHgtTxtBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.GlRanPosX1TxtBox = new System.Windows.Forms.TextBox();
            this.GlRanPosY1TxtBox = new System.Windows.Forms.TextBox();
            this.GlRanPosX2TxtBox = new System.Windows.Forms.TextBox();
            this.GlRanPosY2TxtBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // glControl1
            // 
            this.glControl1.BackColor = System.Drawing.Color.Black;
            this.glControl1.Location = new System.Drawing.Point(6, 18);
            this.glControl1.Name = "glControl1";
            this.glControl1.Size = new System.Drawing.Size(500, 500);
            this.glControl1.TabIndex = 0;
            this.glControl1.VSync = false;
            this.glControl1.Load += new System.EventHandler(this.glControl1_Load);
            this.glControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.glControl1_Paint);
            this.glControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.glControl1_KeyDown);
            this.glControl1.Resize += new System.EventHandler(this.glControl1_Resize);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.glControl1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(516, 526);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OpenGL";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.GlBodySpeedTxtBox);
            this.groupBox2.Controls.Add(this.GlBodyHeadingTxtBox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.GlElapsedTxtBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.GlTmZTxtBox);
            this.groupBox2.Controls.Add(this.GlTmYTxtBox);
            this.groupBox2.Controls.Add(this.GlTmXTxtBox);
            this.groupBox2.Controls.Add(this.GlCurCntTxtBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.GlReadCntTxtBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(534, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(204, 239);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Debug";
            // 
            // GlBodySpeedTxtBox
            // 
            this.GlBodySpeedTxtBox.Location = new System.Drawing.Point(92, 182);
            this.GlBodySpeedTxtBox.Name = "GlBodySpeedTxtBox";
            this.GlBodySpeedTxtBox.Size = new System.Drawing.Size(100, 19);
            this.GlBodySpeedTxtBox.TabIndex = 15;
            // 
            // GlBodyHeadingTxtBox
            // 
            this.GlBodyHeadingTxtBox.Location = new System.Drawing.Point(92, 157);
            this.GlBodyHeadingTxtBox.Name = "GlBodyHeadingTxtBox";
            this.GlBodyHeadingTxtBox.Size = new System.Drawing.Size(100, 19);
            this.GlBodyHeadingTxtBox.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 12);
            this.label8.TabIndex = 13;
            this.label8.Text = "Speed: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "Heading: ";
            // 
            // GlElapsedTxtBox
            // 
            this.GlElapsedTxtBox.Location = new System.Drawing.Point(92, 207);
            this.GlElapsedTxtBox.Name = "GlElapsedTxtBox";
            this.GlElapsedTxtBox.Size = new System.Drawing.Size(100, 19);
            this.GlElapsedTxtBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "Elapsed Time: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tm Z: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tm Y: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tm X: ";
            // 
            // GlTmZTxtBox
            // 
            this.GlTmZTxtBox.Location = new System.Drawing.Point(92, 132);
            this.GlTmZTxtBox.Name = "GlTmZTxtBox";
            this.GlTmZTxtBox.Size = new System.Drawing.Size(100, 19);
            this.GlTmZTxtBox.TabIndex = 6;
            // 
            // GlTmYTxtBox
            // 
            this.GlTmYTxtBox.Location = new System.Drawing.Point(92, 107);
            this.GlTmYTxtBox.Name = "GlTmYTxtBox";
            this.GlTmYTxtBox.Size = new System.Drawing.Size(100, 19);
            this.GlTmYTxtBox.TabIndex = 5;
            // 
            // GlTmXTxtBox
            // 
            this.GlTmXTxtBox.Location = new System.Drawing.Point(92, 82);
            this.GlTmXTxtBox.Name = "GlTmXTxtBox";
            this.GlTmXTxtBox.Size = new System.Drawing.Size(100, 19);
            this.GlTmXTxtBox.TabIndex = 4;
            // 
            // GlCurCntTxtBox
            // 
            this.GlCurCntTxtBox.Location = new System.Drawing.Point(92, 57);
            this.GlCurCntTxtBox.Name = "GlCurCntTxtBox";
            this.GlCurCntTxtBox.Size = new System.Drawing.Size(100, 19);
            this.GlCurCntTxtBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Crop Cnt: ";
            // 
            // GlReadCntTxtBox
            // 
            this.GlReadCntTxtBox.Location = new System.Drawing.Point(92, 32);
            this.GlReadCntTxtBox.Name = "GlReadCntTxtBox";
            this.GlReadCntTxtBox.Size = new System.Drawing.Size(100, 19);
            this.GlReadCntTxtBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Read Count: ";
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(534, 448);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(204, 23);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "CLOSE FORM";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(6, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "SAVE DATA";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.GlRanPosY2TxtBox);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.GlRanPosX2TxtBox);
            this.groupBox3.Controls.Add(this.GlRanPosY1TxtBox);
            this.groupBox3.Controls.Add(this.GlRanPosX1TxtBox);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.GlAvgCropHgtTxtBox);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(534, 257);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(204, 185);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Save Information";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "Crop Hgt(Avg): ";
            // 
            // GlAvgCropHgtTxtBox
            // 
            this.GlAvgCropHgtTxtBox.Location = new System.Drawing.Point(92, 27);
            this.GlAvgCropHgtTxtBox.Name = "GlAvgCropHgtTxtBox";
            this.GlAvgCropHgtTxtBox.Size = new System.Drawing.Size(100, 19);
            this.GlAvgCropHgtTxtBox.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 12);
            this.label10.TabIndex = 2;
            this.label10.Text = "Edge posX1: ";
            // 
            // GlRanPosX1TxtBox
            // 
            this.GlRanPosX1TxtBox.Location = new System.Drawing.Point(92, 52);
            this.GlRanPosX1TxtBox.Name = "GlRanPosX1TxtBox";
            this.GlRanPosX1TxtBox.Size = new System.Drawing.Size(100, 19);
            this.GlRanPosX1TxtBox.TabIndex = 3;
            // 
            // GlRanPosY1TxtBox
            // 
            this.GlRanPosY1TxtBox.Location = new System.Drawing.Point(92, 77);
            this.GlRanPosY1TxtBox.Name = "GlRanPosY1TxtBox";
            this.GlRanPosY1TxtBox.Size = new System.Drawing.Size(100, 19);
            this.GlRanPosY1TxtBox.TabIndex = 4;
            // 
            // GlRanPosX2TxtBox
            // 
            this.GlRanPosX2TxtBox.Location = new System.Drawing.Point(92, 102);
            this.GlRanPosX2TxtBox.Name = "GlRanPosX2TxtBox";
            this.GlRanPosX2TxtBox.Size = new System.Drawing.Size(100, 19);
            this.GlRanPosX2TxtBox.TabIndex = 5;
            // 
            // GlRanPosY2TxtBox
            // 
            this.GlRanPosY2TxtBox.Location = new System.Drawing.Point(92, 127);
            this.GlRanPosY2TxtBox.Name = "GlRanPosY2TxtBox";
            this.GlRanPosY2TxtBox.Size = new System.Drawing.Size(100, 19);
            this.GlRanPosY2TxtBox.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 12);
            this.label11.TabIndex = 7;
            this.label11.Text = "Edge posY1: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 105);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 12);
            this.label12.TabIndex = 8;
            this.label12.Text = "Edge posX2: ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 130);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 12);
            this.label13.TabIndex = 9;
            this.label13.Text = "Edge posY2: ";
            // 
            // LidarOpenGlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 555);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "LidarOpenGlForm";
            this.Text = "3D terrain map (using LRF, RTK-GPS, GPS compass )";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private OpenTK.GLControl glControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox GlElapsedTxtBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox GlTmZTxtBox;
        private System.Windows.Forms.TextBox GlTmYTxtBox;
        private System.Windows.Forms.TextBox GlTmXTxtBox;
        private System.Windows.Forms.TextBox GlCurCntTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox GlReadCntTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox GlBodySpeedTxtBox;
        private System.Windows.Forms.TextBox GlBodyHeadingTxtBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox GlRanPosY2TxtBox;
        private System.Windows.Forms.TextBox GlRanPosX2TxtBox;
        private System.Windows.Forms.TextBox GlRanPosY1TxtBox;
        private System.Windows.Forms.TextBox GlRanPosX1TxtBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox GlAvgCropHgtTxtBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
    }
}