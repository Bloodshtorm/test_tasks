using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClipBook
{
    public partial class Form2 : Form
    {
        Upload upload;
        public Form2(Upload upload)
        {
            InitializeComponent();
            this.upload = upload;
            textBox_Conect.Text = upload.text;
            textBox_Comment.Text = upload.comment;
            
        }

        private void button_Editing_Click(object sender, EventArgs e)
        {
            upload.text = textBox_Conect.Text;
            upload.comment = textBox_Comment.Text;
            Close();
        }

        private void button_inClipbook_Click(object sender, EventArgs e)
        {
            if (textBox_Conect.Text != "")
            {
                Clipboard.SetDataObject(textBox_Conect.Text);
            }
           
        }
    }
}
