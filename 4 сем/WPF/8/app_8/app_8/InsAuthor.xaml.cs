using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Metrics;
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
using static System.Net.Mime.MediaTypeNames;

namespace app_8
{
    /// <summary>
    /// Логика взаимодействия для InsAuthor.xaml
    /// </summary>
    public partial class InsAuthor : Window
    {
        public InsAuthor()
        {
            InitializeComponent();
        }

        private void save_ins_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Получение значений из элементов управления
                string authorName = name_a.Text;
                string authorSurname = surname_a.Text;
                string authorPatronymic = patr_a.Text;
                DateTime authorDateOfBirth = date_a.SelectedDate.GetValueOrDefault();
                // Строка подключения к вашей базе данных
                string connectionString = "Data Source=DRAGONBORN\\SQLEXPRESS;Initial Catalog=lab8;Integrated Security=True;Trust Server Certificate=True;";

                // Создание подключения и команды
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("InsertAuthor", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    // Параметры процедуры
                    command.Parameters.AddWithValue("@AuthorName", authorName);
                    command.Parameters.AddWithValue("@AuthorSurname", authorSurname);
                    command.Parameters.AddWithValue("@AuthorPatronymic", authorPatronymic);
                    command.Parameters.AddWithValue("@AuthorDateOfBirth", authorDateOfBirth);

                    // Выполнение команды
                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Author inserted successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting book and author: " + ex.Message);
            }
        }
    }
}
