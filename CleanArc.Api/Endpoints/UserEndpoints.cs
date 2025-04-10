using CleanArc.Shared.Requests;
using CleanArc.Shared.Responses;
using Bogus;

namespace CleanArc.Api.Endpoints;

public static class UserEndpoints
{
    public static void MapUserEndpoints(this IEndpointRouteBuilder app)
    {
        app.MapGet("/users", () =>
        {
            var faker = new Faker<UserResponse>()
                .RuleFor(u => u.Id, f => Guid.NewGuid())
                .RuleFor(u => u.Name, f => f.Name.FullName())
                .RuleFor(u => u.Email, f => f.Internet.Email());

            var usersList = faker.Generate(20);

            return Results.Ok(usersList);
        });

        app.MapPost("/users", (UserRequest request) => Results.Created($"/users", (object?)request));
    }
}