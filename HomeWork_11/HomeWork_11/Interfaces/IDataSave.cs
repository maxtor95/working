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
    interface IDataSave
    {

        /// <summary>
        /// Сохранение в коллекцию и запись
        /// </summary>
        void DataSave(string path);
       
    }
}
