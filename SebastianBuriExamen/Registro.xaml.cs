using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SebastianBuriExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        public Registro(string usuario, string pass)
        {
            InitializeComponent();

            lblUser.Text = usuario;
            

        }

        private  void btnCalcular_Clicked(object sender, EventArgs e)
        {
            int costo=1800;
            /*string nombre = txtNombre.Text;           
            int monto = txtMonto.Text;
            int pago = txtPago.Text;
            

            await Navigation.PushAsync(new Resumen(nombre, monto, pago));*/


        }

        private void btnGuardar_Clicked(object sender, EventArgs e)
        {

        }
    }
}