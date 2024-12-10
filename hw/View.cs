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


            string result = controller.FormatBook(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            controller.Remove(result);

            string books = controller.ShowBooks();
            textBox5.Text = books;

            ClearTextBoxes();


        }

        private void button1_Click(object sender, EventArgs e)
        {



            string result = controller.FormatBook(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            controller.Add(result);

            string books = controller.ShowBooks();
            textBox5.Text = books;

            ClearTextBoxes();


        }

        private void ClearTextBoxes()
        {
            foreach (var textBox in new[] { textBox1, textBox2, textBox3, textBox4 })
            {
                textBox.Clear();
            }
        }

        private void ‚˚ıÓ‰ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ‰Ó·‡‚ËÚ¸ ÌË„ÛToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string result = controller.FormatBook(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            controller.Add(result);
        }

        private void Û‰‡ÎËÚ¸ ÌË„ÛToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string result = controller.FormatBook(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            controller.Remove(result);
        }

        private void Û‰‡ÎËÚ¸¬ÒÂ ÌË„ËToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller.RemoveAll();
        }

        private void ÔÓÍ‡Á‡Ú¸œÂ‚Û˛ ÌË„ÛToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller.ShowFirst();
        }
    }
}