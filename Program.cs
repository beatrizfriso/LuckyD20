Console.WriteLine("\r\n▒█░░░ █░░█ █▀▀ █░█ █░░█ ▒█▀▀▄ █▀█ █▀▀█ \r\n▒█░░░ █░░█ █░░ █▀▄ █▄▄█ ▒█░▒█ ░▄▀ █▄▀█ \r\n▒█▄▄█ ░▀▀▀ ▀▀▀ ▀░▀ ▄▄▄█ ▒█▄▄▀ █▄▄ █▄▄█");
Console.WriteLine("   ");
Console.WriteLine("Welcome to our lucky dice roller!");
Console.WriteLine("May the critical role be with you!!!!");
Console.WriteLine("Press any key and good luck...");
Console.WriteLine("   ");
Console.ReadKey(); Console.ReadKey();

Random dice = new Random();
int roll = dice.Next(1, 20);
Console.WriteLine($"You rolled: {roll}");
Console.WriteLine("   ");

if (roll == 1)
{
    Console.WriteLine("Oh, that's not what I wished for when I said 'critical'");
}
else if (roll >= 2 && roll <= 7)
{
    Console.WriteLine("Well...it could be worse.");
}
else if (roll >= 8 && roll <= 12)
{
    Console.WriteLine("Not terrible but not impressive.");
}
else if (roll >= 13 && roll <= 19)
{
    Console.WriteLine("May the stars of the die continue to shine in your favor.");
}
else if (roll == 20)
{
    Console.WriteLine("Oh! Look at him! Seems like someone here is a lucky fellow.");
}

Console.WriteLine("   ");
Console.WriteLine("Press any key to exit ");
Console.ReadKey();