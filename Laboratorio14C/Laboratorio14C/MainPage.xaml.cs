using Laboratorio14C.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Laboratorio14C
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void InsertCourseButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CourseInsertView());
        }

        private void ViewCoursesButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CourseView());
        }
    }
}
