using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_11.Class.Function
{
    class Bank
    {
       
        /// <summary>
        /// Хранилище клиентов
        /// </summary>
        public ObservableCollection<Clients> ListClients { get; set; } = new ObservableCollection<Clients>();

        
    }
}
