using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace app_7
{
    public class CustomCommand
    {
        public static readonly RoutedUICommand GetColorCommand = new RoutedUICommand("Get Color", "GetColor", typeof(CustomCommand));
    }
}
