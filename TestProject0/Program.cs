// See https://aka.ms/new-console-template for more information

Console.WriteLine("--- BEGIN COIN FLIP ---");
var random = new Random();
var flip = random.Next(2) == 0 ? "heads" : "tails";
Console.WriteLine(flip);
Console.WriteLine("--- END COIN FLIP ---");
while (true)
{
    Console.WriteLine("--- BEGIN ACCESS GRANTER ---");
    Console.Write("permission (Admin/Manager)? ");
    var permissions = Console.ReadLine() ?? "";
    Console.Write("level? ");
    var level = Convert.ToInt32(Console.ReadLine() ?? "");
    if (permissions == "Admin" && level > 55)
    {
        Console.WriteLine("Welcome, Super Admin user.");
    }
    else if (permissions == "Admin")
    {
        Console.WriteLine("Welcome, Admin user.");
    }
    else if (permissions == "Manager" && level >= 20)
    {
        Console.WriteLine("Ask the Admin to attend you.");
    }
    else
    {
        Console.WriteLine("You do not have sufficient privileges.");
    }
    Console.WriteLine("--- END ACCESS GRANTER ---");
}
