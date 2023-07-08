using HotChocolate.Types.Pagination;
using ShemaBug.Entities;
using ShemaBug.GraphQL.Types;

namespace ShemaBug.GraphQL;

public class Query: ObjectType
{
    protected override void Configure(IObjectTypeDescriptor descriptor)
    {
        descriptor.Name(OperationTypeNames.Query);
        descriptor
            .Field("authors")
            .UseOffsetPaging<AuthorType>(options: new PagingOptions
            {
                IncludeTotalCount = true
            })
            .Resolve(_ =>
            {
                var authors = new List<Author>
                {
                    new()
                    {
                        Id = Guid.NewGuid(),
                        FirstName = Guid.NewGuid().ToString(),
                        LastName = Guid.NewGuid().ToString()
                    },
                    new()
                    {
                        Id = Guid.NewGuid(),
                        FirstName = Guid.NewGuid().ToString(),
                        LastName = Guid.NewGuid().ToString()
                    },
                    new()
                    {
                        Id = Guid.NewGuid(),
                        FirstName = Guid.NewGuid().ToString(),
                        LastName = Guid.NewGuid().ToString()
                    }
                };
                return authors;
            });
    }
}