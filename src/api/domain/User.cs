namespace domain;

public class User: Base
{
    public User(string name, string surName, DateTime loadDate)
    {
        Name = name;
        SurName = surName;
        LoadDate = loadDate;
    }

    public required string Name { get; set; }
    public required string SurName { get; set; }
    public required DateTime LoadDate { get; set; }

    public override bool Equals(object? obj)
    {
        return obj is User user &&
               Name == user.Name &&
               SurName == user.SurName &&
               LoadDate == user.LoadDate;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Name, SurName, LoadDate);
    }
}
