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
            ExportObjToFile();
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
                ExportObjToFile();
                frm2.Close();


                return;


            }
            return;
        }

        public void NewObj()
        {
            CreateUpdateNote frm2 = new CreateUpdateNote(AllCatogories, null, AllNotes);
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
                ExportObjToFile();

                frm2.Close();

            }
        }


        string Sanatize(string s)
        {
            return s.Replace("\n", "<NEWLINECHAR>");
        }

        string Unsanatize(string s)
        {
            return s.Replace("<NEWLINECHAR>", "\n");

        }
        public void ExportObjToFile()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("EXPORT_NOTE.txt"))
                {

                    foreach (Note n in AllNotes)
                    {
                        writer.WriteLine(string.Format("{0}\n{1}\n{2}\n{3}", n.Id, Sanatize(n.Title), Sanatize(n.Content), n.Cat.ID));

                    }
                }
            }
            catch (Exception ex)
            {
            }
        }

        public void ImportObjFromFile()
        {
            try 
            {

                // Note t = new Note(frm2.getID(), frm2.getTitle(), frm2.getContent(), frm2.getCatogory());
                string fileContent = File.ReadAllText("EXPORT_NOTE.txt");
                string[] fc = fileContent.Split("\n");

                for (int i = 0; i < fc.Length; i += 4)
                {
                    Category cat = new Category();
                    foreach (Category c in AllCatogories)
                    {
                        if (int.Parse(fc[i + 3]) == c.ID)
                        {
                            cat = c;
                        }
                    }

                    AllNotes.Add(new Note(int.Parse(fc[i]), Unsanatize(fc[i + 1]), Unsanatize(fc[i + 2]), cat));
                }

            }
            catch
            { }

        }
    }
}
