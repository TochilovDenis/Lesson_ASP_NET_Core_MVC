namespace MvcApp6_0.Models
{
    public class VideoCard
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string AltText { get; set; } = string.Empty;

        public VideoCard() { }

        public VideoCard(int id, string imageUrl, string title, string description, string altText = "")
        {
            Id = id;
            ImageUrl = imageUrl;
            Title = title;
            Description = description;
            AltText = string.IsNullOrEmpty(altText) ? title : altText;
        }
    }
}