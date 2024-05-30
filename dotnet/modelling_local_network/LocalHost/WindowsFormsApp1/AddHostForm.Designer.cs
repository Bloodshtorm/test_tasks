
namespace WindowsFormsApp1
{
    partial class AddhostForm
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
            this.iphosttext = new System.Windows.Forms.TextBox();
            this.maadress = new System.Windows.Forms.TextBox();
            this.typeconnect = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // iphosttext
            // 
            this.iphosttext.Location = new System.Drawing.Point(12, 12);
            this.iphosttext.Name = "iphosttext";
            this.iphosttext.Size = new System.Drawing.Size(243, 20);
            this.iphosttext.TabIndex = 0;
            // 
            // maadress
            // 
            this.maadress.Location = new System.Drawing.Point(12, 38);
            this.maadress.Name = "maadress";
            this.maadress.Size = new System.Drawing.Size(243, 20);
            this.maadress.TabIndex = 1;
            // 
            // typeconnect
            // 
            this.typeconnect.FormattingEnabled = true;
            this.typeconnect.Items.AddRange(new object[] {
            "Проводной",
            "Беспроводной"});
            this.typeconnect.Location = new System.Drawing.Point(13, 65);
            this.typeconnect.Name = "typeconnect";
            this.typeconnect.Size = new System.Drawing.Size(242, 21);
            this.typeconnect.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.add_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(165, 157);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "По умолчанию";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.default_Click);
            // 
            // AddhostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 192);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.typeconnect);
            this.Controls.Add(this.maadress);
            this.Controls.Add(this.iphosttext);
            this.Name = "AddhostForm";
            this.Text = "AddHostForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox iphosttext;
        private System.Windows.Forms.TextBox maadress;
        private System.Windows.Forms.ComboBox typeconnect;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}