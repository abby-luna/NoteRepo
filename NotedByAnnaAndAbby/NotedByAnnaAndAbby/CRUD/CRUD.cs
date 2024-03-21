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
            foreach(T item in Items) 
            {
                if (item.GetId() == x.GetId()) 
                    throw new Exception(string.Format("Item with id {0} already exists", x.GetId()));
            }
            Items.Add(x);
        }

        public void Delete(int Id)
        {
            for(int i = 0; i < Items.Count; i++)
            {
                if (Items[i].GetId() == Id)
                {
                    Items.RemoveAt(i);
                    return;
                }
            }

            throw new Exception("Item does not exist");
          
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
            T updateItem = Read(Id);
            updateItem.UpdateObj();
            Items.ResetBindings();
        }

    }
}
