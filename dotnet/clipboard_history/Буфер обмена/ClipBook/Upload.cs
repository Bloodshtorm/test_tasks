using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClipBook
{
    public class Upload
    {


        public DateTime dataUpload = DateTime.Now;
        public string text;
        

        public double size;
        public string comment;

        public string Text_ { 
            get 
            {
                const int Max = 100;
                if (text.Length > Max) 
                {
                   text = text.Substring(0, Max);
                }
                return text; 
            } }
        public double Size_ { get { return size; } }
             public string Comment_ { get { return comment; } }

        public override string ToString()
        {
            return "Дата и время: " + dataUpload + ";" + "  Содержимое: " + text + ";" + "  Размер: " + size + " байт" + ";" + "  Комментарий: " + comment + ";";
        }
    }
}
