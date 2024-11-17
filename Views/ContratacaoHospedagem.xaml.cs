using MauiAppHotelAtt.Views;
using Microsoft.Maui.Controls;

namespace MauiAppHotelAtt.Views
{
    public partial class ContratacaoHospedagem : ContentPage
    {
        public ContratacaoHospedagem()
        {
            InitializeComponent();
        }

        // Evento que ser� chamado quando o bot�o "Avan�ar" for clicado
        private async void OnAvancarClicked(object sender, EventArgs e)
        {
            // Obter as informa��es de su�te selecionada e n�meros de adultos e crian�as
            string? suiteSelecionada = pck_quarto.SelectedItem?.ToString(); // Usando ? para evitar null reference
            int numeroAdultos = (int)stp_adultos.Value;
            int numeroCriancas = (int)stp_criancas.Value;

            // Verifique se a su�te foi selecionada
            if (string.IsNullOrEmpty(suiteSelecionada))
            {
                // Exibir um alerta caso nenhuma su�te tenha sido selecionada
                await DisplayAlert("Erro", "Selecione uma su�te para continuar", "OK");
                return;
            }

            // Navegar para a p�gina ComandaReserva, passando os dados
            await Navigation.PushAsync(new ComandaReserva(suiteSelecionada, numeroAdultos, numeroCriancas));
        }
    }
}
