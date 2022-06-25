using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baza99
{
    public partial class Form1 : Form
    {
        SqlConnection sqlConnection;


        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\baza99\baza99\Database1.mdf;Integrated Security=True";

            sqlConnection = new SqlConnection(connectionString);

            await sqlConnection.OpenAsync();

            SqlDataReader sqlReader = null;

            SqlCommand command = new SqlCommand("SELECT * FROM [people]", sqlConnection);

            try
            {
                sqlReader = await command.ExecuteReaderAsync();

                while(await sqlReader.ReadAsync())
                {
                    listBox1.Items.Add(Convert.ToString(sqlReader["Id"]) + ") [" + Convert.ToString(sqlReader["Name"]) + "]     [" + Convert.ToString(sqlReader["Data"]) + "]     [" + Convert.ToString(sqlReader["Description"]) +"]");    
                }

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {

                if (sqlReader != null)
                    sqlReader.Close();
            }
        }

        private void закрытьЮДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
        }

        private async void button1_Click(object sender, EventArgs e)

        {
            if(label4.Visible)
            {
                label4.Visible = false;

            }

            if (!string.IsNullOrEmpty(comboBox1.Text) && !string.IsNullOrWhiteSpace(comboBox1.Text) &&
               !string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox1.Text) &&
               !string.IsNullOrEmpty(dateTimePicker1.Value.Date.ToShortDateString()) && !string.IsNullOrWhiteSpace(dateTimePicker1.Value.Date.ToShortDateString()))

            {
                SqlCommand command = new SqlCommand("INSERT INTO [people] (Name, Data, Description)VALUES(@Name, @Data, @Description)", sqlConnection);

                command.Parameters.AddWithValue("Name", comboBox1.Text);
                command.Parameters.AddWithValue("Data", dateTimePicker1.Text);
                command.Parameters.AddWithValue("Description", textBox1.Text);

                await command.ExecuteNonQueryAsync();

                MessageBox.Show("Успешно добавлено!", "Уважаемый пользователь!");
                textBox1.Clear();
                dateTimePicker1.ResetText();
            }

            else
            {
                label4.Visible = true;
                label4.Text = "Заполни поле ФИО или Причина";
            }

            

        }

        private async void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();

            SqlDataReader sqlReader = null;

            SqlCommand command = new SqlCommand("SELECT * FROM [people]", sqlConnection);

            try
            {
                sqlReader = await command.ExecuteReaderAsync();

                while (await sqlReader.ReadAsync())
                {
                    listBox1.Items.Add(Convert.ToString(sqlReader["Id"]) + ") [" + Convert.ToString(sqlReader["Name"]) + "]     [" + Convert.ToString(sqlReader["Data"]) + "]     [" + Convert.ToString(sqlReader["Description"]) + "]");
                }

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {

                if (sqlReader != null)
                    sqlReader.Close();
            }
        }

        void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue==(char)Keys.F5)
            {
                обновитьToolStripMenuItem_Click(обновитьToolStripMenuItem, null);
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {


            


            if (!string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrWhiteSpace(textBox2.Text))
            {

                SqlCommand command = new SqlCommand("DELETE FROM [people] WHERE [Id] = @Id", sqlConnection);

                command.Parameters.AddWithValue("Id", textBox2.Text);

                await command.ExecuteNonQueryAsync();

                MessageBox.Show("Успешно удалено!", "Уважаемый пользователь!");
                textBox2.Clear();
                

            }

            else
            {
                MessageBox.Show("Заполни поле Удалить!");
            }

        }

       
        }
    }

