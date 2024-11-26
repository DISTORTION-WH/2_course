using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
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
using Microsoft.Data.SqlClient;

namespace app_8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string connectionString = "Data Source=DRAGONBORN\\SQLEXPRESS;Initial Catalog=lab8;Integrated Security=True;Trust Server Certificate=True;";
        SqlConnection connection;

        public MainWindow()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
            connection.Open();
        }

        //плюч папаметр в запросе
        public byte[] GetBinaryImage(int bookId)
        {
            byte[] imageBytes = null;

            // Подключение к базе данных SQL Server
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Создание команды с параметром
                string sql = "SELECT images FROM book WHERE id = @BookId";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    // Добавление параметра
                    command.Parameters.AddWithValue("@BookId", bookId); // bookId - значение id книги
                                                                        // Выполнение команды и получение результата
                    imageBytes = (byte[])command.ExecuteScalar();
                }
            }

            return imageBytes;
        }

        private void show_book_select_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string connectionString = "Data Source=DRAGONBORN\\SQLEXPRESS;Initial Catalog=lab8;Integrated Security=True;Trust Server Certificate=True;"; // Замените на свою строку подключения
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT id,name,author_id,page_count,publisher_id,year_published,formatik FROM book;";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);

                    reader.Close();

                    dataGrid.ItemsSource = dataTable.DefaultView;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving books: " + ex.Message);
            }
        }

        private void show_author_select_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string connectionString = "Data Source=DRAGONBORN\\SQLEXPRESS;Initial Catalog=lab8;Integrated Security=True;Trust Server Certificate=True;"; // Замените на свою строку подключения
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM author";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);

                    reader.Close();

                    dataGrid.ItemsSource = dataTable.DefaultView;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving books: " + ex.Message);
            }
        }

        private void show_publ_select_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string connectionString = "Data Source=DRAGONBORN\\SQLEXPRESS;Initial Catalog=lab8;Integrated Security=True;Trust Server Certificate=True;"; // Замените на свою строку подключения
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM publisher";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);

                    reader.Close();

                    dataGrid.ItemsSource = dataTable.DefaultView;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving books: " + ex.Message);
            }
        }

        private void ins_book_Click(object sender, RoutedEventArgs e)
        {
            // Создание нового окна
            var newWindow = new InsertBook(); // Здесь NewWindow - это класс нового окна, который вы должны создать

            // Открытие нового окна
            newWindow.Show();
        }

        private void ins_author_Click(object sender, RoutedEventArgs e)
        {
            var newWindow = new InsAuthor();
            newWindow.Show();
        }

        private void ins_publ_Click(object sender, RoutedEventArgs e)
        {
            var newWindow = new InsPublisher();
            newWindow.Show();
        }

        private void del_book_Click(object sender, RoutedEventArgs e)
        {
            var Book = new DelBook();
            DelFrame.Content = Book;
        }

        private void del_auth_Click(object sender, RoutedEventArgs e)
        {
            var a = new DelA();
            DelFrame.Content = a;
        }

        private void del_publ_Click(object sender, RoutedEventArgs e)
        {
            var p = new DelP();
            DelFrame.Content = p;
        }

        private void del_all_book_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string connectionString = "Data Source=DRAGONBORN\\SQLEXPRESS;Initial Catalog=lab8;Integrated Security=True;Trust Server Certificate=True;";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("DelBookAll", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                }

                MessageBox.Show("successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting row: " + ex.Message);
            }
        }

        private void del_all_author_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("DelAuthorAll", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.ExecuteNonQuery();

                MessageBox.Show("successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting row: " + ex.Message);
            }
        }

        private void del_all_publ_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("DelPublAll", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.ExecuteNonQuery();

                MessageBox.Show("successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting row: " + ex.Message);
            }
        }

        private void TabItem_Loaded(object sender, RoutedEventArgs e)
        {
            string query = "SELECT *\r\nFROM book\r\nORDER BY page_count DESC;";

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(reader);

            reader.Close();

            OrderData.ItemsSource = dataTable.DefaultView;
        }

        private void show_Click(object sender, RoutedEventArgs e)
        {
            int id = int.Parse(id_book.Text);
            // Получение двоичных данных из базы данных
            byte[] imageData = GetBinaryImage(id); // Здесь предполагается, что у вас есть метод для получения данных изображения из базы данных

            // Преобразование двоичных данных в изображение
            BitmapImage bitmapImage = new BitmapImage();
            using (MemoryStream memoryStream = new MemoryStream(imageData))
            {
                bitmapImage.BeginInit();
                bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapImage.StreamSource = memoryStream;
                bitmapImage.EndInit();
            }

            // Отображение изображения в элементе Image
            
            img.Source = bitmapImage;
        }

        private void prev_Click(object sender, RoutedEventArgs e)
        {
            // Получение ссылки на TabControl
            TabControl tabControl = tab;

            // Переключение на следующий TabItem
            int currentIndex = tabControl.SelectedIndex;
            int nextIndex = (currentIndex - 1) % tabControl.Items.Count;
            tabControl.SelectedIndex = nextIndex;
        }

        private void next_Click(object sender, RoutedEventArgs e)
        {
            // Получение ссылки на TabControl
            TabControl tabControl = tab;

            // Переключение на следующий TabItem
            int currentIndex = tabControl.SelectedIndex;
            int nextIndex = (currentIndex + 1) % tabControl.Items.Count;
            tabControl.SelectedIndex = nextIndex;
        }

        private SqlDataAdapter _dataAdapter;
        private DataTable _dataTable;

        //плюс параметр
        private void upd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    _dataAdapter.SelectCommand.Connection = connection;
                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(_dataAdapter);

                    _dataAdapter.UpdateCommand = commandBuilder.GetUpdateCommand();
                    _dataAdapter.InsertCommand = commandBuilder.GetInsertCommand();
                    _dataAdapter.DeleteCommand = commandBuilder.GetDeleteCommand();

                    _dataAdapter.Update(_dataTable);
                    MessageBox.Show("Data updated successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating data: {ex.Message}");
            }
        }

        private void PerformTransaction()
        {
            try
            {
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlTransaction transaction = connection.BeginTransaction();

                    try
                    {
                        // Вставка новой записи в таблицу publisher
                        string insertQuery = "INSERT INTO publisher (name) VALUES (@name)";
                        using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection, transaction))
                        {
                            insertCommand.Parameters.AddWithValue("@name", "new name");
                            insertCommand.ExecuteNonQuery();
                        }

                        // Обновление существующей записи в таблице publisher
                        string updateQuery = "UPDATE publisher SET name = @name WHERE id = @id";
                        using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection, transaction))
                        {
                            updateCommand.Parameters.AddWithValue("@name", "O'Reilly Media");
                            updateCommand.Parameters.AddWithValue("@id", 7);
                            updateCommand.ExecuteNonQuery();
                        }
                        

                        // Если все операции прошли успешно, фиксируем транзакцию
                        transaction.Commit();
                        MessageBox.Show("Transaction completed successfully.");
                    }
                    catch (Exception ex)
                    {
                        // В случае ошибки, откатываем транзакцию
                        transaction.Rollback();
                        MessageBox.Show($"Transaction rolled back. Error: {ex.Message}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Connection error: {ex.Message}");
            }
        }

        private void TabItem_Loaded_1(object sender, RoutedEventArgs e)
        {
            /*PerformTransaction();*/
        }

        private void trans_Click(object sender, RoutedEventArgs e)
        {
            PerformTransaction();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM publisher";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);

                    reader.Close();

                    Data.ItemsSource = dataTable.DefaultView;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving books: " + ex.Message);
            }
        }

        private string _connectionString = "Data Source=DRAGONBORN\\SQLEXPRESS;Initial Catalog=lab8;Integrated Security=True;Trust Server Certificate=True;";
        private void TabItem_Loaded_2(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "SELECT * FROM book";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    _dataAdapter = new SqlDataAdapter(query, connection);
                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(_dataAdapter);

                    _dataTable = new DataTable();
                    _dataAdapter.Fill(_dataTable);
                    datagrid.ItemsSource = _dataTable.DefaultView;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving books: " + ex.Message);
            }
        }
    }
}
