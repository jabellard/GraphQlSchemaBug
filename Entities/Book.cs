namespace ShemaBug.Entities;

public class Book
{
    public Guid Id { get; set; }
    public Guid AuthorId { get; set; }
    public string Title { get; set; }
}