using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordUnscrambler
{
    class FileReader
    {
        public string[] Read(string filename)
        {
            // Change 2
            string[] fileText;

            try
            {
                fileText = File.ReadAllLines(filename);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return fileText;

        }
    }
}
