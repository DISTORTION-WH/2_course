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

namespace app_7.controls
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
        //validateValueCallback
        //CoerceValueCallback
        public static readonly DependencyProperty RedValueProperty =
            DependencyProperty.Register("RedValue", typeof(byte), typeof(UserControl1),
                new FrameworkPropertyMetadata((byte)0,
                    FrameworkPropertyMetadataOptions.BindsTwoWayByDefault,
                    RedValuePropertyChanged,
                    RedValueCoerceValueCallback,
                    true,
                    UpdateSourceTrigger.PropertyChanged));

        public static readonly DependencyProperty GreenValueProperty =
            DependencyProperty.Register("GreenValue", typeof(byte), typeof(UserControl1),
                new FrameworkPropertyMetadata((byte)0,
                    FrameworkPropertyMetadataOptions.BindsTwoWayByDefault,
                    GreenValuePropertyChanged,
                    GreenValueCoerceValueCallback,
                    true,
                    UpdateSourceTrigger.PropertyChanged));

        public static readonly DependencyProperty BlueValueProperty =
            DependencyProperty.Register("BlueValue", typeof(byte), typeof(UserControl1),
                new FrameworkPropertyMetadata((byte)0,
                    FrameworkPropertyMetadataOptions.BindsTwoWayByDefault,
                    BlueValuePropertyChanged,
                    BlueValueCoerceValueCallback,
                    true,
                    UpdateSourceTrigger.PropertyChanged));

        public byte RedValue
        {
            get { return (byte)GetValue(RedValueProperty); }
            set { SetValue(RedValueProperty, value); }
        }

        public byte GreenValue
        {
            get { return (byte)GetValue(GreenValueProperty); }
            set { SetValue(GreenValueProperty, value); }
        }

        public byte BlueValue
        {
            get { return (byte)GetValue(BlueValueProperty); }
            set { SetValue(BlueValueProperty, value); }
        }

        private static void RedValuePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            MessageBox.Show("red value has chanched");
        }

        private static object RedValueCoerceValueCallback(DependencyObject d, object baseValue)
        {
            // Коррекция значения RedValue
            byte value = (byte)baseValue;
            return Math.Max((byte)0, Math.Min((byte)255, value)); // Ограничение значения в диапазоне 0-255
        }

        private static void GreenValuePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            MessageBox.Show("green value has chanched");
        }

        private static object GreenValueCoerceValueCallback(DependencyObject d, object baseValue)
        {
            // Коррекция значения GreenValue
            byte value = (byte)baseValue;
            return Math.Max((byte)0, Math.Min((byte)255, value)); // Ограничение значения в диапазоне 0-255
        }

        private static void BlueValuePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            MessageBox.Show("blue value has chanched");
        }

        private static object BlueValueCoerceValueCallback(DependencyObject d, object baseValue)
        {
            // Коррекция значения BlueValue
            byte value = (byte)baseValue;
            return Math.Max((byte)0, Math.Min((byte)255, value)); // Ограничение значения в диапазоне 0-255
        }
    }
}
