Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine($"Welcome to console app, running on machine {Environment.MachineName}{Environment.NewLine}");

Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Enter text to repeat:");
var text = Console.ReadLine();

Console.WriteLine("Number of times to repeat it:");
var numberOfTimes = Console.ReadLine();

var availableColours = Enum.GetValues<ConsoleColor>().ToList();
availableColours.Remove(Console.BackgroundColor);

var random = new Random();

for (var i = 0;i < Convert.ToInt32(numberOfTimes);i++)
{
    Console.ForegroundColor = availableColours[random.Next(0, availableColours.Count)];
    Console.WriteLine($"{i + 1}. {text}");
}
