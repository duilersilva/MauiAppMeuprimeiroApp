namespace MauiAppMeuprimeiroApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {   
                double etanol = Convert.ToDouble(txt_etanol.Text);
                double gasolina = Convert.ToDouble(txt_gasolina.Text);
                string marca = (txt_marca.Text);
                string modelo = (txt_modelo.Text);

                string msg = "" ;


                if (etanol <= (gasolina * 0.7))
                {
                    msg = "O Etanol está Compensando para seu " + marca + " Modelo: " + modelo;

                }
                else
                {
                    msg = "A Gasolina está Compensando para seu " + marca + " Modelo: " + modelo;
                }

                DisplayAlert("Calculado", msg, "OK");

            } catch (Exception ex)
            {
                DisplayAlert("OPS", ex.Message, "FECHAR");
            }

        }//fecha método
    }// fecha class

}//fecha namespace
