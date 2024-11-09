namespace OSSimulation
{
    public partial class WelcomePage : ContentPage
    {
        public WelcomePage(string nickname)
        {
            InitializeComponent();
            WelcomeLabel.Text = $"Hi {nickname}, Welcome Aboard";
        }

        private async void OnAlrightClicked(object sender, EventArgs e)
        {
            // Assuming you want to navigate to the MotivationPage when the button is clicked
            await Navigation.PushAsync(new MotivationPage());
        }
    }
}