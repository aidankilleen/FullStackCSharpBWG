Console.WriteLine("Exception Investigation");


int[] list = { 1, 2, 3 };


int answer = -1;

int x = 100;
int y = 0;

string nothing = null;

Random rnd = new Random();

var r = rnd.Next(4);

try
{
    if (r == 0)
    {
        answer = x / y;
    } else if (r == 1)
    {
        answer = list[3];
    } else if (r == 2)
    {
        Console.WriteLine("null pointer");
        answer = nothing.Length;
    } else if (r == 3)
    {
        // everything is fine
        Console.WriteLine("everything ok.");
        answer = 21;
    }
} catch (IndexOutOfRangeException ex)
{
    Console.WriteLine("Index out of range");
    answer = list[0];
} catch (DivideByZeroException ex)
{
    Console.WriteLine("Divide by zero");
    answer = 0;
} catch(Exception ex)
{
    Console.WriteLine("Something else went wrong");
    Console.WriteLine(ex.Message);
    answer = 0;
}

Console.WriteLine($"The answer is { answer }");



Console.WriteLine("finished");

/*
try
{
    DoSomething();
    DoSomethingElse();

}
catch(NotFoundException ex)
{

}
catch(NetworkException ex)
{

}
catch(BadValueException ex)
{

}

// everything ok

*/



/*
// glass is half empty 
int r = DoSomething();
if (r == -1)
{
    // not found
} else if (r == -2)
{
    // network error
} else if (r == -3)
{
    // bad value
} else
{
    // everything ok.
}
r = DoSomethingElse();
if (r == -1)
{
    // not found
}
else if (r == -2)
{
    // network error
}
else if (r == -3)
{
    // bad value
}
else
{
    // everything ok.
}
*/
