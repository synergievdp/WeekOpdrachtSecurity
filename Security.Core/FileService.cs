using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Security.Core
{
    public class FileService
    {
        public string ReadFile(string path)
        {
            StringBuilder sb = new();
            using(var reader = new StreamReader(path))
            {
                string line;
                while((line = reader.ReadLine()) != null)
                {
                    sb.AppendLine(line);
                }
            }

            return sb.ToString();
        }

        public void SaveFile(string input, string path)
        {
            using(var writer = new StreamWriter(path))
            {
                writer.Write(input);
            }
        }
    }
}
