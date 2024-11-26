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
using Newtonsoft.Json;
using System.IO;


namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Filtr.xaml
    /// </summary>
    public partial class Filtr : Page
    {
        static string path = @"E:\4 сем\формы\4\WpfApp1\WpfApp1\prod.json";
        public Filtr()
        {
            InitializeComponent();
        }

        static string json = File.ReadAllText(path);
        List<Film> films = JsonConvert.DeserializeObject<List<Film>>(json);
        public void Letters_Click(object sender, RoutedEventArgs e)
        {
            List<Film> sortedFilms = films.OrderBy(f => f.ShortName).ToList();
            dataGrid.ItemsSource = sortedFilms;
        }

        public void Numbers_Click(object sender, RoutedEventArgs e)
        {
            List<Film> sortedFilms = films.OrderBy(f => f.Price).ToList();
            dataGrid.ItemsSource = sortedFilms;
        }
    }
}
