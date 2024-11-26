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
using Microsoft.Win32;
using System.IO;

namespace app_8
{
    /// <summary>
    /// Логика взаимодействия для InsertBook.xaml
    /// </summary>
    public partial class InsertBook : Window
    {
        public InsertBook()
        {
            InitializeComponent();
        }

        public string imagePath;
        private byte[] imageData;
        private byte[] ConvertImageToByteArray(string imagePath)
        {
            byte[] imageData = null;

            try
            {
                using (FileStream stream = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                {
                    using (BinaryReader reader = new BinaryReader(stream))
                    {
                        imageData = reader.ReadBytes((int)stream.Length);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error converting image to byte array: " + ex.Message);
            }

            return imageData;
        }
        private void save_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Получение значений из элементов управления
                string bookName = name.Text;
                string authorName = name_a.Text;
                string authorSurname = surname_a.Text;
                string authorPatronymic = patr_a.Text;
                DateTime authorDateOfBirth = date_a.SelectedDate.GetValueOrDefault();
                int pageCount = int.Parse(count_p.Text);
                int publisherId = int.Parse(publ.Text);// Получите значение идентификатора из соответствующего элемента управления
                int yearPublished = int.Parse(year_p.Text);
                string formatik = ""; // Получите значение формата из соответствующих элементов управления
                if (pdf.IsChecked == true)
                {
                    formatik = "pdf";
                }
                if (txt.IsChecked == true)
                {
                    formatik = "txt";
                }
                if (epub.IsChecked == true)
                {
                    formatik = "epub";
                }
                byte[] imageData = ConvertImageToByteArray(imagePath);// Получите бинарные данные изображения из соответствующего источника

                // Строка подключения к вашей базе данных
                string connectionString = "Data Source=DRAGONBORN\\SQLEXPRESS;Initial Catalog=lab8;Integrated Security=True;Trust Server Certificate=True;";

                // Создание подключения и команды
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("InsertBookAndAuthor", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    // Параметры процедуры
                    command.Parameters.AddWithValue("@BookName", bookName);
                    command.Parameters.AddWithValue("@AuthorName", authorName);
                    command.Parameters.AddWithValue("@AuthorSurname", authorSurname);
                    command.Parameters.AddWithValue("@AuthorPatronymic", authorPatronymic);
                    command.Parameters.AddWithValue("@AuthorDateOfBirth", authorDateOfBirth);
                    command.Parameters.AddWithValue("@PageCount", pageCount);
                    command.Parameters.AddWithValue("@PublisherId", publisherId);
                    command.Parameters.AddWithValue("@YearPublished", yearPublished);
                    command.Parameters.AddWithValue("@Formatik", formatik);
                    command.Parameters.AddWithValue("@ImageData", imageData);

                    // Выполнение команды
                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Book and author inserted successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting book and author: " + ex.Message);
            }
        }

        private void load_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.png;*.jpeg;*.jpg)|*.png;*.jpeg;*.jpg|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == true)
            {
                imagePath = openFileDialog.FileName;
                imageData = ConvertImageToByteArray(imagePath);
            }
        }
    }
}
