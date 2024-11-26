using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace app_8
{
    /// <summary>
    /// Логика взаимодействия для InsPublisher.xaml
    /// </summary>
    public partial class InsPublisher : Window
    {
        public InsPublisher()
        {
            InitializeComponent();
        }

        private void save_p_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Получение значений из элементов управления
                string authorName = name_p.Text;
                // Строка подключения к вашей базе данных
                string connectionString = "Data Source=DRAGONBORN\\SQLEXPRESS;Initial Catalog=lab8;Integrated Security=True;Trust Server Certificate=True;";

                // Создание подключения и команды
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("InsertPubl", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    // Параметры процедуры
                    command.Parameters.AddWithValue("@PublName", authorName);
                    // Выполнение команды
                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Publisher inserted successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting publisher: " + ex.Message);
            }
        }
    }
}
