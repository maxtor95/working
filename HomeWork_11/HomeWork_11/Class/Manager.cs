using HomeWork_11.Class.Function;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace HomeWork_11.Class
{
    class Manager:Worker
    {
        public override void DataAdd(DataGrid dataGrid, string surname, string name, string lastname, string number, string passport)
        {
            base.DataAdd(dataGrid, surname, name, lastname, number, passport);
        }

        public override void DataRemove(int index, DataGrid dataGrid)
        {
            base.DataRemove(index, dataGrid);
        }

        public override void DataMonitor(int id, DataGrid dataGrid,string path)
        {
            base.DataMonitor(id,dataGrid,path);
        }

        public override void DataSave(string path)
        {
            base.DataSave(path);
        }



    }

}
