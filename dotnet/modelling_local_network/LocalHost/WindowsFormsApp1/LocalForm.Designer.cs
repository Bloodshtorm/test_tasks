
namespace WindowsFormsApp1
{
    partial class LocalForm
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
            this.listhost = new System.Windows.Forms.ListBox();
            this.ipnet = new System.Windows.Forms.TextBox();
            this.mask = new System.Windows.Forms.TextBox();
            this.gate = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.max = new System.Windows.Forms.Label();
            this.realhost = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listhost
            // 
            this.listhost.FormattingEnabled = true;
            this.listhost.Location = new System.Drawing.Point(12, 29);
            this.listhost.Name = "listhost";
            this.listhost.Size = new System.Drawing.Size(536, 264);
            this.listhost.TabIndex = 0;
            // 
            // ipnet
            // 
            this.ipnet.Location = new System.Drawing.Point(631, 15);
            this.ipnet.Name = "ipnet";
            this.ipnet.Size = new System.Drawing.Size(132, 20);
            this.ipnet.TabIndex = 1;
            // 
            // mask
            // 
            this.mask.Location = new System.Drawing.Point(631, 41);
            this.mask.Name = "mask";
            this.mask.Size = new System.Drawing.Size(132, 20);
            this.mask.TabIndex = 2;
            // 
            // gate
            // 
            this.gate.Location = new System.Drawing.Point(631, 70);
            this.gate.Name = "gate";
            this.gate.Size = new System.Drawing.Size(132, 20);
            this.gate.TabIndex = 3;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(557, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.add_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(696, 270);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.delete_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(688, 110);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Изменить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.change_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(558, 110);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Загрузить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.load_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(558, 147);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "Сохранить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.save_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(675, 147);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(88, 23);
            this.button6.TabIndex = 11;
            this.button6.Text = "О программе";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.About_Click);
            // 
            // max
            // 
            this.max.AutoSize = true;
            this.max.Location = new System.Drawing.Point(619, 231);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(35, 13);
            this.max.TabIndex = 12;
            this.max.Text = "label1";
            // 
            // realhost
            // 
            this.realhost.AutoSize = true;
            this.realhost.Location = new System.Drawing.Point(619, 205);
            this.realhost.Name = "realhost";
            this.realhost.Size = new System.Drawing.Size(35, 13);
            this.realhost.TabIndex = 13;
            this.realhost.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(555, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "IP address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(555, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Mask net";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(555, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Gate address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Hosts list";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(555, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "list count";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(555, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "max hosts";
            // 
            // LocalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 301);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.realhost);
            this.Controls.Add(this.max);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gate);
            this.Controls.Add(this.mask);
            this.Controls.Add(this.ipnet);
            this.Controls.Add(this.listhost);
            this.Name = "LocalForm";
            this.Text = "LocalHost";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listhost;
        private System.Windows.Forms.TextBox ipnet;
        private System.Windows.Forms.TextBox mask;
        private System.Windows.Forms.TextBox gate;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label max;
        private System.Windows.Forms.Label realhost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

