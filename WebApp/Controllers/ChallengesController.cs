using BLL;
using DTO;
using Microsoft.AspNetCore.Mvc;

namespace aspnetCoreAngular.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ChallengesController : ControllerBase
    {
        private readonly ILogicService _logic;

        public ChallengesController(ILogicService logic)
        {
            _logic = logic;
        }

        [HttpGet]
        public bool Test()
        {
            _logic.Challenges.Test();

            return true;
        }

        [HttpGet]
        public List<ChallengeDTO> List()
        {
            return _logic.Challenges.All();
        }

        [HttpGet]
        public ChallengeDTO GetById(int id)
        {
            return _logic.Challenges.GetById(id);
        }
    }
}
