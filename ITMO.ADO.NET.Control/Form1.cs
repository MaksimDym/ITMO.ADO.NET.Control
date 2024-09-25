using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ITMO.ADO.NET.Control
{
    public partial class Database : Form
    {
        private NpgsqlConnection connection;
        public Database()
        {
            InitializeComponent();
        }

       

        private void Database_Load(string fly)
        {
            try
            {
                string query = $"SELECT * FROM {fly}";
                using (var adapter = new NpgsqlDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    Table.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}");
            }

        }

        private void ButConnect_Click(object sender, EventArgs e)
                             
            {
                string username = postgres.Text;
                string password = Maksim1990.Text;
                string connString = $"Host=localhost;Username={username};Password={password};Database=fly";

                try
                {
                    connection = new NpgsqlConnection(connString);
                    connection.Open();
                    MessageBox.Show("Подключение успешно!");

                    // Загрузка данных при успешном подключении
                    Database_Load("flights");
                }
                catch (NpgsqlException ex)
                {
                    MessageBox.Show("Ошибка подключения или неверные данные: " + ex.Message);
                }

            }
            
        

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (connection != null && connection.State == ConnectionState.Open)
            {
                
               connection.Close(); 
            }
        }

        private void Database_Load(object sender, EventArgs e)
        {

        }

        private void ButAdd_Click(object sender, EventArgs e)
        {
            string newFlightNo = txtNewFlightNo.Text; 

            if (!string.IsNullOrEmpty(newFlightNo))
            {
                try
                {
                    string query = "INSERT INTO flights (flight_no) VALUES (@flightNo)";
                    using (var cmd = new NpgsqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("flightNo", newFlightNo);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Рейс добавлен успешно!");
                    Database_Load("flights"); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка добавления рейса: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Введите номер рейса.");
            }
        }

        private void ButDelete_Click(object sender, EventArgs e)
        {
            if (Table.SelectedRows.Count > 0)
            {
                int selectedIndex = Table.SelectedRows[0].Index;
                string flightNoToDelete = Table.Rows[selectedIndex].Cells["flight_no"].Value.ToString(); 

                try
                {
                    string query = "DELETE FROM flights WHERE flight_no = @flightNo";
                    using (var cmd = new NpgsqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("flightNo", flightNoToDelete);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Рейс удалён!");
                    Database_Load("flights"); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка удаления рейса: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Выберите рейс для удаления.");
            }
        }
    }
    
}
