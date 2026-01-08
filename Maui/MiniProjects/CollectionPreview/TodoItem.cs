namespace CollectionPreview;

public class TodoItem
{
    public string Title { get; set; } = string.Empty;
    public DateTime Due { get; set; }
    public bool IsDone { get; set; }
}