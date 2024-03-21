using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotedByAnnaAndAbby
{
    internal interface ICRUD<T>
    {
        void Create();
        T Read(int Id);
        void Update(int Id);
        void Delete(int Id);
        
    }
}
