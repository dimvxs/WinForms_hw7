using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw
{
    internal class Controller
    {
        Model model;

        public Controller(Model model)
        {
            this.model = model;
        }


        public void Add(string result) {

            try
            {
                File.WriteAllText(model.fileName, result, Encoding.UTF8);
                MessageBox.Show("Текст был сохранён в файл.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении: {ex.Message}");
            }
        }


        public void Remove(string removeData)
        {
            string[] lines = File.ReadAllLines(model.fileName);

            var updatedLines = lines.Where(line => !line.Equals(removeData, StringComparison.OrdinalIgnoreCase)).ToArray();


            // Если данные из формы были найдены и удалены, перезаписываем файл
            if (updatedLines.Length != lines.Length)
            {
                // Перезаписываем файл без удалённой строки
                File.WriteAllLines(model.fileName, updatedLines);

                MessageBox.Show("Строка удалена.");
            }
            else
            {
                MessageBox.Show("Совпадений не найдено.");
            }
        }

        public string FormatBook(string name, string author, string genre, string year)
        {
            return $"{name} {author} {genre} {year}";
        }


        public string showBooks()
        {
            string content = File.ReadAllText(model.fileName);

            return content;
     
         
        }


        public void clearValues(TextBox txt1, TextBox txt2, TextBox txt3, TextBox txt4)
        {
            txt1.Clear();
            txt2.Clear();
            txt3.Clear();
            txt4.Clear();
        }

    }
}
