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
            this.BtnDraw = new System.Windows.Forms.Button();
            this.pBoxDrawing = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxDrawing)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnDraw
            // 
            this.BtnDraw.Location = new System.Drawing.Point(12, 10);
            this.BtnDraw.Name = "BtnDraw";
            this.BtnDraw.Size = new System.Drawing.Size(80, 25);
            this.BtnDraw.TabIndex = 0;
            this.BtnDraw.Text = "Нарисовать";
            this.BtnDraw.UseVisualStyleBackColor = true;
            this.BtnDraw.Click += new System.EventHandler(this.BtnDraw_Click);
            // 
            // pBoxDrawing
            // 
            this.pBoxDrawing.Location = new System.Drawing.Point(105, 12);
            this.pBoxDrawing.Name = "pBoxDrawing";
            this.pBoxDrawing.Size = new System.Drawing.Size(634, 277);
            this.pBoxDrawing.TabIndex = 2;
            this.pBoxDrawing.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pBoxDrawing);
            this.Controls.Add(this.BtnDraw);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxDrawing)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnDraw;
        private System.Windows.Forms.PictureBox pBoxDrawing;
    }
}

