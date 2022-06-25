using HomeWork_11.Class;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace HomeWork_11.Interfaces
{
    interface IDataRemove
    {
        /// <summary>
        /// Удаление клиента из коллекции
        /// </summary>
        /// <param name="index"></param>
        /// <param name="data"></param>
        void DataRemove(int index, DataGrid dataGrid);
    }
}
