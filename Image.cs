using System;
using System.Collections.Generic;
using System.IO.Enumeration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignerClientApplication
{
    public class Image
    {
        private string fileName;
        private string filePath;

        public Image() { }

        public Image(string fileName, string filePath)
        {
            this.fileName = fileName;
            this.filePath = filePath;
        }

        public string FileName
        {
            get { return fileName; }
            set { if(value != null)
                    fileName = value; }
        }

        public string FilePath
        {
            get { return filePath; }
            set { if(value != null)
                    filePath = value; }
        }


    }
}
