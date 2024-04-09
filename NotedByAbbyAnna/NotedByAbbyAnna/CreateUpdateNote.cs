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

        BindingList<Category> Cats = new BindingList<Category>();

        public CreateUpdateNote(BindingList<Category> catagories, Note update = null)
        {
            InitializeComponent();

            button1.DialogResult = DialogResult.OK;
            Cats = catagories;
            if (update != null)
            {
                textBox1.Text = update.Id.ToString();
                textBox1.Enabled = false;

                textBox2.Text = update.Title;
                richTextBox1.Text = update.Content;

            }
            comboBox1.DataSource = Cats;
            comboBox1.DisplayMember = "Text";
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

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
