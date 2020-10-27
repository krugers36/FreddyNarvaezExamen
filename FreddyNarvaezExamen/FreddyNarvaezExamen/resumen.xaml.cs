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
    public partial class resumen : ContentPage
    {
        public resumen(string user, string nombre, string pago)
        {
            InitializeComponent();
            string usuario = lblUser.Text;
            lblUser.Text = usuario + user;
            string nombre1 = lblnombre.Text;
            lblnombre.Text = usuario + nombre;
            string pago1 = lblpago.Text;
            lblpago.Text = usuario + pago;
            
        }
    }
}