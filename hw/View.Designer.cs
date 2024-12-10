namespace hw
{
    partial class View
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            name = new TextBox();
            author = new TextBox();
            genre = new TextBox();
            year = new TextBox();
            textBox5 = new TextBox();
            menuStrip1 = new MenuStrip();
            менюToolStripMenuItem = new ToolStripMenuItem();
            AddBookToolStripMenuItem = new ToolStripMenuItem();
            ShowFirstBookToolStripMenuItem = new ToolStripMenuItem();
            DeleteBookToolStripMenuItem = new ToolStripMenuItem();
            DeleteAllBooksToolStripMenuItem = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 37);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 0;
            label1.Text = "Название книги:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 77);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 1;
            label2.Text = "Автор книги:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 117);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 2;
            label3.Text = "Жанр:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 156);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 3;
            label4.Text = "Год издания:";
            // 
            // button1
            // 
            button1.Location = new Point(62, 269);
            button1.Name = "button1";
            button1.Size = new Size(152, 54);
            button1.TabIndex = 4;
            button1.Text = "Сохранить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(310, 269);
            button2.Name = "button2";
            button2.Size = new Size(152, 54);
            button2.TabIndex = 5;
            button2.Text = "Удалить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // name
            // 
            name.Location = new Point(147, 34);
            name.Name = "name";
            name.Size = new Size(185, 23);
            name.TabIndex = 6;
            // 
            // author
            // 
            author.Location = new Point(147, 74);
            author.Name = "author";
            author.Size = new Size(185, 23);
            author.TabIndex = 7;
            // 
            // genre
            // 
            genre.Location = new Point(147, 114);
            genre.Name = "genre";
            genre.Size = new Size(185, 23);
            genre.TabIndex = 8;
            // 
            // year
            // 
            year.Location = new Point(147, 156);
            year.Name = "year";
            year.Size = new Size(81, 23);
            year.TabIndex = 9;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(496, 34);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(292, 228);
            textBox5.TabIndex = 10;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { менюToolStripMenuItem, выходToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 11;
            menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            менюToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AddBookToolStripMenuItem, ShowFirstBookToolStripMenuItem, DeleteBookToolStripMenuItem, DeleteAllBooksToolStripMenuItem });
            менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            менюToolStripMenuItem.Size = new Size(53, 20);
            менюToolStripMenuItem.Text = "Меню";
            // 
            // AddBookToolStripMenuItem
            // 
            AddBookToolStripMenuItem.Image = (Image)resources.GetObject("AddBookToolStripMenuItem.Image");
            AddBookToolStripMenuItem.Name = "AddBookToolStripMenuItem";
            AddBookToolStripMenuItem.Size = new Size(203, 22);
            AddBookToolStripMenuItem.Text = "Добавить книгу";
            AddBookToolStripMenuItem.Click += AddBookToolStripMenuItem_Click;
            // 
            // ShowFirstBookToolStripMenuItem
            // 
            ShowFirstBookToolStripMenuItem.Image = (Image)resources.GetObject("ShowFirstBookToolStripMenuItem.Image");
            ShowFirstBookToolStripMenuItem.Name = "ShowFirstBookToolStripMenuItem";
            ShowFirstBookToolStripMenuItem.Size = new Size(203, 22);
            ShowFirstBookToolStripMenuItem.Text = "Показать первую книгу";
            ShowFirstBookToolStripMenuItem.Click += ShowFirstBookToolStripMenuItem_Click;
            // 
            // DeleteBookToolStripMenuItem
            // 
            DeleteBookToolStripMenuItem.Image = (Image)resources.GetObject("DeleteBookToolStripMenuItem.Image");
            DeleteBookToolStripMenuItem.Name = "DeleteBookToolStripMenuItem";
            DeleteBookToolStripMenuItem.Size = new Size(203, 22);
            DeleteBookToolStripMenuItem.Text = "Удалить книгу";
            DeleteBookToolStripMenuItem.Click += DeleteBookToolStripMenuItem_Click;
            // 
            // DeleteAllBooksToolStripMenuItem
            // 
            DeleteAllBooksToolStripMenuItem.Image = (Image)resources.GetObject("DeleteAllBooksToolStripMenuItem.Image");
            DeleteAllBooksToolStripMenuItem.Name = "DeleteAllBooksToolStripMenuItem";
            DeleteAllBooksToolStripMenuItem.Size = new Size(203, 22);
            DeleteAllBooksToolStripMenuItem.Text = "Удалить все книги";
            DeleteAllBooksToolStripMenuItem.Click += DeleteAllBooksToolStripMenuItem_Click;
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(54, 20);
            выходToolStripMenuItem.Text = "Выход";
            выходToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
            // 
            // View
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox5);
            Controls.Add(year);
            Controls.Add(genre);
            Controls.Add(author);
            Controls.Add(name);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Cursor = Cursors.Hand;
            MainMenuStrip = menuStrip1;
            Name = "View";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
        private TextBox name;
        private TextBox author;
        private TextBox genre;
        private TextBox year;
        private TextBox textBox5;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem менюToolStripMenuItem;
        private ToolStripMenuItem AddBookToolStripMenuItem;
        private ToolStripMenuItem ShowFirstBookToolStripMenuItem;
        private ToolStripMenuItem DeleteBookToolStripMenuItem;
        private ToolStripMenuItem DeleteAllBooksToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
    }
}