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
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void btnIngresar_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUser.Text))
            {
                await DisplayAlert("Error", "Ingrese usuario", "Aceptar");
                txtUser.Focus();
                return;

            }

            if (string.IsNullOrEmpty(txtPass.Text))
            {
                await DisplayAlert("Error", "Ingrese contraseña", "Aceptar");
                txtPass.Focus();
                return;
            }

            if (txtUser.Text == "estudiante2021" && txtPass.Text == "uisrael2021")
            {
                string usuario = txtUser.Text;
                string clave = txtPass.Text;
               

                await Navigation.PushAsync(new Registro(usuario, clave));
              

            }
            else
            {
                await DisplayAlert("Error", "Usuario o clave incorrecta", "Aceptar");
            }



            
        }
    }
}