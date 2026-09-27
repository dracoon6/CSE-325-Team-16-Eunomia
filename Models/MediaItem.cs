namespace CSE_325_Team_16_Eunomia.Models;

public class MediaItem
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Category { get; set; } = "Movies";
    public string Status { get; set; } = "Want to Try";
    public int? Rating { get; set; }
    public string Notes { get; set; } = string.Empty;
    public DateTime? StartedOn { get; set; }
    public DateTime? CompletedOn { get; set; }
    public DateTime DateAdded { get; set; } = DateTime.Now;
}
