
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

Member m = mgr.FindById(10);

m.Name = "CHANGED";
m.Email = "changed@gmail.com";
m.Active = !m.Active;

mgr.Update(m);

mgr.GetAll()
    .ForEach(member => Console.WriteLine(member));








