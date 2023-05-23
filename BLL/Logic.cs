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
        UserService Users { get; }
    }
    public class LogicService: ILogicService
    {
        private ChallengeService _challenges = null;
        private UserService _users = null;
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

        public UserService Users
        {
            get
            {
                if (_users == null)
                {
                    _users = new UserService();
                }

                return _users;
            }
        }
    }
}
