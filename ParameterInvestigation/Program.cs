﻿using ParameterInvestigation;

Console.WriteLine("Parameter Investigation");

Message m = new Message { Title = "M1", Text = "This is Message 1" };


MessageManager mm = new MessageManager();

mm.DisplayAll();



Message? msg = mm.GetMessage();

// ?. is the null conditional operator
Console.WriteLine(msg?.Title);

// equivalent to the following:
// Console.WriteLine(msg != null ? msg.Title : "");




mm.AddMessage(new Message { Title = "New Message", Text = "A New Message" });

Console.WriteLine("New List:");


mm.DisplayAll();


Member member = new Member { Id = 1, Name = "Alice", Email = "alice@gmail.com", Active = true };


Console.WriteLine(member);


MemberManager mgr = new MemberManager();

mgr.AddMember(new Member { Id = 1, Name = "Alice", Email = "alice@gmail.com", Active = true });
mgr.AddMember(new Member { Id = 2, Name = "Bob", Email = "bob@gmail.com", Active = false });
mgr.AddMember(new Member { Id = 3, Name = "Carol", Email = "carol@gmail.com", Active = false });
mgr.AddMember(new Member { Id = 4, Name = "Dan", Email = "dan@gmail.com", Active = true });


mgr.DisplayAll();


Member? mbr = mgr.FindById(4);

Console.WriteLine($"{(mbr == null ? "Not Found" : mbr.Name)}");


Console.WriteLine("Active Members:");
List<Member> activeMembers = mgr.GetActiveMembers();

foreach  (Member am in activeMembers) 
{
    Console.WriteLine(am);
}



string s1 = "a string";

//char c1 = 'a';

//char c2 = "b";








//string s2 = 'another string';

//string s3 = `yet another string`;


