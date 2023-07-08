namespace ShemaBug.Events;

public abstract class EntityEventBase
{
    public Guid Id { get; set; }
    public string Payload { get; set; }
}