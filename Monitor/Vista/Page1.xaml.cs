using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monitor.VistaModelo;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Monitor.Vista
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
            //BindingContext = new VMmenuPrincipal(Navigation);
            BindingContext = new VMestres(Navigation);
        }
    }
}