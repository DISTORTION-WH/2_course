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
using Newtonsoft.Json;
using System.IO;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Choose.xaml
    /// </summary>
    public partial class Choose : Page
    {
        public Choose()
        {
            InitializeComponent();
        }
        static string path = @"E:\4 сем\формы\4\WpfApp1\WpfApp1\prod.json";
        static string json = File.ReadAllText(path);
        List<Film> films = JsonConvert.DeserializeObject<List<Film>>(json);

        private void InStock_Click(object sender, RoutedEventArgs e)
        {
            List<Film> searchResults = films.Where(f => f.Quantity.Contains("In Stock")).ToList();

            if (searchResults.Count > 0)
            {
                dataGrid.ItemsSource = searchResults; // Вывод результатов поиска в таблицу
            }
            else
            {
                dataGrid.ItemsSource = null; // Очистка таблицы, если совпадений не найдено
                MessageBox.Show("Совпадений не найдено");
            }
        }

        private void OutStock_Click(object sender, RoutedEventArgs e)
        {
            List<Film> searchResults = films.Where(f => f.Quantity.Contains("Out of Stock")).ToList();

            if (searchResults.Count > 0)
            {
                dataGrid.ItemsSource = searchResults; // Вывод результатов поиска в таблицу
            }
            else
            {
                dataGrid.ItemsSource = null; // Очистка таблицы, если совпадений не найдено
                MessageBox.Show("Совпадений не найдено");
            }
        }

        public void Showw_Click(object sender, RoutedEventArgs e)
        {
            decimal minPrice = decimal.Parse(fromNum.Text);
            decimal maxPrice = decimal.Parse(toNum.Text);
            var sortedFilms = films.Where(f => f.Price >= minPrice && f.Price <= maxPrice)
                               .OrderBy(f => f.Price)
                               .ToList();
            if (sortedFilms.Count > 0)
            {
                dataGrid.ItemsSource = sortedFilms; // Вывод результатов поиска в таблицу
            }
            else
            {
                dataGrid.ItemsSource = null; // Очистка таблицы, если совпадений не найдено
                MessageBox.Show("Совпадений не найдено");
            }
        }
    }
}
