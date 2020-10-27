using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FreddyNarvaezExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class registroxaml : ContentPage
    {
        public registroxaml(string user, string pass)
        {
            InitializeComponent();
            string usuario = lblUser.Text;
            lblUser.Text = usuario + user;
        }

        private async void btnguardar_Clicked(object sender, EventArgs e)
        {
            if (Convert.ToDouble(txtmonto.Text) < 1800)
            {
                try
                {
                    double dato1 = Convert.ToDouble(txtmonto.Text);
                    double s1 = 1800 - dato1;
                    double valorinteres = s1 * 0.05;
                    double cuota = ((s1 + valorinteres) / 3);
                    txtpagom.Text = cuota.ToString();
                    string pago = txtpagom.Text;
                    string nombre = txtnombre.Text;
                    string user = lblUser.Text;
                    await Navigation.PushAsync(new resumen(user, nombre, pago));
                }
                catch (Exception ex)
                {
                    DisplayAlert("Mensaje de alerta", "ERROR" + ex.Message, "ok");
                }
            }
            else {

                DisplayAlert("Mensaje de Alerta", "Esta excediendo el pago", "Ok");
            }

                
            
            
        }

    }
}