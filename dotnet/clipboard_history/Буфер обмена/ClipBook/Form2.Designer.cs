namespace ClipBook
{
    partial class Form2
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
            this.textBox_Conect = new System.Windows.Forms.TextBox();
            this.textBox_Comment = new System.Windows.Forms.TextBox();
            this.label_Conect = new System.Windows.Forms.Label();
            this.label_Comment = new System.Windows.Forms.Label();
            this.button_inClipbook = new System.Windows.Forms.Button();
            this.button_Editing = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_Conect
            // 
            this.textBox_Conect.Location = new System.Drawing.Point(83, 21);
            this.textBox_Conect.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Conect.Multiline = true;
            this.textBox_Conect.Name = "textBox_Conect";
            this.textBox_Conect.Size = new System.Drawing.Size(194, 67);
            this.textBox_Conect.TabIndex = 1;
            // 
            // textBox_Comment
            // 
            this.textBox_Comment.Location = new System.Drawing.Point(83, 99);
            this.textBox_Comment.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Comment.Multiline = true;
            this.textBox_Comment.Name = "textBox_Comment";
            this.textBox_Comment.Size = new System.Drawing.Size(194, 82);
            this.textBox_Comment.TabIndex = 2;
            // 
            // label_Conect
            // 
            this.label_Conect.AutoSize = true;
            this.label_Conect.Location = new System.Drawing.Point(8, 23);
            this.label_Conect.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Conect.Name = "label_Conect";
            this.label_Conect.Size = new System.Drawing.Size(72, 13);
            this.label_Conect.TabIndex = 3;
            this.label_Conect.Text = "Содержимое";
            // 
            // label_Comment
            // 
            this.label_Comment.AutoSize = true;
            this.label_Comment.Location = new System.Drawing.Point(4, 103);
            this.label_Comment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Comment.Name = "label_Comment";
            this.label_Comment.Size = new System.Drawing.Size(77, 13);
            this.label_Comment.TabIndex = 4;
            this.label_Comment.Text = "Комментарий";
            // 
            // button_inClipbook
            // 
            this.button_inClipbook.Location = new System.Drawing.Point(173, 203);
            this.button_inClipbook.Margin = new System.Windows.Forms.Padding(2);
            this.button_inClipbook.Name = "button_inClipbook";
            this.button_inClipbook.Size = new System.Drawing.Size(103, 23);
            this.button_inClipbook.TabIndex = 5;
            this.button_inClipbook.Text = "В буфер обмена";
            this.button_inClipbook.UseVisualStyleBackColor = true;
            this.button_inClipbook.Click += new System.EventHandler(this.button_inClipbook_Click);
            // 
            // button_Editing
            // 
            this.button_Editing.Location = new System.Drawing.Point(7, 203);
            this.button_Editing.Margin = new System.Windows.Forms.Padding(2);
            this.button_Editing.Name = "button_Editing";
            this.button_Editing.Size = new System.Drawing.Size(147, 23);
            this.button_Editing.TabIndex = 6;
            this.button_Editing.Text = "Редактировать выгрузку";
            this.button_Editing.UseVisualStyleBackColor = true;
            this.button_Editing.Click += new System.EventHandler(this.button_Editing_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 239);
            this.Controls.Add(this.button_Editing);
            this.Controls.Add(this.button_inClipbook);
            this.Controls.Add(this.label_Comment);
            this.Controls.Add(this.label_Conect);
            this.Controls.Add(this.textBox_Comment);
            this.Controls.Add(this.textBox_Conect);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Выгрузка";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Conect;
        private System.Windows.Forms.TextBox textBox_Comment;
        private System.Windows.Forms.Label label_Conect;
        private System.Windows.Forms.Label label_Comment;
        private System.Windows.Forms.Button button_inClipbook;
        private System.Windows.Forms.Button button_Editing;
    }
}