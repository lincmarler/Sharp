

[ApiController]
[Route("api/dogs")]
public class DogsController : ControllerBase
{

    private readonly DogsService _dogsService;
    public DogsController(DogsService ds)
    {
        _dogsService = ds;
    }

    [HttpGet("test")]
    public string getTest()
    {
        return "it worked";
    }


    [HttpGet]
    public ActionResult<List<Dog>> GetDogs()
    {
        try
        {
            List<Dog> dogs = _dogsService.GetDogs();
            return Ok(dogs);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }


    [HttpGet("{dogId}")]
    public ActionResult<Dog> GetOeDogById(int dogId)
    {
        try
        {
            Dog dog = _dogsService.GetOneDogById(dogId);
            return Ok(dog);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }


    [HttpPost]
    public ActionResult<Dog> CreateDog([FromBody] Dog dogData)
    {
        try
        {
            Dog dog = _dogsService.CreateDog(dogData);
            return Ok(dog);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }


    [HttpDelete("{dogId}")]
    public ActionResult<string> RemoveDog(int dogId)
    {
        try
        {
            string message = _dogsService.RemoveDog(dogId);
            return Ok(message);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}