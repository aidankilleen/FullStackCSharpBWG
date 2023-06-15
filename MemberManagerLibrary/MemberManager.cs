using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberManagerLibrary
{
    public class MemberManager : IMemberManager
    {
        List<Member> members = new List<Member>();

        public MemberManager()
        {
            members.Add(new Member { Id = 1, Name = "Alice", Email = "alice@gmail.com", Active = true });
            members.Add(new Member { Id = 2, Name = "Bob", Email = "bob@gmail.com", Active = false });
            members.Add(new Member { Id = 3, Name = "Carol", Email = "carol@gmail.com", Active = false });
            members.Add(new Member { Id = 4, Name = "Dan", Email = "dan@gmail.com", Active = true });
        }

        public void AddMember(Member member)
        {
            if (member.Id == 0)
            {
                // assign a new Id
                var maxId = 0;
                if (members.Count > 0)
                {
                    maxId = members.Max(member => member.Id);
                }
                member.Id = maxId + 1;

            }
            members.Add(member);
        }
        public void DisplayAll()
        {
            foreach (Member member in members)
            {

                Console.WriteLine(member);
            }
        }
        public Member? FindById(int id)
        {
            Member? m = members.Find(member =>
            {

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
            if (index != -1)
            {
                members.RemoveAt(index);
            }
        }

        public void Update(Member memberToUpdate)
        {
            int index = members.FindIndex(member => member.Id == memberToUpdate.Id);
            if (index != -1)
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
