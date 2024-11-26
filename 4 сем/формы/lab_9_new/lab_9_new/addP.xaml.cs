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
    /// Логика взаимодействия для addP.xaml
    /// </summary>
    public partial class addP : Window
    {
        public addP()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string n = p_n.Text;
            using (LibContext dbContext = new LibContext())
            {
                Publisher p = new Publisher(n);

                dbContext.publishers.Add(p);
                dbContext.SaveChanges();
                MessageBox.Show("Издательство сохранено. Перезайдите в приложение для просмотра");
            }
        }
    }
}
