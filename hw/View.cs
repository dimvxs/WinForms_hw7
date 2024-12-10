using System.Xml.Linq;

namespace hw
{
    public partial class View : Form
    {
        private Controller controller;
        public View()
        {
            InitializeComponent();
            controller = new Controller(new Model());
        }

        private void button2_Click(object sender, EventArgs e)
        {


            string result = controller.FormatBook(name.Text, author.Text, genre.Text, year.Text);
            controller.Remove(result);

            string books = controller.ShowBooks();
            textBox5.Text = books;

            ClearTextBoxes();


        }

        private void button1_Click(object sender, EventArgs e)
        {



            string result = controller.FormatBook(name.Text, author.Text, genre.Text, year.Text);
            controller.Add(result);

            string books = controller.ShowBooks();
            textBox5.Text = books;

            ClearTextBoxes();


        }

        private void ClearTextBoxes()
        {
            foreach (var textBox in new[] { name, author, genre, year })
            {
                textBox.Clear();
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string result = controller.FormatBook(name.Text, author.Text, genre.Text, year.Text);
            controller.Add(result);
        }

        private void DeleteBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string result = controller.FormatBook(name.Text, author.Text, genre.Text, year.Text);
            controller.Remove(result);

            string books = controller.ShowBooks();
            textBox5.Text = books;
        }

        private void DeleteAllBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller.RemoveAll();

            string books = controller.ShowBooks();
            textBox5.Text = books;
        }

        private void ShowFirstBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller.ShowFirst();
        }
    }
}