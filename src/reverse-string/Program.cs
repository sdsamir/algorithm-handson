// See https://aka.ms/new-console-template for more information
Console.WriteLine("\nReverse the characters of a string but the non alphabetic characters will not change its position");

var input = "ma7name-i9s-wo77w";
var reverseString = new ReverseString();
var output = reverseString.Reverse(input);

Console.WriteLine(input);
Console.WriteLine(output);

Console.ReadLine();


