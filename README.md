# GNews Android App

## Overview
The GNews Android App is a mobile app designed to display the latest news articles from various categories.

## Technologies Used
- **C#**: Programming language for used for app development.
- **Xamarin.Forms**: Cross-platform framework for Android apps.
- **HTTP Requests**: Integration with GNews API.
- **JSON Parsing**: Extracting data from API responses.
- **Xamarin.Essentials**: Handling external URLs.
- **MVVM Architecture**: Organizing app structure.

## Skills Demonstrated
- **C# Programming**: Used C# to develop app logic.
- **Xamarin.Forms Development**: Utilized Xamarin.Forms to create a mobile app.
- **API Integration**: Connecting to external API services.
- **JSON Parsing**: Extracting data from responses.

## Features
- **Category Selection**: Users can choose from news categories such as general, world, business, entertainment, sports, science, and health.
- **Article Display**: Show articles with titles, descriptions, and images.
- **Detailed View**: View article content and URLs.
- **External Link Handling**: Open URLs in device browser.

## Project Structure
- **GNewsCategory.cs**: Model class representing a news category.
- **GNewsModel.cs**: Model classes representing news articles and their properties.
- **GNewsAPI.cs**: Service class for making HTTP requests to the GNews API and fetching news data.
- **Mainpage.xaml.cs**: Main page of the app containing the category selection and news display logic.
- **NewsDetailPage.cs**: Page for displaying detailed information about a selected news article.

## Credits
- This app utilizes the [GNews API](https://gnews.io) for fetching news articles.