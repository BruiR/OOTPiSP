namespace OOP_L1_1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDraw = new System.Windows.Forms.Button();
            this.pBoxDrawing = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pBoxColor = new System.Windows.Forms.PictureBox();
            this.btnLine = new System.Windows.Forms.Button();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.btnSquare = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.btnEllipse = new System.Windows.Forms.Button();
            this.btnTriangle = new System.Windows.Forms.Button();
            this.trackBarThickness = new System.Windows.Forms.TrackBar();
            this.labelThickness = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxDrawing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarThickness)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(35, 12);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(97, 39);
            this.btnDraw.TabIndex = 0;
            this.btnDraw.Text = "Нарисовать (лаба1)";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.BtnDraw_Click);
            // 
            // pBoxDrawing
            // 
            this.pBoxDrawing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBoxDrawing.Location = new System.Drawing.Point(198, 10);
            this.pBoxDrawing.Name = "pBoxDrawing";
            this.pBoxDrawing.Size = new System.Drawing.Size(745, 426);
            this.pBoxDrawing.TabIndex = 2;
            this.pBoxDrawing.TabStop = false;
            this.pBoxDrawing.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pBoxDrawing_MouseDown);
            this.pBoxDrawing.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pBoxDrawing_MouseUp);
            // 
            // pBoxColor
            // 
            this.pBoxColor.BackColor = System.Drawing.Color.Black;
            this.pBoxColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBoxColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBoxColor.Location = new System.Drawing.Point(35, 85);
            this.pBoxColor.Name = "pBoxColor";
            this.pBoxColor.Size = new System.Drawing.Size(97, 31);
            this.pBoxColor.TabIndex = 3;
            this.pBoxColor.TabStop = false;
            this.pBoxColor.Click += new System.EventHandler(this.pBoxColor_Click);
            // 
            // btnLine
            // 
            this.btnLine.Location = new System.Drawing.Point(35, 122);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(97, 23);
            this.btnLine.TabIndex = 4;
            this.btnLine.Text = "Линия";
            this.btnLine.UseVisualStyleBackColor = true;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // btnRectangle
            // 
            this.btnRectangle.Location = new System.Drawing.Point(35, 151);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(97, 24);
            this.btnRectangle.TabIndex = 5;
            this.btnRectangle.Text = "Прямоугольник";
            this.btnRectangle.UseVisualStyleBackColor = true;
            this.btnRectangle.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // btnSquare
            // 
            this.btnSquare.Location = new System.Drawing.Point(35, 181);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(97, 24);
            this.btnSquare.TabIndex = 6;
            this.btnSquare.Text = "Квадрат";
            this.btnSquare.UseVisualStyleBackColor = true;
            this.btnSquare.Click += new System.EventHandler(this.btnSquare_Click);
            // 
            // btnCircle
            // 
            this.btnCircle.Location = new System.Drawing.Point(35, 211);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(97, 24);
            this.btnCircle.TabIndex = 7;
            this.btnCircle.Text = "Круг";
            this.btnCircle.UseVisualStyleBackColor = true;
            this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // btnEllipse
            // 
            this.btnEllipse.Location = new System.Drawing.Point(35, 241);
            this.btnEllipse.Name = "btnEllipse";
            this.btnEllipse.Size = new System.Drawing.Size(97, 24);
            this.btnEllipse.TabIndex = 8;
            this.btnEllipse.Text = "Эллипс";
            this.btnEllipse.UseVisualStyleBackColor = true;
            this.btnEllipse.Click += new System.EventHandler(this.btnEllipse_Click);
            // 
            // btnTriangle
            // 
            this.btnTriangle.Location = new System.Drawing.Point(35, 271);
            this.btnTriangle.Name = "btnTriangle";
            this.btnTriangle.Size = new System.Drawing.Size(97, 24);
            this.btnTriangle.TabIndex = 9;
            this.btnTriangle.Text = "Треугольник";
            this.btnTriangle.UseVisualStyleBackColor = true;
            this.btnTriangle.Click += new System.EventHandler(this.btnTriangle_Click);
            // 
            // trackBarThickness
            // 
            this.trackBarThickness.Location = new System.Drawing.Point(13, 345);
            this.trackBarThickness.Maximum = 30;
            this.trackBarThickness.Minimum = 1;
            this.trackBarThickness.Name = "trackBarThickness";
            this.trackBarThickness.Size = new System.Drawing.Size(146, 45);
            this.trackBarThickness.TabIndex = 10;
            this.trackBarThickness.Value = 1;
            this.trackBarThickness.ValueChanged += new System.EventHandler(this.trackBarThickness_ValueChanged);
            // 
            // labelThickness
            // 
            this.labelThickness.AutoSize = true;
            this.labelThickness.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelThickness.Location = new System.Drawing.Point(32, 325);
            this.labelThickness.Name = "labelThickness";
            this.labelThickness.Size = new System.Drawing.Size(133, 17);
            this.labelThickness.TabIndex = 11;
            this.labelThickness.Text = "Толщина кисти = 7";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 450);
            this.Controls.Add(this.labelThickness);
            this.Controls.Add(this.trackBarThickness);
            this.Controls.Add(this.btnTriangle);
            this.Controls.Add(this.btnEllipse);
            this.Controls.Add(this.btnCircle);
            this.Controls.Add(this.btnSquare);
            this.Controls.Add(this.btnRectangle);
            this.Controls.Add(this.btnLine);
            this.Controls.Add(this.pBoxColor);
            this.Controls.Add(this.pBoxDrawing);
            this.Controls.Add(this.btnDraw);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxDrawing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarThickness)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.PictureBox pBoxDrawing;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PictureBox pBoxColor;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button btnRectangle;
        private System.Windows.Forms.Button btnSquare;
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.Button btnEllipse;
        private System.Windows.Forms.Button btnTriangle;
        private System.Windows.Forms.TrackBar trackBarThickness;
        private System.Windows.Forms.Label labelThickness;
    }
}

