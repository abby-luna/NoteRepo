using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotedByAnnaAndAbby
{
    internal class CRUD<T> : ICRUD<T> where T : IContainsIdentity<T>, new() 
    {

        public BindingList<T> Items = new BindingList<T> ();
        public void Create()
        {
            T x = new T().NewObj();
            Items.Add(x);
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public T Read(int Id)
        {
            foreach(T i in Items)
            {
                if(i.GetId() == Id) return i;
            }
            throw new Exception("Note not found");
        }

        public void Update(int Id)
        {
            throw new NotImplementedException();
        }

    }
}
