using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace SampleMVVM.ViewModels
{
    /// <summary>
    /// Provides common functionality for ViewModel classes
    /// </summary>
    public abstract class ViewModelBase : DependencyObject, INotifyPropertyChanged //уведомляем об обновлении
    {
        // Событие, которое уведомляет об изменении свойства
        public event PropertyChangedEventHandler PropertyChanged;

        // Метод для вызова события PropertyChanged при изменении свойства propertyName
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;

            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}
