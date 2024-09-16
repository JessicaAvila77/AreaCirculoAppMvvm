using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AreaCirculoAppMvvm.Viewmodels
{

    public partial class AreaCirculoViewModel : ObservableObject
    {
        [ObservableProperty]
        private double r;

        [ObservableProperty]
        private double area;

        private void Alerta(string Titulo, string Mensaje)
        {
            MainThread.BeginInvokeOnMainThread(async () => await App.Current!.MainPage!.DisplayAlert(Titulo, Mensaje, "Aceptar"));
        }


        //metodo calcular que contiene las validaciones correspondientes para la variable que captura el radio
        [RelayCommand]
        private void Calcular()
        {
            try
            {
                

                if (R == 0)
                {
                    Alerta("ADVERTENCIA", "Valor del radio no puede ser cero");
                }else if (R < 0)
                {
                    Alerta("ADVERTENCIA", "Valor del radio no puede ser negativo");
                }
                else
                {
                    Area = 3.1415926535897931 * (Math.Pow(R, 2));  
                }

            }

            catch (Exception ex)
            {
                Alerta("ERROR", ex.Message);
            }

        }

        [RelayCommand]
        private void Limpiar()
        {
            R= 0;
            Area = 0;
        }



    }
}
