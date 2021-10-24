using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TareaS2GarciaMarlon
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnAbrir_Clicked(object sender, EventArgs e)
        {
            String usuario = txtUsuario.Text;
            String constrasena = txtContrasena.Text;


            String usuariou = "estudiante2021";
            String contrasenau = "uisrael2021";

            
            try
            {
                if (usuario == usuariou)
                {
                    await Navigation.PushAsync(new ventanaDos(usuario, constrasena));

                }
                else if(constrasena == contrasenau)
                {
                    await Navigation.PushAsync(new ventanaDos(usuario, constrasena));

                }
                else if(usuario != usuariou && constrasena != contrasenau)
                {
                    DisplayAlert("Mensaje de Alerta", "Usuario o Contraseña Incorrecta", "OK");
                }
            }
            catch(Exception ex)
            {
                DisplayAlert("Mensaje de Alerta", ex.Message, "OK");
            }

            
        }
    }
}
