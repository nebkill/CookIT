
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookIT
{
    class LogHandler
    {
        string path = @"C:\CookIT\Log\log.txt";
        public void createDirectory()
        {
            string root = @"C:\CookIT\Log\";
            if (!Directory.Exists(root))
            {
                Directory.CreateDirectory(root);
            }
        }


        public void CreateLogFile()
        {

            if (!File.Exists(path))
            {
                try
                {
                    File.Create(path);
                    using (StreamWriter writer = new StreamWriter(path, true))
                    {

                        writer.WriteLine("[" + DateTime.Now.ToShortDateString() + " | " + DateTime.Now.ToLongTimeString() + "]");

                        writer.Flush();
                    }

                }
                catch (IOException io)
                {
                    AddLineToLog(io.Message);
                }
            }
            else if (File.Exists(path))
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter(path, true))
                    {

                        writer.WriteLine("[" + DateTime.Now.ToShortDateString() + " | " + DateTime.Now.ToLongTimeString() + "]");

                        writer.Flush();
                    }
                }
                catch (IOException io)
                {
                    AddLineToLog(io.Message);
                }
            }
        }
        public void AddLineToLog(string st)
        {
            if (File.Exists(path))
            {
                using (StreamWriter writer = new StreamWriter(path, true))
                {

                    writer.WriteLine("[" + DateTime.Now.ToShortDateString() + " | " + DateTime.Now.ToLongTimeString() + "] " + st);

                    writer.Flush();
                }
            }
            else if (!File.Exists(path))
            {
                CreateLogFile();
            }
        }
    }


}
