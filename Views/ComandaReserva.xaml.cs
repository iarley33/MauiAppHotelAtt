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

            // Definir as informa��es passadas para a p�gina
            SuiteSelecionada = suiteSelecionada;
            NumeroAdultos = numeroAdultos;
            NumeroCriancas = numeroCriancas;

            // Calcular o valor total
            CalcularValorTotal();

            // Definir o binding para os elementos da p�gina
            BindingContext = this;
        }

        private void CalcularValorTotal()
        {
            double precoSuite = 0;

            // Definir o pre�o das su�tes
            switch (SuiteSelecionada)
            {
                case "Su�te Luxuosa":
                    precoSuite = 500; // Exemplo de pre�o
                    break;
                case "Su�te Executiva":
                    precoSuite = 350; // Exemplo de pre�o
                    break;
                case "Su�te Presidencial":
                    precoSuite = 1000; // Exemplo de pre�o
                    break;
            }

            // Calcular o valor total: pre�o da su�te + valor por adulto e metade do valor por crian�a
            ValorTotal = precoSuite + (NumeroAdultos * precoSuite) + (NumeroCriancas * (precoSuite / 2));
        }

        private async void OnConfirmarClicked(object sender, EventArgs e)
        {
            // Aqui voc� pode adicionar a l�gica de finaliza��o da reserva
            await DisplayAlert("Reserva Confirmada", "Sua reserva foi confirmada!", "OK");
        }
    }
}
