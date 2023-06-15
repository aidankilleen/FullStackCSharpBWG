﻿
using MemberManagerLibrary;
using System.Threading.Channels;

Console.WriteLine("SqlServerMemberManager Test Suite");

IMemberManager mgr = new SqlServerMemberManager();


Member newMember = new Member { Name = "','',0);delete from members where id=17;--" };

mgr.AddMember(newMember);





/*
Member member = new Member { Id = 1, Name = "Alice", Email = "alice@gmail.com", Active = true };

Console.WriteLine(member);
*/

/*
MemberManager mgro = new MemberManager();

mgro.GetAll()
    .ForEach(member => Console.WriteLine(member));

Console.WriteLine("================================");


SqlServerMemberManager mgr = new SqlServerMemberManager();


mgr.GetAll()
    .ForEach(member => Console.WriteLine(member));

*/


/*
mgr.GetAll()
    .ForEach(member => Console.WriteLine(member));


Member? m = mgr.FindById(2);
Console.WriteLine("===========");
Console.WriteLine(m);

Console.WriteLine("===========");
mgr.Delete(19);

mgr.GetAll()
    .ForEach(member => Console.WriteLine(member));

*/
/*
Member m = mgr.FindById(10);

m.Name = "CHANGED";
m.Email = "changed@gmail.com";
m.Active = !m.Active;

mgr.Update(m);

mgr.GetAll()
    .ForEach(member => Console.WriteLine(member));
*/

/*
Member m = new Member
{
    Name = "Aidans New Member",
    Email = "aidans.new.member@gmail.com",
    Active = true
};

Member addedMember = mgr.AddMember(m);

Console.WriteLine(addedMember);
*/

/*
mgr.GetAll()
    .ForEach(member => Console.WriteLine(member));


mgr.Close();

*/










