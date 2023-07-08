namespace ShemaBug.Events;

public class AuthorEvent: EntityEventBase
{
    public Guid AuthorId { get; set; }
}