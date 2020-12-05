using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tontine.BO;
using Tontine.DAO;

namespace Tontine.BLL
{
    public class MemberBLO
    {
        MemberDAO memberRepo;
        public MemberBLO()
        {
            memberRepo = new MemberDAO();
        }
        public void CreateMember(Member member)
        {
            memberRepo.Add(member);
        }
        public void DeleteMember(Member member)
        {
            memberRepo.Delete(member);
        }
        public IEnumerable<Member> GetAllMembers()
        {
            return memberRepo.Find();
        }
        public IEnumerable<Member> GetByIdentifier(string identifier)
        {
            return memberRepo.Find(x => x.Identifier == identifier);
        }
        public IEnumerable<Member> GetBy(Func<Member, bool> predicate)
        {
            return memberRepo.Find(predicate);
        }
        public void EditMember(Member oldMember, Member newMember)
        {
            memberRepo.Set(oldMember, newMember);
        }
    }
}
