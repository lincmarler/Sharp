







namespace Sharp.Repositories;


public class DogsRepository
{
    private List<Dog> _FakeDb;

    public DogsRepository()
    {
        _FakeDb = new List<Dog>();
        _FakeDb.Add(new Dog(1, "Bucky", "Brown", 3, false));
        _FakeDb.Add(new Dog(2, "Roger", "Brown", 3, false));
        _FakeDb.Add(new Dog(3, "Steven", "Brown", 3, false));
    }

    internal Dog CreateDog(Dog dogData)
    {
        int dogId = _FakeDb[_FakeDb.Count - 1].Id;
        dogData.Id = dogId + 1;
        _FakeDb.Add(dogData);
        return dogData;
    }

    internal List<Dog> GetAllDogs()
    {
        return _FakeDb;
    }

    internal Dog getOneDogById(int dogId)
    {
        Dog dog = _FakeDb.Find(d => d.Id == dogId);
        return dog;
    }

    internal void RemoveDog(int dogId)
    {
        Dog dog = _FakeDb.Find(d => d.Id == dogId);
        _FakeDb.Remove(dog);
    }
}