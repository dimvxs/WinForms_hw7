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
            string[] parts = textBox5.Text.Split(' ');


            if (parts.Length == 4)
            {
                string name = parts[0];
                string author = parts[1]; 
                string genre = parts[2];   
                string year = parts[3];
                string result = controller.FormatBook(name, author, genre, year);
                controller.Remove(result);
            }


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


        }
    }
}