using System;
using System.Collections.Generic;
using System.Text;

namespace MemberManagerLibrary
{
    public interface IMemberManager
    {
        Member AddMember(Member member);
        void Delete(int id);
        void DisplayAll();
        Member? FindById(int id);
        List<Member> GetActiveMembers();
        List<Member> GetAll();
        void Update(Member memberToUpdate);
        void Close();
    }
}
