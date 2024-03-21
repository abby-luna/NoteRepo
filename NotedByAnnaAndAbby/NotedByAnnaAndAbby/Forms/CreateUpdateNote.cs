using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotedByAnnaAndAbby
{
    public partial class CreateUpdateNote : Form
    {
        public CreateUpdateNote(Note update = null)
        {
            InitializeComponent();

            button1.DialogResult = DialogResult.OK;

            if (update != null)
            {
                textBox1.Text = update.Id.ToString();
                textBox1.Enabled = false;

                textBox2.Text = update.Title;
                richTextBox1.Text = update.Content;

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

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
