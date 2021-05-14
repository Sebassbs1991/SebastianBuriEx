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

            lblUser.Text = $"Usuario Conectado: {usuario}";
            

        }

        public  void btnCalcular_Clicked(object sender, EventArgs e)
        {
            double costo=1800;
            string nombre = txtNombre.Text;           
            double monto = Convert.ToDouble(txtMonto.Text);
            double total;

            total = (costo - monto) / 3;
            double total2 = total + 90;

            txtTotal.Text = total2.ToString();
 
        }

        public  async void btnGuardar_Clicked(object sender, EventArgs e)
        {


            string nombre = txtNombre.Text;
            double monto = Convert.ToDouble(txtMonto.Text);

            await DisplayAlert("Bien", "Elemento guardado con éxito", "Aceptar");
            await Navigation.PushAsync(new Resumen(nombre));

            

            

        }
    }
}