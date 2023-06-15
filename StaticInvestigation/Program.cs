
using StaticInvestigation;
using System.Reflection;

public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Static Investigation");
        Console.WriteLine(Message.Count);

        Message m = new Message { Title = "m1", Text = "This is m1" };

        Console.WriteLine(Message.Count);

        Message m2 = new Message { Title = "m2", Text = "This is m2" };

        Console.WriteLine(Message.Count);

        Message.GetCount();

        Message.Count = 0;

        Console.WriteLine(Message.Count);

        Console.WriteLine("Console.WriteLine() is a static function");

        Console.WriteLine(Math.PI);

        // use case 1 = constants
        Console.WriteLine(int.MinValue);
        Console.WriteLine(int.MaxValue);


        // use case - need a function not an object 
        Math.Cos(90);


        // use case - converions

        double d = 1.2345;

        // use a cast for compatible types
        int i = (int)d;

        string value = "27";

        // can't cast incompatible types!
        //i = (int)value;

        // use the static Parse function to convert
        i = int.Parse(value);

        Console.WriteLine(i);
    }
}

// value = "twenty seven";

// i = int.Parse(value);






























