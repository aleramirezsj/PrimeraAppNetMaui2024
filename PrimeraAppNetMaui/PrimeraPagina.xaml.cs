using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PrimeraAppNetMaui;

public partial class PrimeraPagina : ContentPage
{
	public PrimeraPagina()
	{
		InitializeComponent();
        btnInstituto.Clicked += BtnInstituto_Clicked;
        btnCarrera.Clicked += async (s, a) => {
            await Application.Current.MainPage.DisplayAlert("Carrera", "T�cnico Superior en Desarrollo de software", "Ok");
        };
	}

    private async void BtnInstituto_Clicked(object? sender, EventArgs e)
    {
        await Application.Current.MainPage.DisplayAlert("Instituci�n", "Instituto Superior de Profesorado N�20 \"Sdor Nestor J. Zamaro\"", "Ok");
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Application.Current.MainPage.DisplayAlert("Ventana de Mensaje", "Hola Mundo y bienvenido a .NET MAUI", "Ok");
    }
}