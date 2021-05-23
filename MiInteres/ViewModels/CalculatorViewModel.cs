using System;
using System.ComponentModel;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using MiInteres.Class;
using Xamarin.Forms;

namespace MiInteres.ViewModels
{
    public class CalculatorViewModel : BaseViewModel
    {

        #region Atrributes
        private string cantidad;
        private string interes;
        private string numeroMeses;
        private string lblResultadoInteres;
        private string lblResultadoCantidadInteres;
        public bool TituloInteresTotalLbl { get; set; } = false;
        public bool TituloCantidadInteresTotalLbl { get; set; } = false;
        public bool botonRefresh { get; set; } = false;
        public bool FrameResultInteres { get; set; } = false;
        public bool FrameResultCantidadInteres { get; set; } = false;
        public bool CopyRigth { get; set; }= true;

        #endregion

        #region Properties
        public string CantidadTxt
        {
            get { return this.cantidad;}
            set { SetValue(ref this.cantidad, value); }
             
        }
        public string InteresTxt
        {
            get { return this.interes; }
            set { SetValue(ref this.interes, value); }

        }
        public string NumeroMesesTxt
        {
            get { return this.numeroMeses; }
            set { SetValue(ref this.numeroMeses, value); }

        }

        public string  ResultadoInteresLbl
        {
            get { return this.lblResultadoInteres; }
            set { SetValue(ref this.lblResultadoInteres, value); }

        }

        public string ResultadoCantidadInteresLbl
        {
            get { return this.lblResultadoCantidadInteres; }
            set { SetValue(ref this.lblResultadoCantidadInteres, value); }

        }


        #endregion


        #region Commands

        public ICommand CalcularCommand
        {
            get
            {
                return new RelayCommand(CalcularCommanExecuted);
            }
            set
            {

            }
        }

        public ICommand RefreshCommand
        {
            get
            {
                return new RelayCommand(RefreshCommandExecuted);
            }
            set
            {

            }
        }

        



        #endregion

        #region Methods
        private void CalcularCommanExecuted()
        {
            try
            {
                if(string.IsNullOrEmpty(this.cantidad) ||
                    string.IsNullOrEmpty(this.interes) ||
                    string.IsNullOrEmpty(this.numeroMeses))
                {
                    App.Current.MainPage.DisplayAlert("Sugerencia", "Favor de llenar todos los campos", "Aceptar");
                }


                //Operaciones de calcular
                var cantInsert = float.Parse(CantidadTxt.ToString());
                var interestInsert = float.Parse(InteresTxt.ToString());
                var monthInsert = float.Parse(NumeroMesesTxt.ToString());
                var calculateInterest = cantInsert * (interestInsert / 100) * monthInsert;//Calcula Ineteres
                var calculateQuantityInterest = cantInsert + calculateInterest;//Cantidad Prestada + Interes Total

                ResultadoInteresLbl = $"$ {calculateInterest.ToString("N0")}";
                ResultadoCantidadInteresLbl = $"$ {calculateQuantityInterest.ToString("N0")}";
                TituloInteresTotalLbl = true;
                TituloCantidadInteresTotalLbl = true;
                FrameResultInteres = true;
                FrameResultCantidadInteres = true;
                botonRefresh = true;
                CopyRigth = false;
            }
            catch (Exception ex)
            {

            }
        }


        private void RefreshCommandExecuted()
        {
            try
            {
                LimpiarCampos();
                TituloInteresTotalLbl = false;
                TituloCantidadInteresTotalLbl = false;
                FrameResultInteres = false;
                FrameResultCantidadInteres = false;
                botonRefresh = false;
            }
            catch (Exception ex)
            {

            }
        }

        #endregion

        public  void LimpiarCampos()
        {
            CantidadTxt = string.Empty;
            InteresTxt = string.Empty;
            NumeroMesesTxt = string.Empty;
            ResultadoInteresLbl = string.Empty;
            ResultadoCantidadInteresLbl = string.Empty;
    
        }

    }


}
