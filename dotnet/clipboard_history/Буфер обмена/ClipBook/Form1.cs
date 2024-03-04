using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;


namespace ClipBook
{
    public partial class Form1 : Form
    {
        Log log;
        Upload upload;
        string value = "";
        
        public Form1()
        {
            InitializeComponent();
            log = new Log();
            upload = new Upload();
            log.data = DateTime.Now;
            dateTimePicker1.Value = log.data;
            label_numberCount.Text = listBox_Clipbook.Items.Count.ToString();
            listBox_Clipbook.DataSource = log.Uploads;
          
        }

        void UpdateDataSource()
        {
           listBox_Clipbook.DataSource = null;
           listBox_Clipbook.DataSource = log.Uploads;
           label_numberCount.Text = listBox_Clipbook.Items.Count.ToString();

        }

        private void button_Cleaning_Click(object sender, EventArgs e)
        {
            log.Uploads.Clear();
            UpdateDataSource();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            XmlSerializer serializer = new XmlSerializer(typeof(List<Upload>));
            using (FileStream save = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate)) 
            {
                serializer.Serialize(save, log.Uploads);
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            log.Uploads.RemoveAt(listBox_Clipbook.SelectedIndex);
            UpdateDataSource();
        }

        private void button_Loading_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            XmlSerializer serializer = new XmlSerializer(typeof(List<Upload>));
            using (FileStream open = new FileStream(openFileDialog1.FileName, FileMode.OpenOrCreate))
            {
                log.Uploads = (List<Upload>)serializer.Deserialize(open);
            }
            UpdateDataSource();
        }


        private void button_Extraction_Click(object sender, EventArgs e)
        {
            Upload upload = new Upload();
            IDataObject iData = Clipboard.GetDataObject();

            if (iData.GetDataPresent(DataFormats.UnicodeText))
            {

                upload.text = (String)iData.GetData(DataFormats.UnicodeText);
            }
            else
            {
                upload.text = "не удалось извлечь данные из буфера обмена.";
            }
            upload.size = upload.text.Length * sizeof(char);
            upload.comment = "Комментарий";
            log.Uploads.Add(upload);
            UpdateDataSource();
        }

        private void button_Corect_Click(object sender, EventArgs e)
        {
            new Form2(log.Uploads[listBox_Clipbook.SelectedIndex]).Show();
            UpdateDataSource();
        }

        private int lastFoundIndex = -1;

        private void button_Search_Click_1(object sender, EventArgs e)
        {
            int i;
            for (i = lastFoundIndex + 1; i < listBox_Clipbook.Items.Count; i++)
            {
                var currVal = listBox_Clipbook.Items[i].ToString();
                if (currVal.ToLower().Contains(textBox.Text.ToLower()))
                {
                    listBox_Clipbook.SetSelected(i, true);
                    lastFoundIndex = i;
                    break;
                }
            }
            if (lastFoundIndex > -1 && i == listBox_Clipbook.Items.Count)
            {
                for (int s = 0; s <= lastFoundIndex; s++)
                {
                    var currVal = listBox_Clipbook.Items[s].ToString();
                    if (currVal.ToLower().Contains(textBox.Text.ToLower()))
                    {
                        listBox_Clipbook.SetSelected(s, true);
                        lastFoundIndex = s;
                        break;
                    }
                }
            }
        }
    }
}
