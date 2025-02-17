using System;

public class IceCream
{
    // Field(s)
    public string Type;
}

    // Inheritance
public class Receptacle : IceCream
{
    public int Flavor;

}

    // To display info
class DisplayIceCreamInfo
{
    static void Main()
    {
        Receptacle Bowl = new Receptacle { Type = "Gelato", Flavor = "Strawberry" };
        Console.WriteLine($"This Ice Cream is a {Bowl.Flavor} flavored {Bowl.Type}");

        Receptacle Cone = new Receptacle { Type = "Italian Ice", Flavor = "Lemon" };
        Console.WriteLine($"This Ice Cream is a {Cone.Flavor} flavored {Cone.Type}");
    }
}
