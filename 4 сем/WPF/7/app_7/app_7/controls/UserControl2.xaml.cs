using System;
using System.Collections.Generic;
using System.Drawing;
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
using Color = System.Drawing.Color;
using System.Drawing.Printing;
using System.Windows.Media.Animation;

namespace app_7.controls
{
    /// <summary>
    /// Логика взаимодействия для UserControl2.xaml
    /// </summary>
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }
        private void GetColorCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
        }

        private void GetColorCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true; // Или определите условие для определения, может ли команда выполняться
        }
        public delegate void MyD(object sender, RoutedEventArgs e);  
        public event MyD ClickH;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ClickH?.Invoke(this, null);
        }


        public static readonly RoutedEvent CustomDirectClickEvent = EventManager.RegisterRoutedEvent(
            "CustomDirectClick", RoutingStrategy.Direct, typeof(RoutedEventHandler), typeof(UserControl2));

        public static readonly RoutedEvent CustomTunnelingClickEvent = EventManager.RegisterRoutedEvent(
            "CustomTunnelingClick", RoutingStrategy.Tunnel, typeof(RoutedEventHandler), typeof(UserControl2));

        public static readonly RoutedEvent CustomBubblingClickEvent = EventManager.RegisterRoutedEvent(
            "CustomBubblingClick", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(UserControl2));

        public event RoutedEventHandler CustomDirectClick
        {
            add { AddHandler(CustomDirectClickEvent, value); }
            remove { RemoveHandler(CustomDirectClickEvent, value); }
        }

        public event RoutedEventHandler CustomTunnelingClick
        {
            add { AddHandler(CustomTunnelingClickEvent, value); }
            remove { RemoveHandler(CustomTunnelingClickEvent, value); }
        }

        public event RoutedEventHandler CustomBubblingClick
        {
            add { AddHandler(CustomBubblingClickEvent, value); }
            remove { RemoveHandler(CustomBubblingClickEvent, value); }
        }
    }
}
