// See https://aka.ms/new-console-template for more information
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine($"Welcome to console app, running on machine {Environment.MachineName}{Environment.NewLine}");

Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Enter text to repeat:");
var text = Console.ReadLine();

Console.WriteLine("Number of times to repeat it:");
var numberOfTimes = Console.ReadLine();

for (int i = 0;i < Convert.ToInt32(numberOfTimes);i++) 
{
    Console.ForegroundColor = (ConsoleColor)i+1;
    Console.WriteLine($"{i + 1}. {text}");
}
  


