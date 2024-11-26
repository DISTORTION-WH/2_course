using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp1
{
    public class CustomCommand
    {
        private static readonly RoutedUICommand _savetotablecommand = new RoutedUICommand("SaveTT", "SaveToTable", typeof(CustomCommand));
        private static readonly RoutedUICommand _instockcommand = new RoutedUICommand("In", "InStock", typeof(CustomCommand));
        private static readonly RoutedUICommand _outstockcommand = new RoutedUICommand("Out", "OutStock", typeof(CustomCommand));
        private static readonly RoutedUICommand _showpricecommand = new RoutedUICommand("Show", "ShowPrice", typeof(CustomCommand));
        private static readonly RoutedUICommand _letterscommand = new RoutedUICommand("Let", "Letters", typeof(CustomCommand));
        private static readonly RoutedUICommand _numberscommand = new RoutedUICommand("Num", "Numbers", typeof(CustomCommand));
        private static readonly RoutedUICommand _toSearchcommand = new RoutedUICommand("toS", "toSearch", typeof(CustomCommand));
        private static readonly RoutedUICommand _loadcommand = new RoutedUICommand("load", "Load", typeof(CustomCommand));
        private static readonly RoutedUICommand _savecommand = new RoutedUICommand("save", "saveto", typeof(CustomCommand));


        public static RoutedUICommand SaveToTable
        {
            get { return _savetotablecommand; }
        }
        public static RoutedUICommand InStock
        {
            get { return _instockcommand; }
        }
        public static RoutedUICommand OutStock
        {
            get { return _outstockcommand; }
        }
        public static RoutedUICommand ShowPrice
        {
            get { return _showpricecommand; }
        }
        public static RoutedUICommand Letters
        {
            get { return _letterscommand; }
        }
        public static RoutedUICommand Numbers
        {
            get { return _numberscommand; }
        }
        public static RoutedUICommand toSearch
        {
            get { return _toSearchcommand; }
        }
        public static RoutedUICommand Load
        {
            get { return _loadcommand; }
        }
        public static RoutedUICommand saveto
        {
            get { return _savecommand; }
        }
    }
}

