// See https://aka.ms/new-console-template for more information
void Unit2()
{
    Console.WriteLine("Hello, world!");
    Console.WriteLine("Hello", "world!");
    Console.Write("Hello");
    Console.Write(" ");
    Console.Write("world!\n");
}

void Unit3()
{
    string colour = Console.ReadLine();
    Console.WriteLine($"{colour}?");
    Console.Write("What is *your* favourite colour? ");
    string favouriteColour = Console.ReadLine() ?? "red";
    Console.WriteLine($"Oh, I love {favouriteColour} too!");
}

void Unit4()
{
    string firstName = "John";
    string lastName = "Doe";
    string fullName = lastName + ", " + firstName;
    Console.WriteLine(fullName);
    fullName = $"{lastName}, {firstName}";
    Console.WriteLine($"{fullName}? Nice to meet you.");
    fullName = Console.ReadLine() ?? "Doe, John";
    firstName = firstName.ToUpper();
    lastName = lastName.ToUpper();
    fullName = $"{lastName}, {firstName}";
    Console.WriteLine($"{fullName}? Nice to meet you.");
}

void Unit5()
{
    Console.WriteLine(">>> Welcome to the personalised greeting program! <<<");
    Console.Write("What is your name? ");
    string name = Console.ReadLine() ?? "John Doe";
    Console.WriteLine($"Hello {name}, it's nice to meet you!");
}

void Unit6()
{
    Console.WriteLine(">>> Welcome to the more personalised greeting program! <<<");
    Console.Write("What is your name? ");
    string name = Console.ReadLine() ?? "John Doe";
    Console.Write("What is your age? ");
    string age = Console.ReadLine() ?? "25";
    Console.WriteLine($"Hello {name}, it's nice to meet a fellow {age} year old!");
}

Unit2();
Unit3();
Unit4();
Unit5();
Unit6();
