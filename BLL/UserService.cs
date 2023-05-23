

using DAL;
using DTO;
using Microsoft.EntityFrameworkCore;
using Model;

namespace BLL
{
    public class UserService
    {
        private Context _context = new Context();


        public void Test()
        {
            _context.Users.Add(new User("Prueba", "Probando","asdfasdf",true));

            _context.SaveChanges();
        }

        public List<UserDTO> GetAllUsers()
        {
            return _context.Users
              .ToList()
              .Select(model => new UserDTO
              {
                  Id = model.Id,
                  Name = model.Name,
                  Email = model.Email,
                  IsAdmin = model.IsAdmin,
                  Password = model.Password,
              })
              .ToList();
        }

        public User GetUserById(int id)
        {
            return _context.Users.FirstOrDefault(u => u.Id == id);
        }

        public void CreateUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public void UpdateUser(User user)
        {
            _context.Entry(user).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteUser(int id)
        {
            User user = _context.Users.Find(id);
            if (user != null)
            {
                _context.Users.Remove(user);
                _context.SaveChanges();
            }
        }

        public bool CanCreateChallenge(User user)
        {
            return user.IsAdmin;
        }

        public void CreateChallenge(User user, Challenge challenge)
        {
            if (CanCreateChallenge(user))
            {
               
            }
            else
            {
               
            }
        }




    }
}
