using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FreddyNarvaezExamen
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnabrir_Clicked(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtclave.Text;

            if (txtUser.Text == "estudiante2020" && txtclave.Text == "uisrael2020")
            {
                await Navigation.PushAsync(new registroxaml(user, pass));
            }
            else
            {
                DisplayAlert("Mensaje de Alerta", "Usuario o Clave Incorrectos", "Intente de Nuevo");
            }
        }
    }
}
