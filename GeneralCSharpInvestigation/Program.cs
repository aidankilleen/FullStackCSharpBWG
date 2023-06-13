Console.WriteLine("General C# Investigation");

// strings

string name = "Aidan";


string message = $"Welcome { name }";


string longMessage = "this\n" +
                     "is\n" +
                     "a multi line\n" +
                     "message";

Console.WriteLine(longMessage);

// raw string
longMessage = @"this \n
is
a multi-line
message";

Console.WriteLine(longMessage);

string url = "c:\\My Documents\\docs\\file.txt";

Console.WriteLine(url);


url = @"c:\My Documents\docs\file.txt";

Console.WriteLine(url);


string file = "somefile.txt";

// raw interpolated string
string path = $@"c:\my documents\{ file }";

Console.WriteLine(path);


string msg = @"this 
               is
                a
                multiline string";


Console.WriteLine(msg);

// var keyword (implicitly typed variables)

string myMessage = "this is a message";

var aMessage = "this is a message";


// aMessage = 42;

// var someVar;  // implicitly typed variables must be initialised














































