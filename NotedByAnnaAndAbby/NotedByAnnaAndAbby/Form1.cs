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
    public partial class Form1 : Form
    {

        List<Note> notes = new List<Note>();
        public Form1()
        {
            InitializeComponent();

            notes.Add(new Note(1, "Hello", "World"));
            notes.Add(new Note(2, "e", "World"));
            notes.Add(new Note(3, "q", "World"));
            notes.Add(new Note(4, "e", "World"));
            notes.Add(new Note(5, "w", "World"));
            notes.Add(new Note(6, "r", "World"));
            notes.Add(new Note(7, "t", "World"));
            notes.Add(new Note(8, "b", "World"));


            dataGridView1.DataSource = notes;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
