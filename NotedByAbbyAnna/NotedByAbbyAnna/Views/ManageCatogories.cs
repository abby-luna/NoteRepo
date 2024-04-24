using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NotedByAbbyAnna
{
    public partial class ManageCatogories : Form
    {

        public CatogoryCRUD CC;
        BindingList<Category> Rendered = new BindingList<Category>();


        const int CATEGORY = 0;
        const int MODIFY = 1;
        const int DELETE = 2;
        const int ID_LOCATION = 3;




        public ManageCatogories(CatogoryCRUD existing)
        {
            InitializeComponent();
            CC = existing;

            button2.DialogResult = DialogResult.OK;


            dataGridView1.DataSource = Rendered;

            var catColumn = new DataGridViewTextBoxColumn()
            {
                HeaderText = "Catogory"
            };


            dataGridView1.Columns.Add(catColumn);

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

            dataGridView1.CellFormatting += DataGridView1_CellFormatting;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            renderCatogories();

        }

        private void renderCatogories()
        {

            this.Rendered.Clear();
            foreach (Category c in CC.AllCatogories)
            {
                if (c.ID != int.MaxValue)
                {
                    this.Rendered.Add(c);

                }

            }
            dataGridView1.Refresh();
            dataGridView1.ResetBindings();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            CC.NewObj();
            renderCatogories();
        }


        private void DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            /*            for (int i = 0; i < CC.AllCatogories.Count; i++)
                        {
                            if (e.RowIndex == i && e.ColumnIndex == CATEGORY)
                            {

                                if (CC.AllCatogories[i].ID != int.MaxValue)
                                {
                                    e.CellStyle.BackColor = CC.AllCatogories[i].BackgroundColor;
                                    e.CellStyle.ForeColor = CC.AllCatogories[i].TextColor;
                                    e.Value = CC.AllCatogories[i].Text;
                                }


                            }

                        }*/

            if (e.ColumnIndex == CATEGORY)
            {
                try
                {
                    int ID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[ID_LOCATION].Value.ToString());

                    Category display = new Category();

                    foreach (Category c in CC.AllCatogories)
                    {
                        if (c.ID == ID)
                        {
                            display = c;
                        }
                    }
                    if (display != null)
                    {
                        e.CellStyle.BackColor = display.BackgroundColor;
                        e.CellStyle.ForeColor = display.TextColor;
                        e.Value = display.Text;
                    }
                }
                catch { }


            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int c = e.ColumnIndex;
            // MessageBox.Show(c.ToString());
            if (e.ColumnIndex == MODIFY || e.ColumnIndex == DELETE)
            {
                int ID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[ID_LOCATION].Value.ToString());

                if (e.ColumnIndex == MODIFY)
                {

                    CC.UpdateObj(ID);
                    renderCatogories();

                }
                else if (e.ColumnIndex == DELETE)
                {

                    CC.DeleteObj(ID);
                    renderCatogories();
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
