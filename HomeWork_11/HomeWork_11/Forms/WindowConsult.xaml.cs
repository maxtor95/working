using HomeWork_11.Class;
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

namespace HomeWork_11.Forms
{
    /// <summary>
    /// Логика взаимодействия для WindowConsult.xaml
    /// </summary>
    public partial class WindowConsult : Window
    {
        Consultant consultant = new Consultant();
        public WindowConsult()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            consultant.DataMonitor(5, dglistbankconsult,"ListPerson.json");
            consultant.DataEd(dglistbankconsult);
            consultant.DataEdit(tblastname,tbname,tbsurname,tbpasport);

        }

        private void btsave_Click(object sender, RoutedEventArgs e)
        {

           // consultant.DataSave();
        }
    }
}
