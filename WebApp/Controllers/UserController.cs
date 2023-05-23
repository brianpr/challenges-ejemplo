using BLL;
using DTO;
using Microsoft.AspNetCore.Mvc;


namespace aspnetCoreAngular.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class UserController : ControllerBase
    {
        private readonly ILogicService _logic;

        public UserController(ILogicService logic)
        {
            _logic = logic;
        }

        [HttpGet]
        public List<UserDTO> List()
        {
            return _logic.Users.GetAllUsers();
        }

        [HttpGet]
        public bool Test()
        {
            _logic.Users.Test();

            return true;
        }
    }
}

