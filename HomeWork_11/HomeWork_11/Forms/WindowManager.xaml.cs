using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using HomeWork_11.Class.Function;
using HomeWork_11.Class;
using Newtonsoft.Json;
using System.IO;

namespace HomeWork_11.Forms
{
    /// <summary>
    /// Логика взаимодействия для WindowManager.xaml
    /// </summary>
    public partial class WindowManager : Window
    {

        Manager manager = new Manager();
        Bank bank = new Bank();
        BankDepartaments bankDepartaments = new BankDepartaments();
 



        public WindowManager()
        {
            InitializeComponent();
        }

        private void btadd_Click(object sender, RoutedEventArgs e)
        {
            manager.DataAdd(dglistbankmanager,tbsurname.Text,tbname.Text,tblastname.Text,tbnumber.Text,tbpasport.Text);
 
        }

        private void btdell_Click(object sender, RoutedEventArgs e)
        {
            int i = dglistbankmanager.SelectedIndex;
            manager.DataRemove(i,dglistbankmanager);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            manager.DataMonitor(1, dglistbankmanager, "ListPerson.json");
        }

        private void btsave_Click(object sender, RoutedEventArgs e)
        {


            var s = cbdeparts.SelectedItem;
            switch (s)
            {
                case "Департамент 1":
                    string json = JsonConvert.SerializeObject(dglistbankmanager.Items);
                    File.WriteAllText("ListPerson.json", json);
                    MessageBox.Show("Данные успешно сохранены!", "Внимание!");

                    break;

                case "Департамент 2":
                    string json1 = JsonConvert.SerializeObject(dglistbankmanager.Items);
                    File.WriteAllText("ListPerson1.json", json1);
                    MessageBox.Show("Данные успешно сохранены!", "Внимание!");

                    break;

                case "Департамент 3":
                    string json2 = JsonConvert.SerializeObject(dglistbankmanager.Items);
                    File.WriteAllText("ListPerson2.json", json2);
                    MessageBox.Show("Данные успешно сохранены!", "Внимание!");
                    break;
                default:
                    break;
            }

        }

   

        private void cbdeparts_Loaded(object sender, RoutedEventArgs e)
        {
            bankDepartaments.nameDeparts.Add(new NameDeparts("Департамент 1"));
            bankDepartaments.nameDeparts.Add(new NameDeparts("Департамент 2"));
            bankDepartaments.nameDeparts.Add(new NameDeparts("Департамент 3"));
            foreach (var item in bankDepartaments.nameDeparts)
            {
                cbdeparts.Items.Add(item.Name);
            }

        }

        private void cbdeparts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var s = cbdeparts.SelectedItem;
            switch (s)
            {
                case "Департамент 1":
                    manager.DataMonitor(1, dglistbankmanager, "ListPerson.json");
                    break;

                case "Департамент 2":
                  
                    manager.DataMonitor(1, dglistbankmanager, "ListPerson1.json");
                    break;

                case "Департамент 3":
                    manager.DataMonitor(1, dglistbankmanager, "ListPerson2.json");
                    break;


                default:
                    break;
            }
        }
    }
}
