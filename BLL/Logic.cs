using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public interface ILogicService
    {
        ChallengeService Challenges { get; }
    }
    public class LogicService: ILogicService
    {
        private ChallengeService _challenges = null;
        public ChallengeService Challenges
        {
            get
            {
                if (_challenges == null)
                {
                    _challenges = new ChallengeService();
                }

                return _challenges;
            }
        }
    }
}
