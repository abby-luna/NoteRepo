using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotedByAnnaAndAbby
{
    public interface IContainsIdentity<T>
    {
        int GetId();
        T NewObj();
        void UpdateObj();

    }
}
