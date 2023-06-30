using Laboratorio14C.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Laboratorio14C.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CourseView : ContentPage
    {
        private CourseViewModel viewModel;

        public CourseView()
        {
            InitializeComponent();
            viewModel = new CourseViewModel();
            BindingContext = viewModel;
        }

        private void SearchButton_Clicked(object sender, EventArgs e)
        {
            string searchKeyword = SearchEntry.Text;
            viewModel.FilterCourses(searchKeyword);
        }
    }
}