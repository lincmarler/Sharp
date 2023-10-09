using Sharp.Models;

namespace Sharp.Services;


public class DogsService
{
    private readonly DogsRepository _repo;
    public DogsService(DogsRepository repo)
    {
        _repo = repo;
    }

    internal Dog CreateDog(Dog dogData)
    {
        Dog dog = _repo.CreateDog(dogData);
        return dog;
    }

    internal List<Dog> GetDogs()
    {
        List<Dog> dogs = _repo.GetAllDogs();
        return dogs;
    }

    internal Dog GetOneDogById(int dogId)
    {
        Dog dog = _repo.getOneDogById(dogId);
        if (dog == null) throw new Exception($"no dog at {dogId}");
        return dog;
    }

    internal string RemoveDog(int dogId)
    {
        Dog dog = this.GetOneDogById(dogId);
        _repo.RemoveDog(dogId);
        return $"{dog.Name} has been dead";
    }
}