// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Worldfff!");


String myout(String input, out int lengthString)
{
    lengthString = input.Length;
    return input;
}

string myinputstring = "deine mudda";
int lengthString;

//Beim Aufrufen der Funktion mit dem Parameter "out" muss diese (ohne Deklaration int)
//mit aufgeführt werden
string outputString = myout(myinputstring, out lengthString);

Console.WriteLine(outputString + " " + lengthString);

int BerechneQuadrat(int zahl, out int quadrierteZahl)
{
    quadrierteZahl = zahl * zahl;
    return zahl; // Funktion gibt den ursprünglichen Wert 'zahl' zurück
}

int zahl = 5;
int quadrierteZahl;

int ergebnis = BerechneQuadrat(zahl, out quadrierteZahl);
Console.WriteLine($"Ergebnis: {ergebnis}, Quadrat: {quadrierteZahl}");