using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tontine.BO;
using Tontine.DAL;

namespace Tontine.BLL
{
    public class UserBLO
    {
        UserDAO userRepo;
        public UserBLO()
        {
            userRepo = new UserDAO();
        }
        public void CreateUser(User user)
        {
            userRepo.Add(user);
        }
        public void DeleteUser(User user)
        {
            userRepo.Delete(user);
        }
        public IEnumerable<User> GetAllUsers()
        {
            return userRepo.Find();
        }
        public IEnumerable<User> GetByIdentifier(string username)
        {
            return userRepo.Find(x => x.Username == username);
        }
        public IEnumerable<User> GetBy(Func<User, bool> predicate)
        {
            return userRepo.Find(predicate);
        }
        public void EditUser(User oldUser, User newUser)
        {
            userRepo.Set(oldUser, newUser);
        }
    }
}
