

using ShemaBug.GraphQL;
using ShemaBug.GraphQL.Types;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddGraphQLServer()
    .AddType<AuthorEventType>()
    .AddType<AuthorType>()
    .AddType<BookEventType>()
    .AddType<BookType>()
    .AddQueryType<Query>();

var app = builder.Build();
app.MapGraphQL();
app.Run("http://localhost:9001");