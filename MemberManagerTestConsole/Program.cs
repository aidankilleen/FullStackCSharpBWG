
using MemberManagerLibrary;
using System.Threading.Channels;

Console.WriteLine("Hello, World!");


Member member = new Member { Id = 1, Name = "Alice", Email = "alice@gmail.com", Active = true };

Console.WriteLine(member);

MemberManager mgr = new MemberManager();


mgr.GetAll()
    .ForEach(member => Console.WriteLine(member));





