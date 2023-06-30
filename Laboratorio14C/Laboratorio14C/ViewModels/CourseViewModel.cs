using Laboratorio14C.DataContext;
using Laboratorio14C.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Laboratorio14C.ViewModels
{
    public class CourseViewModel : INotifyPropertyChanged
    {
        private List<Course> courses;
        public List<Course> Courses
        {
            get { return courses; }
            set
            {
                courses = value;
                OnPropertyChanged("Courses");
            }
        }

        private List<Course> allCourses;

        private string searchKeyword;
        public string SearchKeyword
        {
            get { return searchKeyword; }
            set
            {
                searchKeyword = value;
                FilterCourses(searchKeyword);
            }
        }

        public CourseViewModel()
        {
            LoadCourses();
        }

        private void LoadCourses()
        {
            using (var context = new AppDbContext("your_db_path"))
            {
                allCourses = context.Course.ToList();
                Courses = allCourses;
            }
        }

        public void FilterCourses(string keyword)
        {
            Courses = allCourses.Where(c => c.Name.Contains(keyword)).ToList();
        }

        // Implementa la interfaz INotifyPropertyChanged para actualizar la vista cuando las propiedades cambien.
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
