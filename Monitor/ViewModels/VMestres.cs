using Monitor.VistaModelo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using static Xamarin.Essentials.Permissions;

namespace Monitor.VistaModelo
{
    public class VMestres : BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        //Para las variables
        double _Monto;
        double _Porcentaje;
        double _Personas;

        //Para los resultados
        double _Porcentajepagar;
        double _Propina;
        double _Totalpagar;
        double _Personascuenta;
        //Pa las imagenes
        bool _feli;
        bool _tiste;


        #endregion
        #region CONSTRUCTOR
        public VMestres(INavigation navigation)
        {
            Navigation = navigation;

        }
        #endregion
        #region OBJETOS
        public string Texto
        {
            get { return _Texto; }
            set { SetValue(ref _Texto, value); }
        }

        //Variables
        public double Monto
        {
            get { return _Monto; }
            set { SetValue(ref _Monto, value); }
        }
        public double Porcentaje
        {
            get { return _Porcentaje; }
            set { SetValue(ref _Porcentaje, value); }
        }

        public double Personas
        {
            get { return _Personas; }
            set { SetValue(ref _Personas, value); }
        }
        //Pa los resultados
        public double Porcentajepagar
        {
            get { return _Porcentajepagar; }
            set { SetValue(ref _Porcentajepagar, value); }
        }
        public double Propina
        {
            get { return _Propina; }
            set { SetValue(ref _Propina, value); }
        }

        public double Personascuenta
        {
            get { return _Personascuenta; }
            set { SetValue(ref _Personascuenta, value); }
        }
        public double Totalpagar
        {
            get { return _Totalpagar; }
            set { SetValue(ref _Totalpagar, value); }
        }

        //Fotos
        public bool Feli
        {
            get { return _feli; }
            set { SetValue(ref _feli, value); }
        }
        public bool Tiste
        {
            get { return _tiste; }
            set { SetValue(ref _tiste, value); }
        }
        
        #endregion
        #region PROCESOS
        public async Task ProcesoAsyncrono()
        {

        }
        public void procesoSimple()
        {

        }
        public async void Calcularpropina()
        {
            Propina = (Porcentaje * Monto / 100);
            Totalpagar = Monto + Propina;

            Personascuenta = Totalpagar / Personas;

            if(Porcentaje >= 10)
            {
                Feli= true;
                Tiste= false;
            }
            else
            {
                Feli = false;
                Tiste = true;
            }
           
        }

        public async void btnBoton()
        {
            Calcularpropina();
        }

        #endregion
        #region COMANDOS
        public ICommand ProcesoAsyncomand => new Command(async () => await ProcesoAsyncrono());
        public ICommand btnBotoncommand => new Command(btnBoton);
        public ICommand ProcesoSimpcomand => new Command(procesoSimple);
        #endregion
    }
}
