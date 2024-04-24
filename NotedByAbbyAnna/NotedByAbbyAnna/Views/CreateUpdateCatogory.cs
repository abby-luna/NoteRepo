using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NotedByAbbyAnna
{



    public partial class CreateUpdateCatogory : Form
    {

        public Color bg = Color.White;
        public Color text = Color.Black;

        BindingList<Category> AllCurrent;

        public int getID()
        {
            return int.Parse(this.textBox2.Text);
        }
        public string getText()
        {
            return textBox1.Text;
        }
        public CreateUpdateCatogory(Category c = null, BindingList<Category> allCurrent=null)
        {
            InitializeComponent();

            AllCurrent = allCurrent;
            if (c != null)
            {
                textBox2.Enabled = false;
                textBox2.Text = c.ID.ToString();
                bg = c.BackgroundColor;
                text = c.TextColor;
                textBox1.Text = c.Text;
            }

            button1.BackColor = bg;
            button2.BackColor = text;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = true;
            MyDialog.ShowHelp = true;
            MyDialog.Color = bg;

            // Update the text box color if the user clicks OK 
            if (MyDialog.ShowDialog() == DialogResult.OK)
                bg = MyDialog.Color;

            button1.BackColor = bg;


        }

        private void button2_Click(object sender, EventArgs e)
        {

            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = true;
            MyDialog.ShowHelp = true;
            MyDialog.Color = text;

            // Update the text box color if the user clicks OK 
            if (MyDialog.ShowDialog() == DialogResult.OK)
                text = MyDialog.Color;

            button2.BackColor = text;
        }

        public int Contrast(Color c1, Color c2)
        {
            // | R1 - R2 | + | G1 - G2 | + | B1 - B2 |
            int c = Math.Abs(c1.R - c2.R) + Math.Abs(c1.G - c2.G) + Math.Abs(c1.B - c2.B);

            return c;
        }
        private void button3_Click(object sender, EventArgs e)
        {

            try 
            {
                if (Contrast(bg, text) < 500)
                {
                    DialogResult r = MessageBox.Show("Bad Contrast\nContinue?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                    if (r != DialogResult.Yes)
                    {
                        return;

                    }


                }

                if (AllCurrent != null)
                {
                    foreach (Category c in AllCurrent)
                    {
                        if (c.ID == this.getID())
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
                MessageBox.Show("ID's MUST BE AN INT");

            }



        }
    }
}
