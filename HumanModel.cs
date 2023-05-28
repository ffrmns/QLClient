namespace ZeroQL.TestApp;

public record HumanModel
{
    public HumanModel()
    {

    }

    public HumanModel(string name, string homePlanet, string id)
    {
        Name = name;
        HomePlanet = homePlanet;
        Id = id;
    }

    public string Name
    {
        get;
        init;
    }

    public string HomePlanet
    {
        get;
        init;
    }

    public string Id
    {
        get;
        init;
    }
}