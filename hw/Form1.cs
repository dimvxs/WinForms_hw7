using System.Xml.Linq;

namespace hw
{
    public partial class Form1 : Form
    {
        private Controller controller;
        public Form1()
        {
            InitializeComponent();
            controller = new Controller(new Model());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name, author, genre, year;

            name = textBox1.Text;
            author = textBox2.Text;
            genre = textBox3.Text;
            year = textBox4.Text;

            string result = controller.FormatBook(name, author, genre, year);
            controller.Remove(result);

            string books = controller.showBooks();
            textBox5.Text = books;

            controller.clearValues(textBox1, textBox2, textBox3, textBox4);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name, author, genre, year;

            name = textBox1.Text;
            author = textBox2.Text;
            genre = textBox3.Text;
            year = textBox4.Text;

            string result = controller.FormatBook(name, author, genre, year);
            controller.Add(result);

            string books = controller.showBooks();
            textBox5.Text = books;

            controller.clearValues(textBox1, textBox2, textBox3, textBox4);


        }
    }
}