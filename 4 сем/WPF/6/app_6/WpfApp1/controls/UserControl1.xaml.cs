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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1.controls
{
    /// <summary>
    /// Логика взаимодействия для UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        public static readonly DependencyProperty TopTextProperty = DependencyProperty.Register("TopText",
               typeof(String),
               typeof(UserControl1),
               new PropertyMetadata(string.Empty,
               ValueChangedTop));
        private static void ValueChangedTop(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = d as UserControl1;
            control.LabelTop.Content = e.NewValue;
        }
        public string TopText
        {
            get { return (string)GetValue(TopTextProperty); }
            set { SetValue(TopTextProperty, value); }
        }

        public event EventHandler Click;
        private void toSearch_Click(object sender, RoutedEventArgs e)
        {
            Click?.Invoke(this, e);
        }
    }
}
