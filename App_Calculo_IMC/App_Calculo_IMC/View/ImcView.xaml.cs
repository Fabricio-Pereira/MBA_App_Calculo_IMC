using App_Calculo_IMC.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App_Calculo_IMC
{
    public partial class ImcView : ContentPage
    {
        public ImcView()
        {
            InitializeComponent();

            BindingContext = new ImcViewModel();
        }
    }
}
