// See https://aka.ms/new-console-template for more information
void Unit2And3()
{
    bool isGameOver = true;
    bool isWinner = false;
    bool isGoodGame = isGameOver && isWinner;
    if (!isGoodGame)
    {
        Console.WriteLine("aww :(");
    }
    else if (!isGameOver)
    {
        Console.WriteLine("i never get run but you have to continue!");
    }
    else
    {
        Console.WriteLine("i never get run but yay! :)");
    }
    bool hasTicket = true;
    bool winsALaptop = true;
    if (hasTicket)
    {
        if (winsALaptop)
        {
            Console.WriteLine("I win a laptop!");
        }
        else
        {
            Console.WriteLine("I don't want to think about this.");
        }
    }
}

void Unit4()
{
    bool hasTicket = true;
    bool winsLaptop = false;
    bool winsThinkPad = true;
    if (hasTicket && winsLaptop)
    {
        Console.WriteLine("Hooray!");
    }
    winsLaptop = !winsLaptop;
    hasTicket = false;
    if (hasTicket && winsLaptop || winsThinkPad)
    {
        Console.WriteLine("Hooray!!");
    }
    else if (!hasTicket && winsLaptop)
    {
        Console.WriteLine("Aww... I should have got a ticket");
    }
    else
    {
        Console.WriteLine("Aww...");
    }
}

void Unit5()
{
    Random dice = new Random();
    int roll1 = dice.Next(1, 7);
    int roll2 = dice.Next(1, 7);
    int roll3 = dice.Next(1, 7);
    int total = roll1 + roll2 + roll3;
    if (total <= 3)
    {
        Console.WriteLine("Snake eyes. Unlucky.");
    }
    else if (roll1 == roll2 && roll2 == roll3)
    {
        Console.WriteLine($"Triples! Total = {total} +6!");
        total += 6;
    }
    else if (roll1 == roll2 || roll2 == roll3)
    {
        Console.WriteLine($"Doubles! Total = {total} +2!");
        total += 2;
    }
    else
    {
        Console.WriteLine($"Nice! Total = {total}!");
    }
}

void Unit6()
{
    Random random = new Random();
    int daysUntilExpiration = random.Next(12);
    int discountPercentage = 0;
    if (daysUntilExpiration == 0)
    {
        Console.WriteLine("Subscription expired.");
    }
    else if (daysUntilExpiration == 1)
    {
        Console.WriteLine("Subscription expires in a day.");
        discountPercentage = 20;
    }
    else if (daysUntilExpiration <= 5)
    {
        Console.WriteLine("Subscription expires in 5 days.");
        discountPercentage = 10;
    }
    else if (daysUntilExpiration <= 10)
    {
        Console.WriteLine("Subscription expires in 10 days.");
    }
}

Unit2And3();
Unit4();
Unit5();
Unit6();
