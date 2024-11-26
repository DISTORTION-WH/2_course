using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public enum Language
        {
            English,
            Russian
        }
        public static void SwitchLanguage(Language language)
        {
            ResourceDictionary newLanguageResource = new ResourceDictionary();

            switch (language)
            {
                case Language.English:
                    newLanguageResource.Source = new Uri("Dictionary1.xaml", UriKind.RelativeOrAbsolute);
                    break;
                case Language.Russian:
                    newLanguageResource.Source = new Uri("Dictionary2.xaml", UriKind.RelativeOrAbsolute);
                    break;
                default:
                    // Use the default fallback dictionary
                    newLanguageResource.Source = new Uri("Dictionary1.xaml", UriKind.RelativeOrAbsolute);
                    break;
            }

            Current.Resources.MergedDictionaries.Clear();
            Current.Resources.MergedDictionaries.Add(newLanguageResource);
        }
    }
}
