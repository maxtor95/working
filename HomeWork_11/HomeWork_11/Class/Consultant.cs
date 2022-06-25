using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace HomeWork_11.Class
{
    class Consultant:Worker
    {
        public override void DataMonitor(int id, DataGrid dataGrid, string path)
        {
            base.DataMonitor(id, dataGrid, path);
        }
        public override void DataEd(DataGrid dataGrid)
        {
            base.DataEd(dataGrid);
        }

    }
}
