using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NotedByAbbyAnna
{
    public partial class CreateUpdateNote : Form
    {
        BindingList<Note> AllCurrent = new BindingList<Note>();

        BindingList<Category> Cats = new BindingList<Category>();

        public CreateUpdateNote(BindingList<Category> catagories, Note update = null, BindingList<Note> allCurrent = null)
        {
            InitializeComponent();

            Cats = catagories;

            BindingList<Category> data = new BindingList<Category>();
            data.Add(new Category(999, "No Catogory", Color.White, Color.Black));

            for (int i = 0; i < Cats.Count; i++)
            {
                if (Cats[i].ID != int.MaxValue)
                {
                    data.Add(Cats[i]);
                }
            }



            comboBox1.DataSource = data;
            comboBox1.DisplayMember = "Text";

            AllCurrent = allCurrent;

            if (update != null)
            {
                textBox1.Text = update.Id.ToString();
                textBox1.Enabled = false;

                textBox2.Text = update.Title;
                richTextBox1.Text = update.Content;

                comboBox1.SelectedIndex = comboBox1.Items.IndexOf(update.Cat);


            }

        }

        public int getID()
        {


            return int.Parse(this.textBox1.Text);
        }

        public string getTitle()
        {
            return this.textBox2.Text;
        }

        public string getContent()
        {
            return this.richTextBox1.Text;
        }

        public Category getCatogory()
        {

            return (Category)this.comboBox1.SelectedItem;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (AllCurrent != null)
                {
                    foreach (Note note in AllCurrent)
                    {
                        if (note.Id == this.getID())
                        {
                            MessageBox.Show("ID's HAVE TO BE UNIQUE");
                            return;
                        }
                    }
                }

                DialogResult = DialogResult.OK;

            }
            catch
            {

                MessageBox.Show("ID must be an interger");
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
