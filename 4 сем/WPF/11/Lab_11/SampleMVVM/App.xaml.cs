using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;
using SampleMVVM.Models;
using SampleMVVM.ViewModels;
using SampleMVVM.Views;

namespace SampleMVVM
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application,INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;

            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        private void OnStartup(object sender, StartupEventArgs e)
        {
            List<Student> students = new List<Student>();
            using (StudentContext db = new StudentContext())
            {
                students = db.Students.ToList();
            }

            MainView view = new MainView(); // создали View
            MainViewModel viewModel = new ViewModels.MainViewModel(students); // Создали ViewModel

            

            view.DataContext = viewModel; // положили ViewModel во View в качестве DataContext
            view.Show();

            
        }
    }
}
