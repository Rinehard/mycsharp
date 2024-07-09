// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Worldfff!");


String myout(String input, out int lengthString)
{
    lengthString = input.lenght();
    return input;
}

int lengthString;
string myinputstring = "deine mudda";
string outputString = myout(myinputstring);

Console.WriteLine(outputString + " " + lengthString);

