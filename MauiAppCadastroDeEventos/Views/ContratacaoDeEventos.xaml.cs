namespace MauiAppCadastroDeEventos.Views;

public partial class ContratacaoDeEventos : ContentPage
{
	public ContratacaoDeEventos()
	{
		InitializeComponent();
	}

    private void btn_avancar_Clicked_1(object sender, EventArgs e)
    {

        try
        { 
            Navigation.PushAsync(new Views.EventoCadastrado());
        }
        catch (Exception ex)
        {
            DisplayAlert("Ops!", ex.Message, "Ok");
        }

    }
}