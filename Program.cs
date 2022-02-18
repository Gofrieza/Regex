// See https://aka.ms/new-console-template for more information
using RegexPattern;

Console.WriteLine("Hello, World!");


Patterns patterns = new Patterns();
//Console.WriteLine(patterns.validatePinCode("xyz@bridgelabz.com.in.in.in"));
if (patterns.validatePinCode("1Alkbcg?"))
{
    Console.WriteLine("Valid");
}
else
    Console.WriteLine("Invalid");
Console.ReadKey();