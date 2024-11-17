using Microsoft.Maui.Controls;

namespace MauiAppHotelAtt.Views
{
    public partial class ComandaReserva : ContentPage
    {
        public string SuiteSelecionada { get; set; }
        public int NumeroAdultos { get; set; }
        public int NumeroCriancas { get; set; }
        public double ValorTotal { get; set; }

        public ComandaReserva(string suiteSelecionada, int numeroAdultos, int numeroCriancas)
        {
            InitializeComponent();

            // Definir as informações passadas para a página
            SuiteSelecionada = suiteSelecionada;
            NumeroAdultos = numeroAdultos;
            NumeroCriancas = numeroCriancas;

            // Calcular o valor total
            CalcularValorTotal();

            // Definir o binding para os elementos da página
            BindingContext = this;
        }

        private void CalcularValorTotal()
        {
            double precoSuite = 0;

            // Definir o preço das suítes
            switch (SuiteSelecionada)
            {
                case "Suíte Luxuosa":
                    precoSuite = 500; // Exemplo de preço
                    break;
                case "Suíte Executiva":
                    precoSuite = 350; // Exemplo de preço
                    break;
                case "Suíte Presidencial":
                    precoSuite = 1000; // Exemplo de preço
                    break;
            }

            // Calcular o valor total: preço da suíte + valor por adulto e metade do valor por criança
            ValorTotal = precoSuite + (NumeroAdultos * precoSuite) + (NumeroCriancas * (precoSuite / 2));
        }

        private async void OnConfirmarClicked(object sender, EventArgs e)
        {
            // Aqui você pode adicionar a lógica de finalização da reserva
            await DisplayAlert("Reserva Confirmada", "Sua reserva foi confirmada!", "OK");
        }
    }
}
