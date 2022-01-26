using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CA0120
{
    internal class WriterService
    {
        private string _path = @"C:\Users\utaki\Documents\Code\CA0120\CA0120\bin\Debug\net5.0\example2.txt";
        public WriterService()
        {
           
        }
        public void Write(string text, string text2)
        {
            using (StreamWriter sw = File.AppendText(_path))
            {
                sw.WriteLine(text, text2);
            }
        }
    }
}
