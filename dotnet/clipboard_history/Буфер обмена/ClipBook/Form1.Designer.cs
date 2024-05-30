namespace ClipBook
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
            this.listBox_Clipbook = new System.Windows.Forms.ListBox();
            this.label_Begining = new System.Windows.Forms.Label();
            this.label_Count = new System.Windows.Forms.Label();
            this.label_numberCount = new System.Windows.Forms.Label();
            this.button_Loading = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Cleaning = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button_Extraction = new System.Windows.Forms.Button();
            this.button_Corect = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button_Search = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox_Clipbook
            // 
            this.listBox_Clipbook.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox_Clipbook.FormattingEnabled = true;
            this.listBox_Clipbook.HorizontalScrollbar = true;
            this.listBox_Clipbook.Location = new System.Drawing.Point(8, 73);
            this.listBox_Clipbook.Margin = new System.Windows.Forms.Padding(2);
            this.listBox_Clipbook.Name = "listBox_Clipbook";
            this.listBox_Clipbook.ScrollAlwaysVisible = true;
            this.listBox_Clipbook.Size = new System.Drawing.Size(476, 381);
            this.listBox_Clipbook.TabIndex = 0;
            // 
            // label_Begining
            // 
            this.label_Begining.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Begining.AutoSize = true;
            this.label_Begining.Location = new System.Drawing.Point(8, 13);
            this.label_Begining.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Begining.Name = "label_Begining";
            this.label_Begining.Size = new System.Drawing.Size(120, 13);
            this.label_Begining.TabIndex = 1;
            this.label_Begining.Text = "Начало отслеживания";
            // 
            // label_Count
            // 
            this.label_Count.AutoSize = true;
            this.label_Count.Location = new System.Drawing.Point(8, 34);
            this.label_Count.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Count.Name = "label_Count";
            this.label_Count.Size = new System.Drawing.Size(92, 13);
            this.label_Count.TabIndex = 2;
            this.label_Count.Text = "Кол-во выгрузок";
            // 
            // label_numberCount
            // 
            this.label_numberCount.AutoSize = true;
            this.label_numberCount.Location = new System.Drawing.Point(139, 34);
            this.label_numberCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_numberCount.Name = "label_numberCount";
            this.label_numberCount.Size = new System.Drawing.Size(35, 13);
            this.label_numberCount.TabIndex = 4;
            this.label_numberCount.Text = "label4";
            // 
            // button_Loading
            // 
            this.button_Loading.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Loading.Location = new System.Drawing.Point(490, 99);
            this.button_Loading.Margin = new System.Windows.Forms.Padding(2);
            this.button_Loading.Name = "button_Loading";
            this.button_Loading.Size = new System.Drawing.Size(95, 27);
            this.button_Loading.TabIndex = 6;
            this.button_Loading.Text = "Загрузить лог";
            this.button_Loading.UseVisualStyleBackColor = true;
            this.button_Loading.Click += new System.EventHandler(this.button_Loading_Click);
            // 
            // button_Save
            // 
            this.button_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Save.Location = new System.Drawing.Point(490, 131);
            this.button_Save.Margin = new System.Windows.Forms.Padding(2);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(95, 26);
            this.button_Save.TabIndex = 7;
            this.button_Save.Text = "Сохранить лог";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_Cleaning
            // 
            this.button_Cleaning.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Cleaning.Location = new System.Drawing.Point(490, 219);
            this.button_Cleaning.Margin = new System.Windows.Forms.Padding(2);
            this.button_Cleaning.Name = "button_Cleaning";
            this.button_Cleaning.Size = new System.Drawing.Size(95, 25);
            this.button_Cleaning.TabIndex = 8;
            this.button_Cleaning.Text = "Очистить";
            this.button_Cleaning.UseVisualStyleBackColor = true;
            this.button_Cleaning.Click += new System.EventHandler(this.button_Cleaning_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Delete.Location = new System.Drawing.Point(490, 189);
            this.button_Delete.Margin = new System.Windows.Forms.Padding(2);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(95, 25);
            this.button_Delete.TabIndex = 9;
            this.button_Delete.Text = "Удалить";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button_Extraction
            // 
            this.button_Extraction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_Extraction.Location = new System.Drawing.Point(37, 479);
            this.button_Extraction.Margin = new System.Windows.Forms.Padding(2);
            this.button_Extraction.Name = "button_Extraction";
            this.button_Extraction.Size = new System.Drawing.Size(163, 25);
            this.button_Extraction.TabIndex = 13;
            this.button_Extraction.Text = "извлечь из буфера обмена";
            this.button_Extraction.UseVisualStyleBackColor = true;
            this.button_Extraction.Click += new System.EventHandler(this.button_Extraction_Click);
            // 
            // button_Corect
            // 
            this.button_Corect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Corect.Location = new System.Drawing.Point(490, 160);
            this.button_Corect.Margin = new System.Windows.Forms.Padding(2);
            this.button_Corect.Name = "button_Corect";
            this.button_Corect.Size = new System.Drawing.Size(95, 25);
            this.button_Corect.TabIndex = 16;
            this.button_Corect.Text = "Редактировать";
            this.button_Corect.UseVisualStyleBackColor = true;
            this.button_Corect.Click += new System.EventHandler(this.button_Corect_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(139, 13);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(181, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // button_Search
            // 
            this.button_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Search.Location = new System.Drawing.Point(351, 45);
            this.button_Search.Margin = new System.Windows.Forms.Padding(2);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(63, 25);
            this.button_Search.TabIndex = 17;
            this.button_Search.Text = "Поиск";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click_1);
            // 
            // textBox
            // 
            this.textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox.Location = new System.Drawing.Point(8, 49);
            this.textBox.Margin = new System.Windows.Forms.Padding(2);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(338, 20);
            this.textBox.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 524);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.button_Corect);
            this.Controls.Add(this.button_Extraction);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Cleaning);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.button_Loading);
            this.Controls.Add(this.label_numberCount);
            this.Controls.Add(this.label_Count);
            this.Controls.Add(this.label_Begining);
            this.Controls.Add(this.listBox_Clipbook);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(450, 370);
            this.Name = "Form1";
            this.Text = "Буфер обмена";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Clipbook;
        private System.Windows.Forms.Label label_Begining;
        private System.Windows.Forms.Label label_Count;
        private System.Windows.Forms.Label label_numberCount;
        private System.Windows.Forms.Button button_Loading;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Cleaning;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button_Extraction;
        private System.Windows.Forms.Button button_Corect;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.TextBox textBox;
    }
}

