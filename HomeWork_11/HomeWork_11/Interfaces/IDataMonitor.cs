using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace HomeWork_11.Class
{
    interface IDataMonitor
    {
        /// <summary>
        /// Просмотр данных
        /// </summary>
        /// <param name="id"></param>
        void DataMonitor(int id, DataGrid dataGrid,string path);
    }
}
