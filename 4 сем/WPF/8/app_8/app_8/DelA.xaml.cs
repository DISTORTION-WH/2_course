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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace app_8
{
    /// <summary>
    /// Логика взаимодействия для DelA.xaml
    /// </summary>
    public partial class DelA : Page
    {
        public DelA()
        {
            InitializeComponent();
        }

        private void del_row_auth_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Получение значений из элементов управления
                string IdRowName = id_row.Text;
                // Строка подключения к вашей базе данных
                string connectionString = "Data Source=DRAGONBORN\\SQLEXPRESS;Initial Catalog=lab8;Integrated Security=True;Trust Server Certificate=True;";

                // Создание подключения и команды
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("DelAuthor", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    // Параметры процедуры
                    command.Parameters.AddWithValue("@Id", IdRowName);
                    // Выполнение команды
                    command.ExecuteNonQuery();
                }

                MessageBox.Show("successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting row: " + ex.Message);
            }
        }
    }
}
