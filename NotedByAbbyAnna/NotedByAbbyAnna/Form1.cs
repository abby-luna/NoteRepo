using System.ComponentModel;

namespace NotedByAbbyAnna
{
    public partial class Form1 : Form
    {

        BindingList<Note> notes = new BindingList<Note>();
        BindingList<Note> allNotes = new BindingList<Note>();

        BindingList<Category> catogory = new BindingList<Category>() {
            new Category(1, "Personal Notes", Color.Black, Color.White),
            new Category(2, "Dont open Notes", Color.White, Color.Black),
            new Category(3, "Love Notes", Color.Red, Color.Green)

        };


        NoteCrud NC;

        const int CATEGORY = 0;
        const int MODIFY = 1;
        const int DELETE = 2;

        public Form1()
        {
            InitializeComponent();



            dataGridView1.DataSource = notes;

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

            NC = new NoteCrud(allNotes, catogory);

            renderVisbleNotes();

        }

        private void DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {


            for (int i = 0; i < notes.Count; i++)
            {
                if (e.RowIndex == i && e.ColumnIndex == CATEGORY)
                {
                    e.CellStyle.BackColor = notes[i].Cat.BackgroundColor;
                    e.CellStyle.ForeColor = notes[i].Cat.TextColor;
                    e.Value = notes[i].Cat.Text;
                }

            }

        }


        void renderVisbleNotes()
        {
            notes.Clear();
            foreach (Note note in allNotes)
            {
                if (note.Search(textBox1.Text))
                {
                    notes.Add(note);
                }
            }
            dataGridView1.Refresh();
            dataGridView1.ResetBindings();

        }




        private void Form1_Load(object sender, EventArgs e)
        {
            renderVisbleNotes();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int c = e.ColumnIndex;
            if (e.ColumnIndex == MODIFY || e.ColumnIndex == DELETE)
            {
                int ID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());

                if (e.ColumnIndex == MODIFY)
                {

                    NC.UpdateObj(ID);
                    renderVisbleNotes();

                }
                else if (e.ColumnIndex == DELETE)
                {

                    NC.DeleteObj(ID);
                    renderVisbleNotes();
                }

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            renderVisbleNotes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NC.NewObj();
            renderVisbleNotes();   
        }
    }
}