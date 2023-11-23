// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var sete = "sete";
string valorNull = null;
var longValue = long.MaxValue.ToString();

try
{
	var formatException = int.Parse(sete);
	var argumentNullException = int.Parse(valorNull);
	var overFlowException = int.Parse(longValue);
}
catch(FormatException ex)
{
	Console.WriteLine($"Format Exception: {ex.Message}");
}
catch(ArgumentNullException ex)
{
	Console.WriteLine($"Argumento Null Exception: {ex.Message}");
}
catch(OverflowException ex)
{
	Console.WriteLine($"Overflow Exception: {ex.Message}");
}
finally
{
	Console.WriteLine("Este código é executado sempre.");
}

Console.ReadKey();