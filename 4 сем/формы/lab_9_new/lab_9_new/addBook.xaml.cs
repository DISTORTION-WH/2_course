using Microsoft.SqlServer.Server;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace lab_9_new
{
    /// <summary>
    /// Логика взаимодействия для addBook.xaml
    /// </summary>
    public partial class addBook : Window
    {
        public addBook()
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
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.png;*.jpeg;*.jpg)|*.png;*.jpeg;*.jpg|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == true)
            {
                imagePath = openFileDialog.FileName;
                imageData = ConvertImageToByteArray(imagePath);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string n = name.Text;
            int a = int.Parse(a_id.Text);
            int pc = int.Parse(page.Text);
            int p = int.Parse(p_id.Text);
            int y = int.Parse(year.Text);
            string formatik = "";
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
            byte[] imageData = ConvertImageToByteArray(imagePath);
            using (LibContext dbContext = new LibContext())
            {
                Book book = new Book(n,a,pc,p,y,formatik,imageData);
                dbContext.books.Add(book);
                dbContext.SaveChanges();
                MessageBox.Show("Книга сохранена. Перезайдите в приложение для просмотра");
            }
        }


        
    }
}
