namespace Object_Redactor
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
            this.Classes_comboBox = new System.Windows.Forms.ComboBox();
            this.Info_flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.Add_button = new System.Windows.Forms.Button();
            this.Modify_button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.Save_button = new System.Windows.Forms.Button();
            this.List_Nember_label = new System.Windows.Forms.Label();
            this.List_Number_textBox = new System.Windows.Forms.TextBox();
            this.InfoObjects_flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.Classes_label = new System.Windows.Forms.Label();
            this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Serialization_comboBox = new System.Windows.Forms.ComboBox();
            this.Serialization_textBox = new System.Windows.Forms.TextBox();
            this.Serialization_filename_label = new System.Windows.Forms.Label();
            this.Deserialization_filename_label = new System.Windows.Forms.Label();
            this.Deserialization_textBox = new System.Windows.Forms.TextBox();
            this.Serialize_button = new System.Windows.Forms.Button();
            this.Deserialize_button = new System.Windows.Forms.Button();
            this.Decompress_button = new System.Windows.Forms.Button();
            this.Compress_button = new System.Windows.Forms.Button();
            this.Decompressed_label = new System.Windows.Forms.Label();
            this.Decompress_textBox = new System.Windows.Forms.TextBox();
            this.Compressed_filename_label = new System.Windows.Forms.Label();
            this.Compress_textBox = new System.Windows.Forms.TextBox();
            this.Plugin_comboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Classes_comboBox
            // 
            this.Classes_comboBox.Font = new System.Drawing.Font("Californian FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Classes_comboBox.FormattingEnabled = true;
            this.Classes_comboBox.Location = new System.Drawing.Point(740, 38);
            this.Classes_comboBox.Margin = new System.Windows.Forms.Padding(2);
            this.Classes_comboBox.Name = "Classes_comboBox";
            this.Classes_comboBox.Size = new System.Drawing.Size(201, 30);
            this.Classes_comboBox.TabIndex = 0;
            this.Classes_comboBox.Text = "Choose class";
            this.Classes_comboBox.SelectedIndexChanged += new System.EventHandler(this.Classes_comboBox_SelectedIndexChanged);
            // 
            // Info_flowLayoutPanel
            // 
            this.Info_flowLayoutPanel.AutoScroll = true;
            this.Info_flowLayoutPanel.AutoSize = true;
            this.Info_flowLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Info_flowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Info_flowLayoutPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Info_flowLayoutPanel.Location = new System.Drawing.Point(738, 87);
            this.Info_flowLayoutPanel.Margin = new System.Windows.Forms.Padding(10);
            this.Info_flowLayoutPanel.MaximumSize = new System.Drawing.Size(250, 415);
            this.Info_flowLayoutPanel.MinimumSize = new System.Drawing.Size(250, 415);
            this.Info_flowLayoutPanel.Name = "Info_flowLayoutPanel";
            this.Info_flowLayoutPanel.Size = new System.Drawing.Size(250, 415);
            this.Info_flowLayoutPanel.TabIndex = 2;
            this.Info_flowLayoutPanel.WrapContents = false;
            // 
            // Add_button
            // 
            this.Add_button.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add_button.Location = new System.Drawing.Point(741, 517);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(200, 37);
            this.Add_button.TabIndex = 4;
            this.Add_button.Text = "Add Object";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // Modify_button
            // 
            this.Modify_button.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Modify_button.Location = new System.Drawing.Point(50, 560);
            this.Modify_button.Name = "Modify_button";
            this.Modify_button.Size = new System.Drawing.Size(200, 37);
            this.Modify_button.TabIndex = 5;
            this.Modify_button.Text = "Modify Object";
            this.Modify_button.UseVisualStyleBackColor = true;
            this.Modify_button.Click += new System.EventHandler(this.Modify_button_Click);
            // 
            // Delete_button
            // 
            this.Delete_button.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete_button.Location = new System.Drawing.Point(489, 560);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(200, 37);
            this.Delete_button.TabIndex = 6;
            this.Delete_button.Text = "Delete Object";
            this.Delete_button.UseVisualStyleBackColor = true;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // Save_button
            // 
            this.Save_button.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Save_button.Location = new System.Drawing.Point(741, 560);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(200, 37);
            this.Save_button.TabIndex = 7;
            this.Save_button.Text = "Save object";
            this.Save_button.UseVisualStyleBackColor = true;
            this.Save_button.Visible = false;
            this.Save_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // List_Nember_label
            // 
            this.List_Nember_label.AutoSize = true;
            this.List_Nember_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.List_Nember_label.Location = new System.Drawing.Point(312, 537);
            this.List_Nember_label.Name = "List_Nember_label";
            this.List_Nember_label.Size = new System.Drawing.Size(108, 24);
            this.List_Nember_label.TabIndex = 8;
            this.List_Nember_label.Text = "List number";
            // 
            // List_Number_textBox
            // 
            this.List_Number_textBox.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.List_Number_textBox.Location = new System.Drawing.Point(271, 564);
            this.List_Number_textBox.Name = "List_Number_textBox";
            this.List_Number_textBox.Size = new System.Drawing.Size(200, 31);
            this.List_Number_textBox.TabIndex = 9;
            // 
            // InfoObjects_flowLayoutPanel
            // 
            this.InfoObjects_flowLayoutPanel.AutoScroll = true;
            this.InfoObjects_flowLayoutPanel.AutoSize = true;
            this.InfoObjects_flowLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.InfoObjects_flowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.InfoObjects_flowLayoutPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoObjects_flowLayoutPanel.Location = new System.Drawing.Point(83, 29);
            this.InfoObjects_flowLayoutPanel.Margin = new System.Windows.Forms.Padding(10);
            this.InfoObjects_flowLayoutPanel.MaximumSize = new System.Drawing.Size(600, 481);
            this.InfoObjects_flowLayoutPanel.MinimumSize = new System.Drawing.Size(600, 481);
            this.InfoObjects_flowLayoutPanel.Name = "InfoObjects_flowLayoutPanel";
            this.InfoObjects_flowLayoutPanel.Size = new System.Drawing.Size(600, 481);
            this.InfoObjects_flowLayoutPanel.TabIndex = 3;
            this.InfoObjects_flowLayoutPanel.WrapContents = false;
            // 
            // Classes_label
            // 
            this.Classes_label.AutoSize = true;
            this.Classes_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Classes_label.Location = new System.Drawing.Point(742, 38);
            this.Classes_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Classes_label.Name = "Classes_label";
            this.Classes_label.Size = new System.Drawing.Size(0, 24);
            this.Classes_label.TabIndex = 10;
            this.Classes_label.Visible = false;
            // 
            // OpenFileDialog1
            // 
            this.OpenFileDialog1.FileName = "openFileDialog";
            // 
            // Serialization_comboBox
            // 
            this.Serialization_comboBox.Font = new System.Drawing.Font("Californian FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Serialization_comboBox.FormattingEnabled = true;
            this.Serialization_comboBox.Location = new System.Drawing.Point(998, 38);
            this.Serialization_comboBox.Margin = new System.Windows.Forms.Padding(2);
            this.Serialization_comboBox.Name = "Serialization_comboBox";
            this.Serialization_comboBox.Size = new System.Drawing.Size(263, 30);
            this.Serialization_comboBox.TabIndex = 0;
            this.Serialization_comboBox.Text = "Choose serialization";
            // 
            // Serialization_textBox
            // 
            this.Serialization_textBox.Enabled = false;
            this.Serialization_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Serialization_textBox.Location = new System.Drawing.Point(996, 97);
            this.Serialization_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.Serialization_textBox.Multiline = true;
            this.Serialization_textBox.Name = "Serialization_textBox";
            this.Serialization_textBox.Size = new System.Drawing.Size(265, 50);
            this.Serialization_textBox.TabIndex = 12;
            // 
            // Serialization_filename_label
            // 
            this.Serialization_filename_label.AutoSize = true;
            this.Serialization_filename_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Serialization_filename_label.Location = new System.Drawing.Point(998, 71);
            this.Serialization_filename_label.Name = "Serialization_filename_label";
            this.Serialization_filename_label.Size = new System.Drawing.Size(186, 24);
            this.Serialization_filename_label.TabIndex = 13;
            this.Serialization_filename_label.Text = "Serialization filename";
            this.Serialization_filename_label.Click += new System.EventHandler(this.Serialization_filename_label_Click);
            // 
            // Deserialization_filename_label
            // 
            this.Deserialization_filename_label.AutoSize = true;
            this.Deserialization_filename_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Deserialization_filename_label.Location = new System.Drawing.Point(998, 193);
            this.Deserialization_filename_label.Name = "Deserialization_filename_label";
            this.Deserialization_filename_label.Size = new System.Drawing.Size(207, 24);
            this.Deserialization_filename_label.TabIndex = 15;
            this.Deserialization_filename_label.Text = "Deserialization filename";
            this.Deserialization_filename_label.Click += new System.EventHandler(this.Deserialization_filename_label_Click);
            // 
            // Deserialization_textBox
            // 
            this.Deserialization_textBox.Enabled = false;
            this.Deserialization_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Deserialization_textBox.Location = new System.Drawing.Point(998, 220);
            this.Deserialization_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.Deserialization_textBox.Multiline = true;
            this.Deserialization_textBox.Name = "Deserialization_textBox";
            this.Deserialization_textBox.Size = new System.Drawing.Size(264, 50);
            this.Deserialization_textBox.TabIndex = 14;
            // 
            // Serialize_button
            // 
            this.Serialize_button.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Serialize_button.Location = new System.Drawing.Point(998, 152);
            this.Serialize_button.Name = "Serialize_button";
            this.Serialize_button.Size = new System.Drawing.Size(264, 37);
            this.Serialize_button.TabIndex = 16;
            this.Serialize_button.Text = "Serialize";
            this.Serialize_button.UseVisualStyleBackColor = true;
            this.Serialize_button.Click += new System.EventHandler(this.Serialize_button_Click);
            // 
            // Deserialize_button
            // 
            this.Deserialize_button.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Deserialize_button.Location = new System.Drawing.Point(998, 275);
            this.Deserialize_button.Name = "Deserialize_button";
            this.Deserialize_button.Size = new System.Drawing.Size(264, 37);
            this.Deserialize_button.TabIndex = 17;
            this.Deserialize_button.Text = "Deserialize";
            this.Deserialize_button.UseVisualStyleBackColor = true;
            this.Deserialize_button.Click += new System.EventHandler(this.Deserialize_button_Click);
            // 
            // Decompress_button
            // 
            this.Decompress_button.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Decompress_button.Location = new System.Drawing.Point(997, 559);
            this.Decompress_button.Name = "Decompress_button";
            this.Decompress_button.Size = new System.Drawing.Size(264, 37);
            this.Decompress_button.TabIndex = 23;
            this.Decompress_button.Text = "Decompress";
            this.Decompress_button.UseVisualStyleBackColor = true;
            this.Decompress_button.Click += new System.EventHandler(this.Decompress_button_Click);
            // 
            // Compress_button
            // 
            this.Compress_button.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Compress_button.Location = new System.Drawing.Point(997, 439);
            this.Compress_button.Name = "Compress_button";
            this.Compress_button.Size = new System.Drawing.Size(264, 37);
            this.Compress_button.TabIndex = 22;
            this.Compress_button.Text = "Compress";
            this.Compress_button.UseVisualStyleBackColor = true;
            this.Compress_button.Click += new System.EventHandler(this.Compress_button_Click);
            // 
            // Decompressed_label
            // 
            this.Decompressed_label.AutoSize = true;
            this.Decompressed_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Decompressed_label.Location = new System.Drawing.Point(997, 478);
            this.Decompressed_label.Name = "Decompressed_label";
            this.Decompressed_label.Size = new System.Drawing.Size(215, 24);
            this.Decompressed_label.TabIndex = 21;
            this.Decompressed_label.Text = "Decompressed filename";
            this.Decompressed_label.Click += new System.EventHandler(this.Decompressed_label_Click);
            // 
            // Decompress_textBox
            // 
            this.Decompress_textBox.Enabled = false;
            this.Decompress_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Decompress_textBox.Location = new System.Drawing.Point(997, 504);
            this.Decompress_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.Decompress_textBox.Multiline = true;
            this.Decompress_textBox.Name = "Decompress_textBox";
            this.Decompress_textBox.Size = new System.Drawing.Size(264, 50);
            this.Decompress_textBox.TabIndex = 20;
            // 
            // Compressed_filename_label
            // 
            this.Compressed_filename_label.AutoSize = true;
            this.Compressed_filename_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Compressed_filename_label.Location = new System.Drawing.Point(997, 357);
            this.Compressed_filename_label.Name = "Compressed_filename_label";
            this.Compressed_filename_label.Size = new System.Drawing.Size(194, 24);
            this.Compressed_filename_label.TabIndex = 19;
            this.Compressed_filename_label.Text = "Compressed filename";
            this.Compressed_filename_label.Click += new System.EventHandler(this.Compressed_filename_label_Click);
            // 
            // Compress_textBox
            // 
            this.Compress_textBox.Enabled = false;
            this.Compress_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Compress_textBox.Location = new System.Drawing.Point(997, 384);
            this.Compress_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.Compress_textBox.Multiline = true;
            this.Compress_textBox.Name = "Compress_textBox";
            this.Compress_textBox.Size = new System.Drawing.Size(265, 50);
            this.Compress_textBox.TabIndex = 18;
            // 
            // Plugin_comboBox
            // 
            this.Plugin_comboBox.Font = new System.Drawing.Font("Californian FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Plugin_comboBox.FormattingEnabled = true;
            this.Plugin_comboBox.Location = new System.Drawing.Point(997, 325);
            this.Plugin_comboBox.Margin = new System.Windows.Forms.Padding(2);
            this.Plugin_comboBox.Name = "Plugin_comboBox";
            this.Plugin_comboBox.Size = new System.Drawing.Size(264, 30);
            this.Plugin_comboBox.TabIndex = 24;
            this.Plugin_comboBox.Text = "Choose plugin";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1274, 631);
            this.Controls.Add(this.Plugin_comboBox);
            this.Controls.Add(this.Decompress_button);
            this.Controls.Add(this.Compress_button);
            this.Controls.Add(this.Decompressed_label);
            this.Controls.Add(this.Decompress_textBox);
            this.Controls.Add(this.Compressed_filename_label);
            this.Controls.Add(this.Compress_textBox);
            this.Controls.Add(this.Deserialize_button);
            this.Controls.Add(this.Serialize_button);
            this.Controls.Add(this.Deserialization_filename_label);
            this.Controls.Add(this.Deserialization_textBox);
            this.Controls.Add(this.Serialization_filename_label);
            this.Controls.Add(this.Serialization_textBox);
            this.Controls.Add(this.Serialization_comboBox);
            this.Controls.Add(this.Classes_label);
            this.Controls.Add(this.InfoObjects_flowLayoutPanel);
            this.Controls.Add(this.List_Number_textBox);
            this.Controls.Add(this.List_Nember_label);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.Modify_button);
            this.Controls.Add(this.Info_flowLayoutPanel);
            this.Controls.Add(this.Classes_comboBox);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.Save_button);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(698, 448);
            this.Name = "Form1";
            this.Text = "Object Redactor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.FlowLayoutPanel Info_flowLayoutPanel;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.Label List_Nember_label;
        public System.Windows.Forms.FlowLayoutPanel InfoObjects_flowLayoutPanel;
        private System.Windows.Forms.Label Classes_label;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog1;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog1;
        public System.Windows.Forms.ComboBox Classes_comboBox;
        public System.Windows.Forms.Button Add_button;
        public System.Windows.Forms.Button Modify_button;
        public System.Windows.Forms.Button Delete_button;
        public System.Windows.Forms.TextBox List_Number_textBox;
        public System.Windows.Forms.ComboBox Serialization_comboBox;
        public System.Windows.Forms.TextBox Serialization_textBox;
        public System.Windows.Forms.Label Serialization_filename_label;
        public System.Windows.Forms.Label Deserialization_filename_label;
        public System.Windows.Forms.TextBox Deserialization_textBox;
        public System.Windows.Forms.Button Serialize_button;
        public System.Windows.Forms.Button Deserialize_button;
        public System.Windows.Forms.Button Decompress_button;
        public System.Windows.Forms.Button Compress_button;
        public System.Windows.Forms.Label Decompressed_label;
        public System.Windows.Forms.TextBox Decompress_textBox;
        public System.Windows.Forms.Label Compressed_filename_label;
        public System.Windows.Forms.TextBox Compress_textBox;
        public System.Windows.Forms.ComboBox Plugin_comboBox;
    }
}

