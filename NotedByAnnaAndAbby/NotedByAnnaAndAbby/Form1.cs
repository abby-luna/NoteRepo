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

        const int MODIFY = 0;
        const int DELETE = 1;

        const int ID_COL = 2;

        public Form1()
        {
            InitializeComponent();
            BindingSource source = new BindingSource(crud.Items, null);
            dataGridView1.DataSource = source;

            var modifyColumn = new DataGridViewButtonColumn()
            {
                UseColumnTextForButtonValue = true,
                HeaderText = "Modify",
                Text = "Modify"
            };
            dataGridView1.Columns.Add(modifyColumn);

            // add column for delete button
            var deleteColumn = new DataGridViewButtonColumn()
            {
                UseColumnTextForButtonValue = true,
                HeaderText = "Delete",
                Text = "Delete"
            };
            dataGridView1.Columns.Add(deleteColumn);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            crud.Create();
            //dataGridView1.DataSource = crud.Items;
        }

        private void dataGridView1_CellContent(object sender, DataGridViewCellEventArgs e)
        {
            int c = e.ColumnIndex;
            if (e.ColumnIndex == MODIFY || e.ColumnIndex == DELETE)
            {
                int ID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[ID_COL].Value.ToString());

                if (e.ColumnIndex == MODIFY)
                {

                    crud.Update(ID);
                    
                }
                else if (e.ColumnIndex == DELETE)
                {
                    crud.Delete(ID);
                }

            }


        }
    }
}
