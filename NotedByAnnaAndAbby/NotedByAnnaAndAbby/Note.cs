using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotedByAnnaAndAbby
{
    internal class Note
    {
        public int Id { get; set; }
        public string Title { get; set; }
        protected string Content {  get; set; }


        public Note(int id, string title, string content)
        {
            Id = id;
            Title = title;
            Content = content;
        }
    }
}
