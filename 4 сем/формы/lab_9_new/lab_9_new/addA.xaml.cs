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
using System.Windows.Shapes;

namespace lab_9_new
{
    /// <summary>
    /// Логика взаимодействия для addA.xaml
    /// </summary>
    public partial class addA : Window
    {
        public addA()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string n = a_n.Text;
            string s = a_s.Text;
            string p = a_p.Text;
            // Предположим, у вас есть TextBox с именем birthDateTextBox
            string b = a_b.Text;

            // Попытка преобразования текста в DateTime
            if (DateTime.TryParse(b, out DateTime birthDate))
            {
                MessageBox.Show("correct date");
            }
            else
            {
                MessageBox.Show("INcorrect date :(");
            }
            using (LibContext dbContext = new LibContext())
            {
                Author a = new Author(n,s,p,birthDate);

                dbContext.authors.Add(a);
                dbContext.SaveChanges();
                MessageBox.Show("Автор сохранен. Перезайдите в приложение для просмотра");
            }
        }
    }
}
