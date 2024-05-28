using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;


namespace _240401_01.Utils
{
    public class ExportToFile
    {
        private const string dir = @"C:\Users\Gusta\OneDrive\Documentos\FACULDADE\Programação I\Arquivos";

        public static bool SaveToDelimitedTxt(string fileName, string fileContent)
        {
            string filePath = @$"{dir}\{fileName}";

            if(!System.IO.Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            using(StreamWriter sw = File.CreateText(filePath))
            {
                sw.Write(fileContent);
            }

            return true;
        }
    }
}