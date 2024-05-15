namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private async void EtudierButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StudyThemes());
        }

        private async void MesCartesButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MyThemes());
        }

        private async void ParametresButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Options());
        }

    }

}
