using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TareaS2GarciaMarlon
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ventanaDos : ContentPage
    {
        public ventanaDos(String usuario, String contrasena)
        {
            InitializeComponent();

            lblUsuario.Text = usuario;
            

            
        }

        private void btnSuma_Clicked(object sender, EventArgs e)
        {
            try
            {
                double datoUno = Convert.ToDouble(txtDatoUno.Text);
                double datoDos = Convert.ToDouble(txtDatoDos.Text);

                double datoUnoD = Convert.ToDouble(txtDatoUnoD.Text);
                double datoDosD = Convert.ToDouble(txtDatoDosD.Text);

                double final = Convert.ToDouble(txtFinal.Text);

                double datoUnoS = datoUno * (0.3);
                double datoDosS = datoDos * (0.2);

                double datoUnoDo = datoUnoD * (0.3);
                double datoDosDo = datoDosD * (0.2);

                double suma = datoUnoS + datoDosS;
                double sumaD = datoUnoDo + datoDosDo;

                double fin = suma + sumaD;

                txtResultado.Text = Convert.ToString(suma);
                txtResultadoD.Text = Convert.ToString(sumaD);
                txtFinal.Text = Convert.ToString(fin);

                if (fin >= 7)
                {
                    txtEstado.Text = "APROBADO";
                }
                else if (fin <= 6.9 && fin >= 5)
                {
                    txtEstado.Text = "COMPLEMENTARIO";
                }
                else if (fin < 5 && fin >= 0.1)
                {
                    txtEstado.Text = "REPROBADO";
                }

            }
            catch (Exception ex)
            {
                DisplayAlert("Mensaje de Advertencia", ex.Message, "OK");
            }

        }


        private void txtDatoUno_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                double dato = Convert.ToDouble(txtDatoUno.Text);
                if (dato > 10)
                {
                    DisplayAlert("Mensaje de Alerta", "No se permite ingresar dato mayores a 10", "OK");
                }

            }
            catch (Exception ex)
            {
                DisplayAlert("Mensaje de Alerta", ex.Message, "OK");
            }
        }

        private void txtDatoDos_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                double datoD = Convert.ToDouble(txtDatoDos.Text);
                if (datoD > 10)
                {
                    DisplayAlert("Mensaje de Alerta", "No se permite ingresar dato mayores a 10", "OK");
                }

            }
            catch (Exception ex)
            {
                DisplayAlert("Mensaje de Alerta", ex.Message, "OK");
            }
        }

        private void txtDatoUnoD_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                double datoT = Convert.ToDouble(txtDatoUnoD.Text);
                if (datoT > 10)
                {
                    DisplayAlert("Mensaje de Alerta", "No se permite ingresar dato mayores a 10", "OK");
                }

            }
            catch (Exception ex)
            {
                DisplayAlert("Mensaje de Alerta", ex.Message, "OK");
            }
        }

        private void txtDatoDosD_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                double datoC = Convert.ToDouble(txtDatoDosD.Text);
                if (datoC > 10)
                {
                    DisplayAlert("Mensaje de Alerta", "No se permite ingresar dato mayores a 10", "OK");
                }

            }
            catch (Exception ex)
            {
                DisplayAlert("Mensaje de Alerta", ex.Message, "OK");
            }
        }

    }
}