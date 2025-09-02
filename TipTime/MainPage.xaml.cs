namespace TipTime
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
       // float = 


        public MainPage()
        {
            InitializeComponent();
     
        }

       

        private void ArredondaCimaBtn_Clicked(object sender, EventArgs e)
        {
            count++;

        }

        private void Porcentagem15Btn_Clicked(object sender, EventArgs e)
        {
            PorcentagemSlider.Value = 15;
        }

        private void Porcentagem20Btn_Clicked(object sender, EventArgs e)
        {
            PorcentagemSlider.Value = 20;
        }

        private void ArredondaBaixoBtn_Clicked(object sender, EventArgs e)
        {
            //PorcentagemGorjetaLabel = ValorTotalEntry; 
            
        }


        private void PorcentagemSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            // ValorGorjetaLabel = ValorFinalLabel * (PorcentagemGorjetaLabel / 100);

           // ValorTotalEntry = float;


        }
    }

}
