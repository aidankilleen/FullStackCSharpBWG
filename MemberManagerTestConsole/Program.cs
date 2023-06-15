
using MemberManagerLibrary;
using System.Threading.Channels;

Console.WriteLine("Hello, World!");

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

IMemberManager mgr = new SqlServerMemberManager();

mgr.GetAll()
    .ForEach(member => Console.WriteLine(member));






