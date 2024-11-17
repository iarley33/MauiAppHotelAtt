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

        // Evento que será chamado quando o botão "Avançar" for clicado
        private async void OnAvancarClicked(object sender, EventArgs e)
        {
            // Obter as informações de suíte selecionada e números de adultos e crianças
            string? suiteSelecionada = pck_quarto.SelectedItem?.ToString(); // Usando ? para evitar null reference
            int numeroAdultos = (int)stp_adultos.Value;
            int numeroCriancas = (int)stp_criancas.Value;

            // Verifique se a suíte foi selecionada
            if (string.IsNullOrEmpty(suiteSelecionada))
            {
                // Exibir um alerta caso nenhuma suíte tenha sido selecionada
                await DisplayAlert("Erro", "Selecione uma suíte para continuar", "OK");
                return;
            }

            // Navegar para a página ComandaReserva, passando os dados
            await Navigation.PushAsync(new ComandaReserva(suiteSelecionada, numeroAdultos, numeroCriancas));
        }
    }
}
