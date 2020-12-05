using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tontine.BO;

namespace Tontine.DAL
{
    public class UserDAO
    {
        private static List<User> users;
        private const string File_name=@"Prijet_Tontine/Data/user.json";
        private FileInfo file;
        public UserDAO()
        {
            file = new FileInfo(File_name);
            if (!file.Directory.Exists)
            {
                file.Directory.Create();
            }
            if (!file.Exists)
            {
                file.Create().Close();
                file.Refresh();
            }
            if (file.Length > 0)
            {
                using (StreamReader sr = new StreamReader(file.FullName))
                {
                    string json = sr.ReadToEnd();
                    users = JsonConvert.DeserializeObject<List<User>>(json);
                }
            }
            if (users == null)
            {
                users = new List<User>();
            }
        }
        public void Set(User oldUser, User newUser)
        {
            var oldIndex = users.IndexOf(oldUser);
            var newIndex = users.IndexOf(newUser);
            if (oldIndex < 0)
                throw new KeyNotFoundException("This user doesn't exists !");
            if (newIndex > 0 && oldIndex != newIndex)
                throw new DuplicateNameException("This user's identifier already exists !");
            users[oldIndex] = newUser;
            Save();
        }
        public void Add(User user)
        {
            users.Add(user);
            Save();
        }
        private void Save()
        {
            using (StreamWriter sw = new StreamWriter(file.FullName))
            {
                string json = JsonConvert.SerializeObject(users);
                sw.WriteLine(json);
            }
        }

        public void Delete(User user)
        {
            users.Remove(user); /*base sur le aquals de son BO*/
            Save();
        }

        public IEnumerable<User> Find()
        {
            return new List<User>(users);
        }

        public IEnumerable<User> Find(Func<User, bool> predicate)
        {
            return new List<User>(users.Where(predicate).ToArray());
        }
    }
}
