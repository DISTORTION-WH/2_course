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

namespace app_7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //прямое событие direct event
            userControl2.ClickH += userControl2_Loaded;
        }

        private void userControl2_Loaded(object sender, RoutedEventArgs e)
        {
            byte red = (byte)redSlider.Slider.Value;
            byte green = (byte)greenSlider.Slider.Value;
            byte blue = (byte)blueSlider.Slider.Value;

            Color color = Color.FromRgb(red, green, blue);
            Field.Fill = new SolidColorBrush(color);
        }

        private void Control_MouseDown(object sender, MouseButtonEventArgs e)
        {
            // Обработчик события для типа маршрутизации Direct
            textBlock1.Text += "Direct event occurred\n";
            /*e.Handled = true;*/ // Если вы хотите остановить дальнейшее распространение события
        }

        private void Control_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            // Обработчик события для типа маршрутизации Tunneling
            textBlock1.Text += "Tunneling event occurred\n";
           /* e.Handled = true; */// Если вы хотите остановить дальнейшее распространение события
        }

        private void Control_Click(object sender, RoutedEventArgs e)
        {
            // Обработчик события для типа маршрутизации Bubbling
            textBlock1.Text += "Bubbling event occurred\n";
            /*e.Handled = true;*/ // Если вы хотите остановить дальнейшее распространение события
        }
    }
}
