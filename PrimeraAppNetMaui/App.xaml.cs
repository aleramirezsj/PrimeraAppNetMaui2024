

using System.Diagnostics;

namespace PrimeraAppNetMaui
{
    public partial class App : Application
    {
        
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            Window nuestraApp= base.CreateWindow(activationState);
            nuestraApp.Activated += SaludoDeBienvenida;
            nuestraApp.Deactivated += async (s, a) => await MensajeAppSuspendida(s,a);
            nuestraApp.Destroying += async(s,a) => await MensajeAppCerrada(s,a);
            nuestraApp.Resumed += async (s, a) => await MensajeAppRestaurada(s, a);

            return nuestraApp;
        }

        private async Task MensajeAppSuspendida(object? sender, EventArgs e)
        {
            Debug.Print(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>ha salido de la APP pero todavía está cargada en memoria");
        }

        private async Task MensajeAppRestaurada(object? sender, EventArgs e)
        {
            Debug.Print(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>ha vuelto a la APP");
        }

        private async Task MensajeAppCerrada(object? sender, EventArgs e)
        {
            Debug.Print(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>Se ha quitado la App de memoria");
            
        }

        private async void SaludoDeBienvenida(object? sender, EventArgs e)
        {
            await Application.Current.MainPage.DisplayAlert("Mensaje", "Bienvenidos a Nuestra App", "Ok");
        }
    }
}
