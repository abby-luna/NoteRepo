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

        CRUD<Note> crud = new CRUD<Note>();

        public Form1()
        {
            InitializeComponent();
            BindingSource source = new BindingSource(crud.Items, null);
            dataGridView1.DataSource = source;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            crud.Create();
            //dataGridView1.DataSource = crud.Items;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
