// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;

var text = "Wer reitet so spät durch Nacht und Wind?";
string pattern = @"[a-c]+"; // regulärer Ausdruck für Kleinbuchstaben

Regex regex = new Regex(pattern);

MatchCollection matches = regex.Matches(text);

Console.WriteLine("Gefundene Treffer:");
foreach (Match match in matches)
{
    Console.WriteLine(match.Value);
}
