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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Windows.Threading;
using System.Windows.Forms;
using System.Drawing;
using System.Data;


namespace NotificationBotV1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {//Включение иконки для трея
        
        NotifyIcon notify = new NotifyIcon();
        
        public MainWindow()
        {
            InitializeComponent();
            // Метод для таймера в котором задается время сработки метода
            Traymenu();
            notify.Icon = new Icon(@"S:\Пользователи\Прапорщики\Хаустов\Temp!\ICON\icon.ico");
            Start_Timer();
          
            
            
        }

        public void Start_Timer()
        {
            DispatcherTimer dt = new DispatcherTimer();
            dt.Tick += new EventHandler(Tick);
            dt.Interval = new TimeSpan(0, 5, 0);
            dt.Start();
        }

        public void Stop_Timer()
        {
            DispatcherTimer dt = new DispatcherTimer();
            dt.Tick += new EventHandler(Tick);
            dt.Interval = new TimeSpan(0, 0, 1);
            dt.Stop();
        }

        // Метод таймера с SQL запросом
        public async void Tick(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=SQL-SERVER;Initial Catalog=WebInfo;Integrated Security=True";
            SqlConnection sqlconnection = new SqlConnection(connectionString);
            await sqlconnection.OpenAsync();
            SqlDataReader sqlDataReader = null;
            SqlCommand sqlCommand = new SqlCommand("SELECT TOP 1 * FROM [WebInfo].[Notice].[List] ORDER BY Registration DESC", sqlconnection);
            SqlCommand cmd = new SqlCommand("[Notice].[SelectNoReadUsers]", sqlconnection);


            //cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("@IdUser", "5290f328-a1cf-4582-8ce3-d4d4a2f92f46");
            //cmd.ExecuteNonQuery();

            
            
            try
            {

                sqlDataReader = await sqlCommand.ExecuteReaderAsync();

                List<string> vs = new List<string>();

                while (await sqlDataReader.ReadAsync())
                {

                    vs.Add(sqlDataReader[0].ToString());

                    TB1.Text = Convert.ToString(sqlDataReader[2]);
                    TB2.Text = Convert.ToString(sqlDataReader[1]);
                    tb_name.Text = Convert.ToString(sqlDataReader[3]);
                    //Пользователи
                    #region Users
                    if (tb_name.Text == "ec47e246-b7c4-4849-86dc-83e1a546b355")
                    {
                        tb_name.Text = "Сериков Д.В.";
                    }
                    if (tb_name.Text == "e7da12a8-9a94-4cf5-9277-12320c8e5cd5")
                    {
                        tb_name.Text = "Артемов Н.И.";
                    }
                    if (tb_name.Text == "e616ee80-8898-46b6-8efe-314ebb805e83")
                    {
                        tb_name.Text = "Пашнев А.Д.";
                    }
                    if (tb_name.Text == "ce7c8351-9025-4855-8691-1bcd8e8412e2")
                    {
                        tb_name.Text = "Ткаченко А.О.";
                    }
                    if (tb_name.Text == "9c21717d-8776-48ba-be77-19c2a5ed8693")
                    {
                        tb_name.Text = "Смирнов Д.В.";
                    }
                    if (tb_name.Text == "943e5841-50d9-42d1-bf1b-d9b86a3a4ca5")
                    {
                        tb_name.Text = "Бусько А.В.";
                    }
                    if (tb_name.Text == "80a7c37a-5787-4041-965c-b0437c3e4524")
                    {
                        tb_name.Text = "Нестеров А.О.";
                    }
                    if (tb_name.Text == "6752cdb9-8db9-4f08-b352-c7e96337c22b")
                    {
                        tb_name.Text = "Петренко А.В.";
                    }
                    if (tb_name.Text == "63ef46a5-63b3-4903-b7b7-e017c3a9e228")
                    {
                        tb_name.Text = "Солодов Д.А.";
                    }
                    if (tb_name.Text == "63e86732-564a-42da-b9a0-1d26ff2d28ef")
                    {
                        tb_name.Text = "Рачков М.А.";
                    }
                    if (tb_name.Text == "5a8bc62b-e607-4c3d-acab-87b48c8e9690")
                    {
                        tb_name.Text = "Дорофеев И.А.";
                    }
                    if (tb_name.Text == "5290f328-a1cf-4582-8ce3-d4d4a2f92f46")
                    {
                        tb_name.Text = "Хаустов М.П.";
                    }
                    if (tb_name.Text == "4a6e9174-87bb-488f-8e65-12b596c657f0")
                    {
                        tb_name.Text = "Пенцак И.А.";
                    }
                    if (tb_name.Text == "4a020432-129b-43e0-8210-d34d66320ebf")
                    {
                        tb_name.Text = "Королев А.Ю.";
                    }
                    if (tb_name.Text == "368136e0-bc05-47c9-be7d-4b04da05ce0e")
                    {
                        tb_name.Text = "Скребцов А.В.";
                    }
                    if (tb_name.Text == "2b715c5f-906e-43d9-8e9d-d982eb395769")
                    {
                        tb_name.Text = "Гордеев А.Ю.";
                    }
                    if (tb_name.Text == "19374fce-cdc1-4d5d-92ad-45b4614f7319")
                    {
                        tb_name.Text = "Борзенков К.А.";
                    }
                    if (tb_name.Text == "1627f3a0-34e4-4c30-af47-e30890c7a472")
                    {
                        tb_name.Text = "Зыкин А.С.";
                    }
                    #endregion



                }
                sqlconnection.Close();
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
        

        // Событие при котором будет сворачиваться приложение в трей
        private void ButRead_Click(object sender, RoutedEventArgs e)
        {
            notify.Visible = true;
            notify.DoubleClick += (sndr, args) =>
            {
                this.Show();
                this.WindowState = WindowState.Normal;
                
                
            };
            this.Hide();
            notify.Icon = new Icon(@"S:\Пользователи\Прапорщики\Хаустов\Temp!\ICON\icon.ico"); // При сворачивании будет меняться ярлык
            


        }
        //Событие при котором будет выскакивать окно (т.е. если меняется текст последнего объявления, то оно выскакивает)
        private void TB1_TextChanged(object sender, TextChangedEventArgs e)
        {
            
            notify.ShowBalloonTip(29000, "Появилось новое объявление", TB1.Text, ToolTipIcon.None);
            notify.BalloonTipClicked += Notify_BalloonTipClicked;
            notify.Icon = new Icon(@"S:\Пользователи\Прапорщики\Хаустов\Temp!\ICON\icon_2.ico"); //При получении новых уведомлений будет меняться ярлык
           
        }
        

        //При нажатии разворачивает окно с последним объявлением
        private void Notify_BalloonTipClicked(object sender, EventArgs e)
        {
            this.Show();
            WindowState = WindowState.Normal;
        }

        private void Traymenu()
        {this.notify.ContextMenuStrip = new ContextMenuStrip();
         this.notify.ContextMenuStrip.Items.Add("Закрыть программу",null,this.Exit_App);
         this.notify.ContextMenuStrip.Items.Add("Все объявления", null,All_Notification);}
        
        void Exit_App(object sender, EventArgs e)
        {
            this.Close();

        }

        // Дополнение
        

        //Нажатие "Все объявления"
        void  All_Notification (object s,EventArgs e)
        {
            Window2 window2 = new Window2();
            window2.Show();
            SqlConnection connection = new SqlConnection(@"Data Source=SQL-SERVER;Initial Catalog=WebInfo;Integrated Security=True");
            connection.Open();
            string cmd = "SELECT Registration, Message FROM Notice.List ORDER BY Registration DESC";
            SqlCommand sqlCommand = new SqlCommand(cmd, connection);
            sqlCommand.ExecuteNonQuery();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable("[WebInfo].[Notice].[List]");
            dataAdapter.Fill(dt);
            window2.Data_Grid.ItemsSource = dt.DefaultView;
            connection.Close();
            
            
        }


        
        private async void Next_but_Click(object sender, RoutedEventArgs e)
        {
            
            string connectionString = @"Data Source=SQL-SERVER;Initial Catalog=WebInfo;Integrated Security=True";
            SqlConnection sqlconnection = new SqlConnection(connectionString);
            await sqlconnection.OpenAsync();
            SqlDataReader sqlDataReader = null;
            SqlCommand sqlCommand = new SqlCommand("SELECT TOP 2 * FROM [WebInfo].[Notice].[List] ORDER BY Registration DESC", sqlconnection);
            SqlCommand cmd = new SqlCommand("[Notice].[SelectNoReadUsers]", sqlconnection);


            try
            {

                sqlDataReader = await sqlCommand.ExecuteReaderAsync();
                while (await sqlDataReader.ReadAsync())
                {
                    TB1.Text = Convert.ToString(sqlDataReader[2]);
                    TB2.Text = Convert.ToString(sqlDataReader[1]);
                    tb_name.Text = Convert.ToString(sqlDataReader[3]);
                    //Пользователи
                    #region Users
                    if (tb_name.Text == "ec47e246-b7c4-4849-86dc-83e1a546b355")
                    {
                        tb_name.Text = "Сериков Д.В.";
                    }
                    if (tb_name.Text == "e7da12a8-9a94-4cf5-9277-12320c8e5cd5")
                    {
                        tb_name.Text = "Артемов Н.И.";
                    }
                    if (tb_name.Text == "e616ee80-8898-46b6-8efe-314ebb805e83")
                    {
                        tb_name.Text = "Пашнев А.Д.";
                    }
                    if (tb_name.Text == "ce7c8351-9025-4855-8691-1bcd8e8412e2")
                    {
                        tb_name.Text = "Ткаченко А.О.";
                    }
                    if (tb_name.Text == "9c21717d-8776-48ba-be77-19c2a5ed8693")
                    {
                        tb_name.Text = "Смирнов Д.В.";
                    }
                    if (tb_name.Text == "943e5841-50d9-42d1-bf1b-d9b86a3a4ca5")
                    {
                        tb_name.Text = "Бусько А.В.";
                    }
                    if (tb_name.Text == "80a7c37a-5787-4041-965c-b0437c3e4524")
                    {
                        tb_name.Text = "Нестеров А.О.";
                    }
                    if (tb_name.Text == "6752cdb9-8db9-4f08-b352-c7e96337c22b")
                    {
                        tb_name.Text = "Петренко А.В.";
                    }
                    if (tb_name.Text == "63ef46a5-63b3-4903-b7b7-e017c3a9e228")
                    {
                        tb_name.Text = "Солодов Д.А.";
                    }
                    if (tb_name.Text == "63e86732-564a-42da-b9a0-1d26ff2d28ef")
                    {
                        tb_name.Text = "Рачков М.А.";
                    }
                    if (tb_name.Text == "5a8bc62b-e607-4c3d-acab-87b48c8e9690")
                    {
                        tb_name.Text = "Дорофеев И.А.";
                    }
                    if (tb_name.Text == "5290f328-a1cf-4582-8ce3-d4d4a2f92f46")
                    {
                        tb_name.Text = "Хаустов М.П.";
                    }
                    if (tb_name.Text == "4a6e9174-87bb-488f-8e65-12b596c657f0")
                    {
                        tb_name.Text = "Пенцак И.А.";
                    }
                    if (tb_name.Text == "4a020432-129b-43e0-8210-d34d66320ebf")
                    {
                        tb_name.Text = "Королев А.Ю.";
                    }
                    if (tb_name.Text == "368136e0-bc05-47c9-be7d-4b04da05ce0e")
                    {
                        tb_name.Text = "Скребцов А.В.";
                    }
                    if (tb_name.Text == "2b715c5f-906e-43d9-8e9d-d982eb395769")
                    {
                        tb_name.Text = "Гордеев А.Ю.";
                    }
                    if (tb_name.Text == "19374fce-cdc1-4d5d-92ad-45b4614f7319")
                    {
                        tb_name.Text = "Борзенков К.А.";
                    }
                    if (tb_name.Text == "1627f3a0-34e4-4c30-af47-e30890c7a472")
                    {
                        tb_name.Text = "Зыкин А.С.";
                    }
                    #endregion


                }
                sqlconnection.Close();
                


            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButton.OK, MessageBoxImage.Error);
            }



        }

        private async void Prev_but_Click(object sender, RoutedEventArgs e)
        {
            string connectionString = @"Data Source=SQL-SERVER;Initial Catalog=WebInfo;Integrated Security=True";
            SqlConnection sqlconnection = new SqlConnection(connectionString);
            await sqlconnection.OpenAsync();
            SqlDataReader sqlDataReader = null;
            SqlCommand sqlCommand = new SqlCommand("SELECT TOP 1 * FROM [WebInfo].[Notice].[List] ORDER BY Registration DESC", sqlconnection);
            SqlCommand cmd = new SqlCommand("[Notice].[SelectNoReadUsers]", sqlconnection);


            try
            {

                sqlDataReader = await sqlCommand.ExecuteReaderAsync();
                while (await sqlDataReader.ReadAsync())
                {
                    TB1.Text = Convert.ToString(sqlDataReader[2]);
                    TB2.Text = Convert.ToString(sqlDataReader[1]);
                    tb_name.Text = Convert.ToString(sqlDataReader[3]);
                    //Пользователи
                    #region Users
                    if (tb_name.Text == "ec47e246-b7c4-4849-86dc-83e1a546b355")
                    {
                        tb_name.Text = "Сериков Д.В.";
                    }
                    if (tb_name.Text == "e7da12a8-9a94-4cf5-9277-12320c8e5cd5")
                    {
                        tb_name.Text = "Артемов Н.И.";
                    }
                    if (tb_name.Text == "e616ee80-8898-46b6-8efe-314ebb805e83")
                    {
                        tb_name.Text = "Пашнев А.Д.";
                    }
                    if (tb_name.Text == "ce7c8351-9025-4855-8691-1bcd8e8412e2")
                    {
                        tb_name.Text = "Ткаченко А.О.";
                    }
                    if (tb_name.Text == "9c21717d-8776-48ba-be77-19c2a5ed8693")
                    {
                        tb_name.Text = "Смирнов Д.В.";
                    }
                    if (tb_name.Text == "943e5841-50d9-42d1-bf1b-d9b86a3a4ca5")
                    {
                        tb_name.Text = "Бусько А.В.";
                    }
                    if (tb_name.Text == "80a7c37a-5787-4041-965c-b0437c3e4524")
                    {
                        tb_name.Text = "Нестеров А.О.";
                    }
                    if (tb_name.Text == "6752cdb9-8db9-4f08-b352-c7e96337c22b")
                    {
                        tb_name.Text = "Петренко А.В.";
                    }
                    if (tb_name.Text == "63ef46a5-63b3-4903-b7b7-e017c3a9e228")
                    {
                        tb_name.Text = "Солодов Д.А.";
                    }
                    if (tb_name.Text == "63e86732-564a-42da-b9a0-1d26ff2d28ef")
                    {
                        tb_name.Text = "Рачков М.А.";
                    }
                    if (tb_name.Text == "5a8bc62b-e607-4c3d-acab-87b48c8e9690")
                    {
                        tb_name.Text = "Дорофеев И.А.";
                    }
                    if (tb_name.Text == "5290f328-a1cf-4582-8ce3-d4d4a2f92f46")
                    {
                        tb_name.Text = "Хаустов М.П.";
                    }
                    if (tb_name.Text == "4a6e9174-87bb-488f-8e65-12b596c657f0")
                    {
                        tb_name.Text = "Пенцак И.А.";
                    }
                    if (tb_name.Text == "4a020432-129b-43e0-8210-d34d66320ebf")
                    {
                        tb_name.Text = "Королев А.Ю.";
                    }
                    if (tb_name.Text == "368136e0-bc05-47c9-be7d-4b04da05ce0e")
                    {
                        tb_name.Text = "Скребцов А.В.";
                    }
                    if (tb_name.Text == "2b715c5f-906e-43d9-8e9d-d982eb395769")
                    {
                        tb_name.Text = "Гордеев А.Ю.";
                    }
                    if (tb_name.Text == "19374fce-cdc1-4d5d-92ad-45b4614f7319")
                    {
                        tb_name.Text = "Борзенков К.А.";
                    }
                    if (tb_name.Text == "1627f3a0-34e4-4c30-af47-e30890c7a472")
                    {
                        tb_name.Text = "Зыкин А.С.";
                    }
                    #endregion


                }
                sqlconnection.Close();



            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }

        
    }

    


    

   
