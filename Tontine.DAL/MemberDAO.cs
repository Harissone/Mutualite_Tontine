using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tontine.BO;

namespace Tontine.DAO
{
    public class MemberDAO
    {
        private static List<Member> members;
        private const string File_name = @"Projet_Tontine/Data/member.json";
        private FileInfo file;
        public MemberDAO()
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
                using(StreamReader sr=new StreamReader(file.FullName))
                {
                    string json = sr.ReadToEnd();
                    members = JsonConvert.DeserializeObject<List<Member>>(json);
                }
            }
            if (members == null)
            {
                members = new List<Member>();
            }
        }

        public void Set(Member oldMember, Member newMember)
        {
            var oldIndex = members.IndexOf(oldMember);
            var newIndex = members.IndexOf(newMember);
            if (oldIndex < 0)
                throw new KeyNotFoundException("This member doesn't exists !");
            if (newIndex > 0 && oldIndex != newIndex)
                throw new DuplicateNameException("This member's identifier already exists !");
            members[oldIndex] = newMember;
            Save();
        }

        public void Add(Member member)
        {
            members.Add(member);
            Save();
        }

        private void Save()
        {
            using (StreamWriter sw = new StreamWriter(file.FullName))
            {
                string json = JsonConvert.SerializeObject(members);
                sw.WriteLine(json);
            }
        }

        public void Delete(Member member)
        {
            members.Remove(member); /*base sur le aquals de son BO*/
            Save();
        }

        public IEnumerable<Member> Find()
        {
            return new List<Member>(members);
        }


        public IEnumerable<Member> Find(Func<Member, bool> predicate)
        {
            return new List<Member>(members.Where(predicate).ToArray());
        }
    }
}
