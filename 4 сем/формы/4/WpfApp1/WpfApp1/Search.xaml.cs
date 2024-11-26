using Newtonsoft.Json;
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
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Search.xaml
    /// </summary>
    public partial class Search : Page
    {
        public Search()
        {
            InitializeComponent();
        }
        static string path = @"E:\4 сем\формы\4\WpfApp1\WpfApp1\prod.json";
        static string json = File.ReadAllText(path);
        List<Film> films = JsonConvert.DeserializeObject<List<Film>>(json);
        public void Searchik(string searchTerm)
        {
            List<Film> searchResults = films.Where(f => f.ShortName.Contains(searchTerm)).ToList();

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
        private void toSearch_Click(object sender, RoutedEventArgs e)
        {
            Searchik(textik.Text);
        }
    }
}