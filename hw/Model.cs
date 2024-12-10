using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw
{
    internal class Model
    {
        public string fileName {  get; set; }


        public Model()
        {
            fileName = "books.txt";
        }

        public void Save(string content)
        {
            File.WriteAllText(fileName, content, Encoding.UTF8);
        }

        public string[] Load()
        {
            return File.ReadAllLines(fileName);
        }

        public void SaveLines(string[] lines)
        {
            File.WriteAllLines(fileName, lines);
        }

    }
}
