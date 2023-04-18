using DAL;
using DTO;
using Model;

namespace BLL
{
    public class ChallengeService
    {
        private Context _context = new Context();

        public List<ChallengeDTO> All()
        {
            return _context.Challenges
                .ToList()
                .Select(model => new ChallengeDTO
                {
                    
                })
                .ToList();
        }

        public void Test()
        {
            _context.Challenges.Add(new Challenge("Prueba"));

            _context.SaveChanges();
        }
    }
}