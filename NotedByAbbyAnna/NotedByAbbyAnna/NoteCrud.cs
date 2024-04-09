using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotedByAbbyAnna
{
    public class NoteCrud : ICRUD
    {
        private BindingList<Note> AllNotes;
        private BindingList<Category> AllCatogories;

        public NoteCrud(BindingList<Note> an, BindingList<Category> cats) 
        { 
            AllNotes = an;
            AllCatogories = cats;
        }
        public void DeleteObj(int deleteID)
        {
            for (int i = 0; i <AllNotes.Count;i++)
            {
                if (AllNotes[i].Id == deleteID)
                    AllNotes.RemoveAt(i);
            }
        }
        public void UpdateObj(int updateID)
        {

            Note update = new Note();
            foreach (Note note in AllNotes)
            {
                if (note.Id == updateID)
                    update = note;
            }
            CreateUpdateNote frm2 = new CreateUpdateNote(AllCatogories, update);
            DialogResult dr = frm2.ShowDialog();
            if (dr == DialogResult.Cancel)
            {
                frm2.Close();
            }
            else if (dr == DialogResult.OK)
            {
                //textBox1.Text = frm2.getText();

                update.Title = frm2.getTitle();
                update.Content = frm2.getContent();
                update.Cat = frm2.getCatogory();
                frm2.Close();


                return;


            }
            return;
        }

        public void NewObj()
        {
            CreateUpdateNote frm2 = new CreateUpdateNote(AllCatogories);
            DialogResult dr = frm2.ShowDialog();
            if (dr == DialogResult.Cancel)
            {
                frm2.Close();
            }
            else if (dr == DialogResult.OK)
            {
                //textBox1.Text = frm2.getText();

                Note t = new Note(frm2.getID(), frm2.getTitle(), frm2.getContent(), frm2.getCatogory());
                this.AllNotes.Add(t);

                frm2.Close();

            }
        }
    }
}
