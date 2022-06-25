using HomeWork_11.Class.Function;
using HomeWork_11.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace HomeWork_11.Class
{
    class Worker : IDataAdd,IDataRemove,IDataMonitor,IDataSave,IDataEdit
    {


        Bank bank = new Bank();







        public virtual void DataAdd(DataGrid dataGrid,string surname,string name,string lastname,string number,string passport)
        {
            bank.ListClients.Add(new Clients(surname,name,lastname,number,passport));
            dataGrid.ItemsSource = bank.ListClients;
        }

        public virtual void DataEd(DataGrid dataGrid)
        {
            Bank bank = (Bank)dataGrid.SelectedItem;
            dataGrid.Columns[0].IsReadOnly = true;
            dataGrid.Columns[1].IsReadOnly = true;
            dataGrid.Columns[2].IsReadOnly = true;
            dataGrid.Columns[4].IsReadOnly = true;

        }

        public virtual void DataEdit(TextBox t1, TextBox t2, TextBox t3, TextBox t4)
        {
            t1.IsEnabled = false;
            t2.IsEnabled = false;
            t3.IsEnabled = false;
            t4.IsEnabled = false;

        }

        

        public virtual void DataMonitor(int id,DataGrid dataGrid,string path)
        {
            Clients.idrole = id;
            try
            {
                string readfile = File.ReadAllText(path);
                bank.ListClients = JsonConvert.DeserializeObject<ObservableCollection<Clients>>(readfile);
                dataGrid.ItemsSource = bank.ListClients;
            }
            catch (Exception)
            {
                return;
            }
            
        }




        public virtual void DataRemove(int index, DataGrid dataGrid)
        {
            try
            {
                index = dataGrid.SelectedIndex;
                bank.ListClients.RemoveAt(index);
            }
            catch (Exception)
            {
                return;
            }
            
        }

        public virtual void DataSave(string path)
        {

            string json = JsonConvert.SerializeObject(bank.ListClients);
            File.WriteAllText(path, json);
            MessageBox.Show("Данные успешно сохранены!", "Внимание!");
           
        }

      
        
    }
}
