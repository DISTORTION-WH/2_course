using Microsoft.Win32;
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
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Film film = new Film();
        List<Film> films = new List<Film>();
        public string path = @"E:\4 сем\формы\4\WpfApp1\WpfApp1\prod.json";


        public MainWindow()
        {
            InitializeComponent();
            CommandBinding commandBinding = new CommandBinding();
            commandBinding.Command = ApplicationCommands.Open;
            commandBinding.Executed += CommandBinding_Executed;
            Catalog.CommandBindings.Add(commandBinding);


        }

        /*MainWindow.Resources = new ResourceDictionary()
        {
            Source = new Uri("Dictionary1.xaml", UriKind.Relative)
        };*/
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

        private void saveToTable_Click(object sender, RoutedEventArgs e)
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

            // Проверка валидации свойства Quantity объекта film
            var validationContext = new ValidationContext(film, null, null);
            var validationResults = new List<System.ComponentModel.DataAnnotations.ValidationResult>();
            var isValid = Validator.TryValidateObject(film, validationContext, validationResults, true);

            if (!isValid)
            {
                // Обработка ошибок валидации
                string errorMessage = "Ошибка валидации:\n";
                foreach (var validationResult in validationResults)
                {
                    errorMessage += validationResult.ErrorMessage + "\n";
                }

                MessageBox.Show(errorMessage);
                return;
            }

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

        private void AddProduct_Click(object sender, RoutedEventArgs e)
        {
            AddTovar addpr = new AddTovar();
            MyFrame.Content = addpr;
        }

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Product pr = new Product();
            MyFrame.Content = pr;

            string json = File.ReadAllText(path);
            List<Film> filmsList = JsonConvert.DeserializeObject<List<Film>>(json);

            pr.dataGrid.ItemsSource = filmsList;

            pr.dataGrid.CellEditEnding += (sender, e) =>
            {
                if (e.Column is DataGridBoundColumn)
                {
                    // Получаем измененный объект Film
                    Film editedFilm = e.Row.Item as Film;
                    // Получаем привязку (Binding) к свойству, которое было изменено
                    Binding binding = (e.Column as DataGridBoundColumn).Binding as Binding;
                    // Получаем имя свойства, которое было изменено
                    string propertyName = binding?.Path?.Path;

                    // Обновляем значение свойства в объекте Film на основе данных из ячейки
                    if (propertyName == "ShortName")
                        editedFilm.ShortName = (e.EditingElement as TextBox).Text;
                    else if (propertyName == "Description")
                        editedFilm.Description = (e.EditingElement as TextBox).Text;
                    else if (propertyName == "Price")
                        editedFilm.Price = Convert.ToDecimal((e.EditingElement as TextBox).Text);
                    else if (propertyName == "Quantity")
                        editedFilm.Quantity = (e.EditingElement as TextBox).Text;

                    // Выполняем сериализацию списка в JSON-строку
                    string updatedJson = JsonConvert.SerializeObject(filmsList);
                    // Записываем JSON-строку обратно в файл
                    File.WriteAllText(path, updatedJson);

                    var validationContext = new ValidationContext(film, null, null);
                    var validationResults = new List<System.ComponentModel.DataAnnotations.ValidationResult>();
                    var isValid = Validator.TryValidateObject(film, validationContext, validationResults, true);

                    if (!isValid)
                    {
                        // Обработка ошибок валидации
                        string errorMessage = "Ошибка валидации:\n";
                        foreach (var validationResult in validationResults)
                        {
                            errorMessage += validationResult.ErrorMessage + "\n";
                        }

                        MessageBox.Show(errorMessage);
                        return;
                    }
                }
            };
        }


        private void Sorted_Click(object sender, RoutedEventArgs e)
        {
            Filtr sort = new Filtr();
            MyFrame.Content = sort;
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            Search searcing = new Search();
            MyFrame.Content = searcing;
        }

        private void Chosen_Click(object sender, RoutedEventArgs e)
        {
            Choose ch = new Choose();
            MyFrame.Content = ch;
        }

        private void Ru_Click(object sender, RoutedEventArgs e)
        {
            App.SwitchLanguage(App.Language.Russian);
        }

        private void En_Click(object sender, RoutedEventArgs e)
        {
            App.SwitchLanguage(App.Language.English);
        }

        
    }

    public class CursorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string cursorPath)
            {
                if (File.Exists(cursorPath))
                {
                    return new Cursor(cursorPath);
                }
                else
                {
                    // Обработка случая, когда файл курсора не найден
                    return Cursors.Arrow;
                }
            }

            return Cursors.Arrow;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
