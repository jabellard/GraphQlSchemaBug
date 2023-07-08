using ShemaBug.Entities;
using ShemaBug.Events;

namespace ShemaBug.GraphQL.Types;

public class AuthorType: ObjectType<Author>
{
    protected override void Configure(IObjectTypeDescriptor<Author> descriptor)
    {
        descriptor.Name(nameof(Author));
        descriptor.Description(nameof(Author));
        descriptor
            .Field("books")
            .Resolve((context, _) =>
            {
                var author = context.Parent<Author>();
                var books = new List<Book>
                {
                    new()
                    {
                        Id = Guid.NewGuid(),
                        AuthorId = author.Id,
                        Title = Guid.NewGuid().ToString()
                    },
                    new()
                    {
                        Id = Guid.NewGuid(),
                        AuthorId = author.Id,
                        Title = Guid.NewGuid().ToString()
                    },
                    new()
                    {
                        Id = Guid.NewGuid(),
                        AuthorId = author.Id,
                        Title = Guid.NewGuid().ToString()
                    }
                };
                return books;
            });
        descriptor
            .Field("events")
            .Resolve((context, _) =>
            {
                var author = context.Parent<Author>();
                var events = new List<AuthorEvent>()
                {
                    new()
                    {
                        Id = Guid.NewGuid(),
                        AuthorId = author.Id,
                        Payload = "{}"
                    },
                    new()
                    {
                        Id = Guid.NewGuid(),
                        AuthorId = author.Id,
                        Payload = "{}"
                    },
                    new()
                    {
                        Id = Guid.NewGuid(),
                        AuthorId = author.Id,
                        Payload = "{}"
                    }
                };
                return events;
            });
    }
}