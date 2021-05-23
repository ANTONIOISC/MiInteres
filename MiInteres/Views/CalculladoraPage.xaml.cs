using System;
using System.Collections.Generic;
using MiInteres.ViewModels;
using Xamarin.Forms;

namespace MiInteres.Views
{
    public partial class CalculladoraPage : ContentPage
    {
        public CalculladoraPage()
        {
            InitializeComponent();
            BindingContext = new CalculatorViewModel();
        }
    }
}
