using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotedByAnnaAndAbby
{
    internal class Catogory : IContainsIdentity<Note>
    {

        public int Id { get; }
        public Color TextColor { get; set; }
        public Color BackgroundColor { get; set; }
        public int GetId()
        {
            return Id;
        }

        public Note NewObj()
        {
            throw new NotImplementedException();
        }

        public void UpdateObj()
        {
            throw new NotImplementedException();
        }
    }
}
