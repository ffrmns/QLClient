// See https://aka.ms/new-console-template for more information
// Based on https://github.com/byme8/ZeroQL/tree/main#graphql-lambda-syntax
// Server used https://github.com/graphql-dotnet/graphql-dotnet/blob/master/src/GraphQL.Harness/

using TestServer.Client;

Console.WriteLine("Hello, World!");

var httpClient = new HttpClient();
httpClient.BaseAddress = new Uri("http://localhost:62248/graphql");

var client = new TestServerGraphQLClient(httpClient);

var response = await client.Query(o => o.Human("1", o => new Human ( o.Id, o.Name )));

Console.WriteLine($"GraphQL: {response.Query}");
Console.WriteLine($"{response.Data?.Id}: {response.Data?.Name} {response.Data?.HomePlanet}");
class Human
{
    public string Id { get; set; }
    public string? Name { get; set; }
    public string? HomePlanet { get; set; }

    public Human(string id, string? name = null, string? homePlanet = null)
    {
        Id = id;
        Name = name;
        HomePlanet = homePlanet;
    }
}