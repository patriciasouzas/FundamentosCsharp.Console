// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Principais métodos

var frase = "     C# é uma linguagem moderna e versário." +
	"Com C# você consegue desenvolver para web, desktop, jogos," +
	"Mobile, entre outros. ";

var tamanho = frase.Length;

var vazio = string.Empty;

var paragrafoMinusculo = frase.ToLower();
var paragrafoMaiusculo = frase.ToUpper();

var frases = frase.Split('.');

var fraseTrim = frase.Trim();
var fraseTrimEnd = frase.TrimEnd();
var fraseTrimStart = frase.TrimStart();

var isNullOrWhiteSpace = string.IsNullOrWhiteSpace(frase);

// Métodos de busca

var indexOf = frase.IndexOf("C#");

var lastIndexOf = frase.LastIndexOf("C#");

var starsWith = frase.StartsWith("C#");

var substring = frase.Substring(0, indexOf);

var substringMobile = frase.Substring(indexOf);

var constains = frase.Contains("jogos", StringComparison.OrdinalIgnoreCase);