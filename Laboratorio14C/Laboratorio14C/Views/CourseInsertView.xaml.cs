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
    public partial class CourseInsertView : ContentPage
    {
        public CourseInsertView()
        {
            InitializeComponent();
            BindingContext = new CourseInsertViewModel();
        }
    }
}