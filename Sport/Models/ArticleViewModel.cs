namespace Sport.Models;

public class ArticleViewModel
{
    public int Id { get; set; }
    public string Description { get; set; }
    public string Title { get; set; }
    public string Text { get; set; }
    public string? ImgUrl { get; set; }
    public string Author { get; set; }
    public DateTime CreatedAt { get; set; }
    public List<CategoryViewModel>? Tags { get; set; }
}
