using Microsoft.Win32;
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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для AddTovar.xaml
    /// </summary>
    public partial class AddTovar : Page
    {
        Film film = new Film();
        List<Film> films = new List<Film>();
        string path = @"E:\4 сем\формы\4\WpfApp1\WpfApp1\prod.json";
        public AddTovar()
        {
            InitializeComponent();
        }
        public string imagePath;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.png;*.jpeg;*.jpg)|*.png;*.jpeg;*.jpg|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == true)
            {
                imagePath = openFileDialog.FileName;
            }
        }

        string quantity = "";
        private void InStock_Checked(object sender, RoutedEventArgs e)
        {
            quantity = "In Stock";
        }

        private void OutStock_Checked(object sender, RoutedEventArgs e)
        {
            quantity = "Out of Stock";
        }

        private void saveTo_Click(object sender, RoutedEventArgs e)
        {
            if (inStock.IsChecked == true)
            {
                inStock.Checked += InStock_Checked;
                quantity = "In Stock";
            }
            else if (outStock.IsChecked == true)
            {
                outStock.Checked += OutStock_Checked;
                quantity = "Out of Stock";
            }

            film.Price = decimal.Parse(priceTextBox.Text);
            film.ShortName = shortNameTextBox.Text;
            film.Description = descriptionTextBox.Text;
            film.Quantity = quantity;
            film.ImagePath = imagePath;

            films.Add(film);

            // Создаем новую строку данных
            DataGridRow row = new DataGridRow();
            row.Item = film;

            // Добавляем строку в таблицу
            dataGrid.Items.Add(row);


            films = film.ReadJsonFile(path);
            Film newBook = new Film();
            newBook = film;
            films.Add(newBook);

            newBook.SerializeToJson(path, films);

            MessageBox.Show("Данные сохранены в JSON файл.");
            // Очищаем поля ввода
            shortNameTextBox.Clear();
            descriptionTextBox.Clear();
            priceTextBox.Clear();
            inStock.IsChecked = false;
            outStock.IsChecked = false;
            MessageBox.Show(films.Count().ToString());
        }
    }
}
