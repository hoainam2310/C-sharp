﻿
namespace baitapbuoi8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gb_Draw = new System.Windows.Forms.GroupBox();
            this.gb_Image = new System.Windows.Forms.GroupBox();
            this.rd_Line = new System.Windows.Forms.RadioButton();
            this.rd_Fill_Ellipse = new System.Windows.Forms.RadioButton();
            this.rd_Ellipse = new System.Windows.Forms.RadioButton();
            this.rd_String = new System.Windows.Forms.RadioButton();
            this.rd_Fill_Rectangle = new System.Windows.Forms.RadioButton();
            this.rd_Rectangle = new System.Windows.Forms.RadioButton();
            this.btn_PenColor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Clean = new System.Windows.Forms.Button();
            this.btn_Load_Image = new System.Windows.Forms.Button();
            this.nud_PenWidth = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_Point_X = new System.Windows.Forms.TextBox();
            this.txb_Point_Y = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.gb_Draw.SuspendLayout();
            this.gb_Image.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_PenWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox1.Controls.Add(this.btn_Clean);
            this.groupBox1.Controls.Add(this.gb_Image);
            this.groupBox1.Controls.Add(this.gb_Draw);
            this.groupBox1.Location = new System.Drawing.Point(880, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 730);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // gb_Draw
            // 
            this.gb_Draw.BackColor = System.Drawing.Color.CadetBlue;
            this.gb_Draw.Controls.Add(this.nud_PenWidth);
            this.gb_Draw.Controls.Add(this.label1);
            this.gb_Draw.Controls.Add(this.btn_PenColor);
            this.gb_Draw.Controls.Add(this.rd_Rectangle);
            this.gb_Draw.Controls.Add(this.rd_Fill_Rectangle);
            this.gb_Draw.Controls.Add(this.rd_String);
            this.gb_Draw.Controls.Add(this.rd_Ellipse);
            this.gb_Draw.Controls.Add(this.rd_Fill_Ellipse);
            this.gb_Draw.Controls.Add(this.rd_Line);
            this.gb_Draw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Draw.ForeColor = System.Drawing.Color.Black;
            this.gb_Draw.Location = new System.Drawing.Point(30, 21);
            this.gb_Draw.Name = "gb_Draw";
            this.gb_Draw.Size = new System.Drawing.Size(434, 390);
            this.gb_Draw.TabIndex = 1;
            this.gb_Draw.TabStop = false;
            this.gb_Draw.Text = "Draw";
            // 
            // gb_Image
            // 
            this.gb_Image.BackColor = System.Drawing.Color.CadetBlue;
            this.gb_Image.Controls.Add(this.txb_Point_Y);
            this.gb_Image.Controls.Add(this.txb_Point_X);
            this.gb_Image.Controls.Add(this.label2);
            this.gb_Image.Controls.Add(this.btn_Load_Image);
            this.gb_Image.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Image.Location = new System.Drawing.Point(30, 525);
            this.gb_Image.Name = "gb_Image";
            this.gb_Image.Size = new System.Drawing.Size(434, 199);
            this.gb_Image.TabIndex = 2;
            this.gb_Image.TabStop = false;
            this.gb_Image.Text = "Image";
            // 
            // rd_Line
            // 
            this.rd_Line.AutoSize = true;
            this.rd_Line.Location = new System.Drawing.Point(36, 65);
            this.rd_Line.Name = "rd_Line";
            this.rd_Line.Size = new System.Drawing.Size(70, 29);
            this.rd_Line.TabIndex = 0;
            this.rd_Line.TabStop = true;
            this.rd_Line.Text = "Line";
            this.rd_Line.UseVisualStyleBackColor = true;
            // 
            // rd_Fill_Ellipse
            // 
            this.rd_Fill_Ellipse.AutoSize = true;
            this.rd_Fill_Ellipse.Location = new System.Drawing.Point(282, 167);
            this.rd_Fill_Ellipse.Name = "rd_Fill_Ellipse";
            this.rd_Fill_Ellipse.Size = new System.Drawing.Size(119, 29);
            this.rd_Fill_Ellipse.TabIndex = 1;
            this.rd_Fill_Ellipse.TabStop = true;
            this.rd_Fill_Ellipse.Text = "Fill Ellipse";
            this.rd_Fill_Ellipse.UseVisualStyleBackColor = true;
            // 
            // rd_Ellipse
            // 
            this.rd_Ellipse.AutoSize = true;
            this.rd_Ellipse.Location = new System.Drawing.Point(282, 110);
            this.rd_Ellipse.Name = "rd_Ellipse";
            this.rd_Ellipse.Size = new System.Drawing.Size(90, 29);
            this.rd_Ellipse.TabIndex = 2;
            this.rd_Ellipse.TabStop = true;
            this.rd_Ellipse.Text = "Ellipse";
            this.rd_Ellipse.UseVisualStyleBackColor = true;
            // 
            // rd_String
            // 
            this.rd_String.AutoSize = true;
            this.rd_String.Location = new System.Drawing.Point(282, 65);
            this.rd_String.Name = "rd_String";
            this.rd_String.Size = new System.Drawing.Size(84, 29);
            this.rd_String.TabIndex = 3;
            this.rd_String.TabStop = true;
            this.rd_String.Text = "String";
            this.rd_String.UseVisualStyleBackColor = true;
            // 
            // rd_Fill_Rectangle
            // 
            this.rd_Fill_Rectangle.AutoSize = true;
            this.rd_Fill_Rectangle.Location = new System.Drawing.Point(36, 167);
            this.rd_Fill_Rectangle.Name = "rd_Fill_Rectangle";
            this.rd_Fill_Rectangle.Size = new System.Drawing.Size(149, 29);
            this.rd_Fill_Rectangle.TabIndex = 4;
            this.rd_Fill_Rectangle.TabStop = true;
            this.rd_Fill_Rectangle.Text = "Fill Rectangle";
            this.rd_Fill_Rectangle.UseVisualStyleBackColor = true;
            // 
            // rd_Rectangle
            // 
            this.rd_Rectangle.AutoSize = true;
            this.rd_Rectangle.Location = new System.Drawing.Point(36, 110);
            this.rd_Rectangle.Name = "rd_Rectangle";
            this.rd_Rectangle.Size = new System.Drawing.Size(120, 29);
            this.rd_Rectangle.TabIndex = 5;
            this.rd_Rectangle.TabStop = true;
            this.rd_Rectangle.Text = "Rectangle";
            this.rd_Rectangle.UseVisualStyleBackColor = true;
            this.rd_Rectangle.CheckedChanged += new System.EventHandler(this.rd_Rectangle_CheckedChanged);
            // 
            // btn_PenColor
            // 
            this.btn_PenColor.BackColor = System.Drawing.Color.Black;
            this.btn_PenColor.ForeColor = System.Drawing.Color.White;
            this.btn_PenColor.Location = new System.Drawing.Point(36, 219);
            this.btn_PenColor.Name = "btn_PenColor";
            this.btn_PenColor.Size = new System.Drawing.Size(365, 65);
            this.btn_PenColor.TabIndex = 6;
            this.btn_PenColor.Text = "Pen Color";
            this.btn_PenColor.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Pen Width";
            // 
            // btn_Clean
            // 
            this.btn_Clean.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_Clean.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clean.ForeColor = System.Drawing.Color.White;
            this.btn_Clean.Location = new System.Drawing.Point(30, 428);
            this.btn_Clean.Name = "btn_Clean";
            this.btn_Clean.Size = new System.Drawing.Size(434, 65);
            this.btn_Clean.TabIndex = 8;
            this.btn_Clean.Text = "Clean";
            this.btn_Clean.UseVisualStyleBackColor = false;
            // 
            // btn_Load_Image
            // 
            this.btn_Load_Image.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_Load_Image.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Load_Image.ForeColor = System.Drawing.Color.White;
            this.btn_Load_Image.Location = new System.Drawing.Point(16, 127);
            this.btn_Load_Image.Name = "btn_Load_Image";
            this.btn_Load_Image.Size = new System.Drawing.Size(400, 56);
            this.btn_Load_Image.TabIndex = 9;
            this.btn_Load_Image.Text = "Load Image";
            this.btn_Load_Image.UseVisualStyleBackColor = false;
            // 
            // nud_PenWidth
            // 
            this.nud_PenWidth.Location = new System.Drawing.Point(151, 321);
            this.nud_PenWidth.Name = "nud_PenWidth";
            this.nud_PenWidth.Size = new System.Drawing.Size(250, 30);
            this.nud_PenWidth.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Point X, Y";
            // 
            // txb_Point_X
            // 
            this.txb_Point_X.Location = new System.Drawing.Point(173, 67);
            this.txb_Point_X.Name = "txb_Point_X";
            this.txb_Point_X.Size = new System.Drawing.Size(100, 30);
            this.txb_Point_X.TabIndex = 11;
            this.txb_Point_X.Text = "100";
            // 
            // txb_Point_Y
            // 
            this.txb_Point_Y.Location = new System.Drawing.Point(316, 67);
            this.txb_Point_Y.Name = "txb_Point_Y";
            this.txb_Point_Y.Size = new System.Drawing.Size(100, 30);
            this.txb_Point_Y.TabIndex = 12;
            this.txb_Point_Y.Text = "100";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1362, 754);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Paint";
            this.groupBox1.ResumeLayout(false);
            this.gb_Draw.ResumeLayout(false);
            this.gb_Draw.PerformLayout();
            this.gb_Image.ResumeLayout(false);
            this.gb_Image.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_PenWidth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Clean;
        private System.Windows.Forms.GroupBox gb_Image;
        private System.Windows.Forms.TextBox txb_Point_Y;
        private System.Windows.Forms.TextBox txb_Point_X;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Load_Image;
        private System.Windows.Forms.GroupBox gb_Draw;
        private System.Windows.Forms.NumericUpDown nud_PenWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_PenColor;
        private System.Windows.Forms.RadioButton rd_Rectangle;
        private System.Windows.Forms.RadioButton rd_Fill_Rectangle;
        private System.Windows.Forms.RadioButton rd_String;
        private System.Windows.Forms.RadioButton rd_Ellipse;
        private System.Windows.Forms.RadioButton rd_Fill_Ellipse;
        private System.Windows.Forms.RadioButton rd_Line;
    }
}

