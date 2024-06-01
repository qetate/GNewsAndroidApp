using GNewsAndroidApp.Models;
using GNewsAndroidApp.Services;
using GNewsAndroidApp.Views;

namespace GNewsAndroidApp
{
    public partial class MainPage : ContentPage
    {
        // List to hold GNewsCategory objects
        public List<GNewsCategory> GNewsCategories { get; set; } = new List<GNewsCategory>();

        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Adding predefined news categories to the list
            GNewsCategories.Add(new GNewsCategory { Name = "general" });
            GNewsCategories.Add(new GNewsCategory { Name = "world" });
            GNewsCategories.Add(new GNewsCategory { Name = "nation" });
            GNewsCategories.Add(new GNewsCategory { Name = "business" });
            GNewsCategories.Add(new GNewsCategory { Name = "entertainment" });
            GNewsCategories.Add(new GNewsCategory { Name = "sports" });
            GNewsCategories.Add(new GNewsCategory { Name = "science" });
            GNewsCategories.Add(new GNewsCategory { Name = "health" });

            // Set the ItemsSource of cvCategories to GNewsCategories
            cvCategories.ItemsSource = GNewsCategories;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            // Retrieve news
            GetNews();
        }

        // Method to retrieve news
        private async void GetNews()
        {
            GNewsAPI newsAPI = new GNewsAPI();
            // Retrieve news for the "general" category
            var results = await newsAPI.GetNews("general");

            // Set the ItemsSource of cvNews to the articles obtained
            cvNews.ItemsSource = results.articles;
        }

        // Event handler for category selection change
        private async void cvCategories_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedCategory = e.CurrentSelection.FirstOrDefault() as GNewsCategory;
            GNewsAPI newsAPI = new GNewsAPI();
            // Retrieve news for the selected category
            var results = await newsAPI.GetNews(selectedCategory.Name);
            // Set the ItemsSource of cvNews to the articles obtained
            cvNews.ItemsSource = results.articles;
        }

        // Event handler for news item selection change
        private void cvNews_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var article = e.CurrentSelection.FirstOrDefault() as Article;
            // Navigate to the NewsDetailsPage with the selected article
            Navigation.PushAsync(new NewsDetailsPage(article));
        }
    }
}