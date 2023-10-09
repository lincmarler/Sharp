namespace Sharp.Models;

public class Dog
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Color { get; set; }
    public int Age { get; set; }
    public bool Kind { get; private set; }

    public float AgeInHumanYears
    {
        get { return Age * 7; }
    }

    public Dog(int id, string name, string color, int age, bool kind)
    {
        Id = id;
        Name = name;
        Color = color;
        Age = age;
        Kind = kind;
    }
}