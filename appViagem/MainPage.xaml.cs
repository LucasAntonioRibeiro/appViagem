namespace appViagem
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private void btn_CriarPedagio_Clicked(object sender, EventArgs e)
        {

        }

        private void btn_listaPedagio_Clicked(object sender, EventArgs e)
        {

        }

        private void btn_calcular_Clicked(object sender, EventArgs e)
        {

        }
    }

}
