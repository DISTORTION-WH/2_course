using SampleMVVM.Commands;
using SampleMVVM.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace SampleMVVM.ViewModels
{
    //управляет коллекцией студентов и включает команду для отправки данных в базу данных
    class MainViewModel : ViewModelBase
    {
        //Коллекция студентов в виде ViewModel, которая может уведомлять представление об изменениях
        public ObservableCollection<StudentViewModel> StudentList { get; set; }


        #region Constructor

        public MainViewModel(List<Student> students)
        {
            // Инициализация коллекции StudentList с преобразованием каждого Student в StudentViewModel
            StudentList = new ObservableCollection<StudentViewModel>(students.Select(b => new StudentViewModel(b)));
        }

        #endregion

        #region Commands

        private DelegateCommand sendDataToDB;

        public ICommand SendDataToDB
        {
            get
            {
                if (sendDataToDB == null)
                {
                    sendDataToDB = new DelegateCommand(Send);
                }
                return sendDataToDB;
            }
        }

        private void Send()
        {
            using (StudentContext db = new StudentContext())
            {
                foreach (StudentViewModel item in StudentList)
                {
                    Student temp = db.Students.Find(item.Student.Id);

                    if ((item.Order != temp.Order) || (item.Passes != temp.Passes))
                    {
                        if (item.Order != temp.Order)
                        {
                            temp.Order = item.Order;
                        }

                        if (item.Passes != temp.Passes)
                        {
                            temp.Passes = item.Passes;
                        }

                        db.SaveChanges();
                    }
                    
                }

                MessageBox.Show("Данные отправлены! Если они верны, информация обновится.");
            }
        }

        #endregion

    }
}
