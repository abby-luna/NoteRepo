using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotedByAbbyAnna
{
    public class Note
    {

        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public Category Cat = new Category(888, "Hello", Color.AliceBlue, Color.Green);
        public Note() { }

        public Note(int id, string title, string content, Category c)
        {
            Id = id;
            Title = title;
            Content = content;
            Cat = c;    
        }

        public bool Search(string searchAgaint)
        {
            string searchTerm = string.Format("{0} {1} {2} {3}", Id, Title, Content, Cat.Text).ToLower();
            return searchTerm.Contains(searchAgaint.ToLower());
        }


    }
}
