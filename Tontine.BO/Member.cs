using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tontine.BO
{
    [Serializable]
    public class Member
    {
        public string Identifier { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Telephone { get; set; }
        public string Sex { get; set; }
        public string Fonction { get; set; }

        public Member()
        {

        }

        public Member(string identifier, string firstName, string lastName, string telephone, string sex, string fonction)
        {
            Identifier = identifier;
            FirstName = firstName;
            LastName = lastName;
            Telephone = telephone;
            Sex = sex;
            Fonction = fonction;
        }

        public override bool Equals(object obj)
        {
            return obj is Member registration &&
                   Identifier == registration.Identifier;
        }

        public override int GetHashCode()
        {
            return 1186239758 + EqualityComparer<string>.Default.GetHashCode(Identifier);
        }
    }
}
