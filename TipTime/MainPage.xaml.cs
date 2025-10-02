namespace TipTime
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }


        private void Porcentagem15Btn_Clicked(object sender, EventArgs e)
        {
            PorcentagemSlider.Value = 15;
        }

        private void Porcentagem20Btn_Clicked(object sender, EventArgs e)
        {
            PorcentagemSlider.Value = 20;
        }



        private void ArredondaCimaBtn_Clicked(object sender, EventArgs e)
        {
            //convert -> refere-se à conversão de tipo ou conversão de dados entre diferentes tipos de dados
            double gorjeta = Convert.ToDouble(ValorTotalEntry.Text);
            double ValorGorjetaLabel = gorjeta * (PorcentagemSlider.Value / 100);
            ValorGorjetaLabel = Math.Ceiling(ValorGorjetaLabel);
            double arredondadoPraCima = Math.Ceiling(gorjeta / 10) * 10;
            ValorTotalEntry.Text = arredondadoPraCima.ToString();
        }



        private void ArredondaBaixoBtn_Clicked(object sender, EventArgs e)
        {
            double gorjeta = Convert.ToDouble(ValorTotalEntry.Text);
            double arredondadoPraBaixo = Math.Floor(gorjeta / 10) * 10;
            ValorTotalEntry.Text = arredondadoPraBaixo.ToString();

        }


        private void PorcentagemSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {

            double valor = Convert.ToDouble(ValorTotalEntry.Text);
            double porcetagem = e.NewValue; //-> dados recem alterados
            double gorjeta = valor * (porcetagem / 100);
            double valorFinal = valor + gorjeta;
            double gorjetaArredondada = Math.Round(gorjeta);
            double valorArredondado = Math.Round(valorFinal);
            ValorGorjetaLabel.Text = porcetagem.ToString();

            ValorGorjetaLabel.Text = $"Gorjeta: {gorjeta:C}";
            ValorFinalLabel.Text = $"Total com Gorjeta: {valorFinal}";

        }


    }

}
