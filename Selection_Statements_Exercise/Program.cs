using System;
// Selection Statements Exercise 1
var r = new Random();
var favNumber = r.Next(1, 1000);
Console.WriteLine("Try to guess my favorite number");
var userInput = int.Parse(Console.ReadLine());

if (userInput < favNumber)
{
    Console.WriteLine("Too low");
}
else if (userInput > favNumber)
{
    Console.WriteLine("Too high");
}
else
{ Console.WriteLine("Congratulations, you guessed it");
}


// Selection Statements Exercise 2

Console.WriteLine("What is your favorite school subject?\n" + "1 - History\n" + "2 - Mathematics\n" + "3 - English\n" + "4 - Social Studies\n" + "5 - Gynmastics\n");
int favSubject = Convert.ToInt32(Console.ReadLine());

switch (favSubject)
{
    case 1:
        Console.WriteLine("Your favorite subject is history");
        break;
    case 2:
        Console.WriteLine("Your favorite subject is mathematics");
        break;
    case 3:
        Console.WriteLine("Your favorite subject is English");
        break;
    case 4:
        Console.WriteLine("Your favorite subject is science");
        break;
    case 5:
        Console.WriteLine("Your favorite subject is gym");
        break;
    default:
        Console.WriteLine("Favorite subject not found");
        break;
}