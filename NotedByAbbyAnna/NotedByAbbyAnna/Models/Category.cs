using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotedByAbbyAnna
{
    public class Category
    {

        public int ID { get; set; }
        public Color BackgroundColor;
        public Color TextColor;
        public string Text { get; set; }
        public Category()
        {

        }
        public Category(int id, string name, Color backgroundColor, Color textColor)
        {
            ID = id;
            BackgroundColor = backgroundColor;
            TextColor = textColor;
            Text = name;
        }
    }
}
