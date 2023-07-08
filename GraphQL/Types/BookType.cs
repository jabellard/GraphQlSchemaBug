using HotChocolate.Types.Pagination;
using ShemaBug.Entities;
using ShemaBug.Events;

namespace ShemaBug.GraphQL.Types;

public class BookType: ObjectType<Book>
{
    protected override void Configure(IObjectTypeDescriptor<Book> descriptor)
    {
        descriptor.Name(nameof(Book));
        descriptor.Description(nameof(Book));
        descriptor
            .Field("events")
            .UseOffsetPaging<BookEventType>(options: new PagingOptions
            {
                IncludeTotalCount = true
            })
            .Resolve((context, _) =>
            {
                var book = context.Parent<Book>();
                var events = new List<BookEvent>()
                {
                    new()
                    {
                        Id = Guid.NewGuid(),
                        BookId = book.Id,
                        Payload = "{}"
                    },
                    new()
                    {
                        Id = Guid.NewGuid(),
                        BookId = book.Id,
                        Payload = "{}"
                    },
                    new()
                    {
                        Id = Guid.NewGuid(),
                        BookId = book.Id,
                        Payload = "{}"
                    }
                };
                return events;
            });
    }
}