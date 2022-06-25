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
    interface IDataAdd
    {
        /// <summary>
        /// Добавление клиента в базу данных
        /// </summary>
        /// <param name="data"></param>
        /// <param name="dataGrid"></param>
        /// <param name="surname"></param>
        /// <param name="name"></param>
        /// <param name="lastname"></param>
        /// <param name="number"></param>
        /// <param name="passport"></param>
        void DataAdd(DataGrid dataGrid, string surname, string name, string lastname, string number, string passport);

    }
}
