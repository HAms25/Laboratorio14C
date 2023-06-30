using Laboratorio14C.DataContext;
using Laboratorio14C.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Laboratorio14C.ViewModels
{
    public class CourseInsertViewModel : INotifyPropertyChanged
    {
        private Course newCourse;
        public Course NewCourse
        {
            get { return newCourse; }
            set
            {
                newCourse = value;
                OnPropertyChanged("NewCourse");
            }
        }

        public CourseInsertViewModel()
        {
            NewCourse = new Course();
        }

        public void SaveCourse()
        {
            using (var context = new AppDbContext("your_db_path"))
            {
                context.Course.Add(NewCourse);
                context.SaveChanges();
            }
        }

        
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
