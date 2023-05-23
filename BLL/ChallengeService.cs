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
                    ChallengeId = model.ChallengeId,
                    Name = model.Name,
                    Description = model.Description
                })
                .ToList();
        }

        public void Test()
        {
            _context.Challenges.Add(new Challenge("Prueba", "Probando"));

            _context.SaveChanges();
        }

        public ChallengeDTO GetById(int id)
        {
            Challenge challange = _context.Challenges.Find(id);

            ChallengeDTO dto = new ChallengeDTO
            {
                ChallengeId = challange.ChallengeId,
                Name = challange.Name,
                Description = challange.Description
            };

            return dto;
        }
    }
}