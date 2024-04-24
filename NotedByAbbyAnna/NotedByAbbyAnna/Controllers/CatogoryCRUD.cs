using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotedByAbbyAnna
{
    public class CatogoryCRUD : ICRUD
    {

        public BindingList<Category> AllCatogories { get; set; }

        public CatogoryCRUD(BindingList<Category> cats)
        {
            AllCatogories = cats;
        }
        public void DeleteObj(int deleteID)
        {
            for (int i = 0; i < AllCatogories.Count; i++)
            {
                if (AllCatogories[i].ID == deleteID)
                {
                    AllCatogories[i].ID = int.MaxValue;
                    AllCatogories[i].TextColor = Color.Black;
                    AllCatogories[i].BackgroundColor = Color.White;
                    AllCatogories[i].Text = "<DELETED CATOGORY>";
                    
                    // AllCatogories.RemoveAt(i);
                    ExportObjToFile();


                }
            }
        }

        public void NewObj()
        {
            CreateUpdateCatogory frm2 = new CreateUpdateCatogory(null, AllCatogories);
            DialogResult dr = frm2.ShowDialog();
            if (dr == DialogResult.Cancel)
            {
                frm2.Close();
            }
            else if (dr == DialogResult.OK)
            {


                //textBox1.Text = frm2.getText();
                Category t = new Category(frm2.getID(), frm2.getText(), frm2.bg, frm2.text);
                this.AllCatogories.Add(t);
                ExportObjToFile();

                frm2.Close();

            }
        }

        public void UpdateObj(int updateID)
        {
            Category update = new Category();
            foreach (Category cat in AllCatogories)
            {
                if (cat.ID == updateID)
                    update = cat;
            }
            CreateUpdateCatogory frm2 = new CreateUpdateCatogory(update);
            DialogResult dr = frm2.ShowDialog();
            if (dr == DialogResult.Cancel)
            {
                frm2.Close();
            }
            else if (dr == DialogResult.OK)
            {
                //textBox1.Text = frm2.getText();

                update.BackgroundColor = frm2.bg;
                update.Text = frm2.getText();
                update.TextColor = frm2.text;
                frm2.Close();
                ExportObjToFile();


                return;


            }
            return;
        }

        string convertColor(Color c)
        {
            return string.Format("{0},{1},{2},{3}", c.R, c.G, c.B, c.A);
        }
        Color convertColor(string s)
        {
            string[] cs = s.Split(',');
            return Color.FromArgb(int.Parse(cs[3]), int.Parse(cs[0]), int.Parse(cs[1]), int.Parse(cs[2]));

        }

        public void ExportObjToFile()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("EXPORT_CATOGORY.txt"))
                {

                    foreach(Category cat in AllCatogories) 
                    {
                        writer.WriteLine(string.Format("{0}\n{1}\n{2}\n{3}", cat.ID, cat.Text.Replace("\n", " "), convertColor(cat.TextColor), convertColor(cat.BackgroundColor)));

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
                string fileContent = File.ReadAllText("EXPORT_CATOGORY.txt");
                string[] fc = fileContent.Split("\n");

                for (int i = 0; i < fc.Length; i += 4)
                {

                    AllCatogories.Add(new Category(int.Parse(fc[i]), fc[i + 1], convertColor(fc[i + 3]), convertColor(fc[i + 2])));
                }

            }
            catch(Exception ex){
                //MessageBox.Show(ex.Message);
            }
        }
    }
}
