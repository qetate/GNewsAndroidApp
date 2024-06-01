using GNewsAndroidApp.Models;

namespace GNewsAndroidApp.Views
{
    public partial class NewsDetailsPage : ContentPage
    {
        private Article article;

        // Constructor
        public NewsDetailsPage(Article article)
        {
            InitializeComponent();
            this.article = article;
        }

        // Method called when the page appears
        protected override void OnAppearing()
        {
            base.OnAppearing();
            // Set UI elements with article data
            ArticleImage.Source = article.image;
            ArticleTitle.Text = article.title;
            ArticleContent.Text = article.content;
            ArticleUrl.Text = article.url;
        }

        // Event handler for tap gesture on the URL
        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            // Open the article URL in the system browser
            Uri uri = new Uri(article.url);
            var results = await Browser.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        }

        // Event handler for back button click
        private void btnBack_Clicked(object sender, EventArgs e)
        {
            // Navigate back
            Navigation.PopAsync();
        }
    }
}