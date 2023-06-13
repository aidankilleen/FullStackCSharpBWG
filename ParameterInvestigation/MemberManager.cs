using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterInvestigation
{
    internal class MemberManager
    {
        List<Member> members = new List<Member>();

        public void AddMember(Member member)
        {
            members.Add(member);
        }
        public void DisplayAll()
        {
            foreach (Member member in members) {

                Console.WriteLine(member);
            }
        }
        public Member? FindById(int id)
        {
            Member? m = members.Find(member => {

                Console.WriteLine($"Checking:{member.Name}");
                return member.Id == id;
            });
            return m;
        }

        public List<Member> GetActiveMembers()
        {
            return members.FindAll(member => member.Active);
        }

        public List<Member> GetAll()
        {
            return members;
        }

        public void Delete(int id)
        {
            int index = members.FindIndex(member => member.Id == id);
            if (index !=-1)
            {
                members.RemoveAt(index);
            }
        }

        public void Update(Member memberToUpdate)
        {
            int index = members.FindIndex(member => member.Id == memberToUpdate.Id);
            if (index !=-1)
            {
                members.RemoveAt(index);
                members.Insert(index, memberToUpdate);
            }
        }


        /*
        public Member? FindById(int id)
        {
            Member? m = members.Find((member) =>
            {
                Console.WriteLine($"testing {member.Name}");
                if (member.Id == id)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            });
            return m;
        }
        */

    }
}
