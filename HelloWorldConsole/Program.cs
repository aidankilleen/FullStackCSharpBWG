// See https://aka.ms/new-console-template for more information


/*
 * 
 * 
 */



using HelloWorldConsole;

Console.WriteLine("Hello, World!");  // send a message

Console.WriteLine("this is a message");

string name = "Aidan";

// c# is strongly typed
//name = 42;

int count = 0;
double val = 1.2345;
bool b = true;


Console.WriteLine(name.Length);


int[] list = { 1, 2, 3, 4 };


Console.WriteLine(list[0]);
Console.WriteLine(list.Length);


//Console.WriteLine(list[5]);

for (int i = 0; i < list.Length; i++)
{
    Console.WriteLine(list[i]); 
}

foreach (int i in list)
{
    Console.WriteLine(i);
}


int index = 0;

while (index < list.Length)
{

    Console.WriteLine(list[index]);
    index = index + 1;


    if (index % 2 == 0)
    {
        Console.WriteLine(index + " even index");
        Console.WriteLine($"{ index } is an even index");
    }
    else
    {
        Console.WriteLine(index + " odd index");
        Console.WriteLine($"{index} is an odd index");
    }


    // ternary operator
    Console.WriteLine($"{index} is an {(index % 2 == 0 ? "even" : "odd")} index");


    Random r = new Random();

    int rv = r.Next(100);

    Console.WriteLine($"{rv} is a {(rv < 33 ? "small" : rv < 66 ? "medium" : "large")} number");


    





}

Message m = new Message("Message 1", "this is a message");

m.Display();

// normal rule for encapsulation is 
// member variables are private
//Console.WriteLine(m.text);
//Console.WriteLine(m.GetText());

Console.WriteLine(m.Text);


//m.text = "this is a different message";
//m.SetText("this is a different message");

m.Text = "this is a different message";
//Console.WriteLine(m.GetText());
Console.WriteLine(m.Text);


m.Text = "";

Console.WriteLine(m.Text);

m.Title = "Message 1";

m.Display();


Console.WriteLine("------------------------");


Message m2 = new Message { 
    Title = "Message 2", 
    Text = "This is message 2" 
};

m2.Display();


Console.WriteLine(m2);



Member member = new Member
{
    Id = 1,
    Name = "Alice",
    Email = "alice@gmail.com",
    Active = true
};

Console.WriteLine(member);


Member[] members =
{
    new Member {Id=1, Name="Alice", Email="alice@gmail.com", Active=true},
    new Member {Id=2, Name="Bob", Email="bob@gmail.com", Active=false},
    new Member {Id=3, Name="Carol", Email="carol@gmail.com", Active=false},
    new Member {Id=4, Name="Dan", Email="dan@gmail.com", Active=true}
};


foreach (Member mbr in members)
{
    Console.WriteLine(mbr);
}









































