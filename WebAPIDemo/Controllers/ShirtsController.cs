using Microsoft.AspNetCore.Mvc;

namespace WebAPIDemo.Controllers
{
    // Explanation: Now, 3 things make this class a Web API Controller.
    // 1. [ApiController]
    // 2. the class must be Deriving from ControllerBase
    // 3. and naming the clas <something>Controller

    [ApiController]
    public class ShirtsController : ControllerBase
    {
        // https://localhost:7134/shirts
        public string GetShirts()
        {
            return "Reading all the shirts";
        }

        public string GetSHirtById(int id) 
        {
            return $"Reading shirt: {id}";
        }

        public string CreateShirt()
        {
            return $"Creating a shirt";
        }

        public string UpdateShirt(int id)
        {
            return $"Updating shirt: {id}";
        }

        public string DeleteShirt(int id)
        {
            return $"Deleting shirt: {id}";
        }
    }
}
