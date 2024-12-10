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
                model.Save(result);
                MessageBox.Show("Текст был сохранён в файл.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении: {ex.Message}");
            }
        }


        public void Remove(string removeData)
        {
   
            var lines = model.Load();
            var updatedLines = lines.Where(line => !line.Equals(removeData, StringComparison.OrdinalIgnoreCase)).ToArray();


            // Если данные из формы были найдены и удалены, перезаписываем файл
            if (updatedLines.Length != lines.Length)
            {
                // Перезаписываем файл без удалённой строки

                model.SaveLines(updatedLines);

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


        public string ShowBooks()
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
