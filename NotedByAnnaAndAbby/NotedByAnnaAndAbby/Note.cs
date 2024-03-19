using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NotedByAnnaAndAbby
{
    public class Note : IContainsIdentity<Note>
    {
        public int Id { get; }
        public string Title { get; set; }
        public string Content {  get; set; }

        public Note()
        {
        }

        public Note(int id, string title, string content)
        {
            Id = id;
            Title = title;
            Content = content;
        }

        public int GetId()
        {
            return Id;
        }

        public Note NewNote()
        {
            CreateUpdateNote frm2 = new CreateUpdateNote();
            DialogResult dr = frm2.ShowDialog();
            if (dr == DialogResult.Cancel)
            {
                frm2.Close();
            }
            else if (dr == DialogResult.OK)
            {
                //textBox1.Text = frm2.getText();
                
                Note t = new Note(frm2.getID(), frm2.getTitle(), frm2.getContent());
                frm2.Close();
                return t;
                
            }
            throw new Exception("E");
        }
    }
}
