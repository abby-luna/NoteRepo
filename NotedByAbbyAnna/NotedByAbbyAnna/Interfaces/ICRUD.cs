using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotedByAbbyAnna
{
    internal interface ICRUD
    {

        public void DeleteObj(int deleteID);
        public void UpdateObj(int updateID);
        public void NewObj();

        public void ExportObjToFile();
    }
}
