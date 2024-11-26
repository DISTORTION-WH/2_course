using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Data.Entity.Validation;
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
using Microsoft.EntityFrameworkCore;
using EntityState = System.Data.Entity.EntityState;

namespace lab_9_new
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IUnitOfWork _unitOfWork;
        public MainWindow()
        {
            InitializeComponent();
            InitializeCommands();
        }
        private void InitializeCommands()
        {
            AddPublisherCommand = new RelayCommand(_ => AddPublisher());
            UpdatePublisherCommand = new RelayCommand(_ => UpdatePublisher(), _ => SelectedPublisher != null);
            DeletePublisherCommand = new RelayCommand(_ => DeletePublisher(), _ => SelectedPublisher != null);
        }
        public ObservableCollection<Publisher> Publishers { get; private set; }

        private Publisher _selectedPublisher;
        public Publisher SelectedPublisher
        {
            get => _selectedPublisher;
            set
            {
                _selectedPublisher = value;
                OnPropertyChanged(nameof(SelectedPublisher));
                CommandManager.InvalidateRequerySuggested();
            }
        }

        public ICommand AddPublisherCommand { get; private set; }
        public ICommand UpdatePublisherCommand { get; private set; }
        public ICommand DeletePublisherCommand { get; private set; }

        private void LoadPublishers()
        {
            Publishers = new ObservableCollection<Publisher>(_unitOfWork.Publishers.GetAll());
        }

        private void AddPublisher()
        {
            var newPublisher = new Publisher { Name = "New Publisher" };
            _unitOfWork.Publishers.Add(newPublisher);
            _unitOfWork.Complete();
            LoadPublishers();
        }

        private void UpdatePublisher()
        {
            if (SelectedPublisher != null)
            {
                _unitOfWork.Publishers.Update(SelectedPublisher);
                _unitOfWork.Complete();
                LoadPublishers();
            }
        }

        private void DeletePublisher()
        {
            if (SelectedPublisher != null)
            {
                _unitOfWork.Publishers.Delete(SelectedPublisher);
                _unitOfWork.Complete();
                LoadPublishers();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }






        private void TabItem_Loaded(object sender, RoutedEventArgs e)
        {
            using (LibContext dbContext = new LibContext())
            {
                bookGrid.ItemsSource = dbContext.books.ToList();
            }
        }

        private void TabItem_Loaded_1(object sender, RoutedEventArgs e)
        {
            using (LibContext dbContext = new LibContext())
            {
                // Обновление источника данных для DataGrid
                authorGrid.ItemsSource = dbContext.authors.ToList();
            }
        }

        private void TabItem_Loaded_2(object sender, RoutedEventArgs e)
        {
            using (LibContext dbContext = new LibContext())
            {
                publGrid.ItemsSource = dbContext.publishers.ToList();
            }

        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            using (LibContext dbContext = new LibContext())
            {
                dbContext.books.RemoveRange(dbContext.books);
                dbContext.SaveChanges();
                // Обновление источника данных для bookGrid
                bookGrid.ItemsSource = dbContext.books.ToList();
            }
        }

        private void delButton_Click(object sender, RoutedEventArgs e)
        {
            using (LibContext dbContext = new LibContext())
            {
                dbContext.authors.RemoveRange(dbContext.authors);
                dbContext.SaveChanges();
                // Обновление источника данных для bookGrid
                authorGrid.ItemsSource = dbContext.authors.ToList();
            }
        }

        private void dellButton_Click(object sender, RoutedEventArgs e)
        {
            using (LibContext dbContext = new LibContext())
            {
                dbContext.publishers.RemoveRange(dbContext.publishers);
                dbContext.SaveChanges();
                // Обновление источника данных для bookGrid
                publGrid.ItemsSource = dbContext.publishers.ToList();
            }
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            var newWin = new addBook();
            newWin.Show();
        }

        private void adddButton_Click(object sender, RoutedEventArgs e)
        {
            var newWin = new addA();
            newWin.Show();
        }

        private void adButton_Click(object sender, RoutedEventArgs e)
        {
            var newWin = new addP();
            newWin.Show();
        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            using (LibContext dbContext = new LibContext())
            {
                // Получаем выбранные строки из bookGrid
                List<Book> updatedBooks = new List<Book>();
                foreach (var selectedItem in bookGrid.SelectedItems)
                {
                    if (selectedItem is Book book)
                    {
                        updatedBooks.Add(book);
                    }
                }

                // Обновляем каждую измененную книгу в базе данных
                bool hasValidationErrors = false;
                foreach (Book updatedBook in updatedBooks)
                {
                    // Проверяем валидность книги
                    if (Validator.TryValidateObject(updatedBook, new ValidationContext(updatedBook), null))
                    {
                        dbContext.Entry(updatedBook).State = EntityState.Modified;
                    }
                    else
                    {
                        hasValidationErrors = true;

                        // Выводим сообщение об ошибках валидации
                        var errors = string.Join(", ", typeof(Book).GetProperties()
                            .SelectMany(prop => prop.GetCustomAttributes(typeof(ValidationAttribute), true))
                            .OfType<ValidationAttribute>()
                            .Where(a => !a.IsValid(updatedBook))
                            .Select(a => a.ErrorMessage));
                        MessageBox.Show($"Ошибки валидации для книги '{updatedBook.Name}': {errors}");
                    }
                }

                try
                {
                    // Сохраняем изменения в базе данных, если нет ошибок валидации
                    if (!hasValidationErrors)
                    {
                        dbContext.SaveChanges();
                        MessageBox.Show("Изменения сохранены");
                    }
                    else
                    {
                        MessageBox.Show("Не удалось сохранить изменения из-за ошибок валидации.");
                    }
                }
                catch (DbEntityValidationException ex)
                {
                    // Обработка ошибок валидации Entity Framework
                    var errorMessages = new List<string>();
                    foreach (var validationErrors in ex.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            errorMessages.Add($"Property: {validationError.PropertyName}, Error: {validationError.ErrorMessage}");
                        }
                    }
                    MessageBox.Show(string.Join(Environment.NewLine, errorMessages));
                }
            }
        }

        private void updButton_Click(object sender, RoutedEventArgs e)
        {
            using (LibContext dbContext = new LibContext())
            {
                // Получаем выбранные строки из bookGrid
                List<Author> updatedAuthors = new List<Author>();
                foreach (var selectedItem in authorGrid.SelectedItems)
                {
                    if (selectedItem is Author auf)
                    {
                        updatedAuthors.Add(auf);
                    }
                }

                // Обновляем каждую измененную книгу в базе данных
                foreach (Author updatedAuf in updatedAuthors)
                {
                    dbContext.Entry(updatedAuf).State = EntityState.Modified;
                }

                // Сохраняем изменения в базе данных
                dbContext.SaveChanges();
                MessageBox.Show("изменения сохранены");
            }
        }

        private void updtButton_Click(object sender, RoutedEventArgs e)
        {
            using (LibContext dbContext = new LibContext())
            {
                // Получаем выбранные строки из bookGrid
                List<Publisher> updatedPubls = new List<Publisher>();
                foreach (var selectedItem in publGrid.SelectedItems)
                {
                    if (selectedItem is Publisher auf)
                    {
                        updatedPubls.Add(auf);
                    }
                }

                // Обновляем каждую измененную книгу в базе данных
                foreach (Publisher updatedP in updatedPubls)
                {
                    dbContext.Entry(updatedP).State = EntityState.Modified;
                }

                // Сохраняем изменения в базе данных
                dbContext.SaveChanges();
                MessageBox.Show("изменения сохранены");
            }
        }

        private void SotrBooks_Loaded(object sender, RoutedEventArgs e)
        {
            using (LibContext dbContext = new LibContext())
            {
                var sortedBooks = dbContext.books.OrderBy(b => b.PageCount).ToList();
                bookGridSort.ItemsSource = sortedBooks;
            }
        }

        private void filtr_Click(object sender, RoutedEventArgs e)
        {
            int id = int.Parse(a_i.Text);
            using (LibContext dbContext = new LibContext())
            {
                var filteredBooks = dbContext.books.Where(b => b.AuthorId == id).ToList();
                bookGridFiltr.ItemsSource = filteredBooks;
            }
        }

        public async Task trans_ClickAsync(object sender, RoutedEventArgs e)
        {
            using (var dbContext = new LibContext())
            {
                using (var transaction = dbContext.Database.BeginTransaction())
                {
                    try
                    {
                        // Пример асинхронного запроса
                        var books = await dbContext.books.ToListAsync();

                        // Изменение данных
                        foreach (var book in books)
                        {
                            book.PageCount += 10; // Увеличение цены на 10
                        }

                        // Сохранение изменений
                        await dbContext.SaveChangesAsync();


                        // Завершение транзакции
                        transaction.Commit();
                        MessageBox.Show("transaction ended :)");
                        bookGrid.ItemsSource = dbContext.books.ToList();
                    }
                    catch (Exception ex)
                    {
                        // Обработка ошибки и откат транзакции
                        transaction.Rollback();
                        Console.WriteLine("Ошибка при выполнении операции: " + ex.Message);
                    }
                }
            }
        }

        private async void trans_Click(object sender, RoutedEventArgs e)
        {
            await trans_ClickAsync(sender, e);
        }
    }
}
