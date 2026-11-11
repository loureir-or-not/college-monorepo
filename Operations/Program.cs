// See https://aka.ms/new-console-template for more information
void Unit2()
{
    int three = 3;
    decimal two = 2.0m;
    double one = 1.00;
    int numerator = 3;
    int divisor = 5;
    Console.WriteLine(numerator / divisor);
    decimal decNumerator = 3.00m;
    decimal decDivisor = 5.00m;
    Console.WriteLine(decNumerator / decDivisor);
}

void Unit3()
{
    int standardPemdas = 2 + 3 * 4; // 14
    int forcedPemdas = (2 + 3) * 4; // 20
    int num = standardPemdas + forcedPemdas;
    num += 10;
    int collatz = 4 % 2;
    --num;
    int res = standardPemdas / forcedPemdas;
    Console.WriteLine(res);
    decimal mStandardPemdas = 2.0m + 3.0m * 4.0m; // 14.0
    decimal mForcedPemdas = (2.0m + 3.0m) * 4.0m; // 20.0
    decimal mRes = mStandardPemdas / mForcedPemdas;
    Console.WriteLine(mRes);
}

void Unit4() {
    Console.Write("age? ");
    string ageText = Console.ReadLine() ?? "";
    int age = Convert.ToInt32(ageText);
    int nextAge = age + 1;
    Console.WriteLine($"You will be {nextAge} next year.");
    age = int.Parse(ageText);
    Console.WriteLine($"You are {age} now.");
    decimal pi = decimal.Parse("3.14");
    int three = (int)pi;
    decimal mThree = (decimal)three;
    Console.WriteLine($"mThree: {mThree}");
}

void Unit5()
{
    Console.Write("bill amount? ");
    var billText = Console.ReadLine() ?? "";
    var bill = decimal.Parse(billText);
    Console.Write("tip percentage? ");
    var tipPercentageText = Console.ReadLine() ?? "";
    var tipPercentage = decimal.Parse(tipPercentageText);

    var tip = bill * (tipPercentage / 100.0m);
    var total = bill + tip;

    Console.WriteLine($"BILL AMOUNT=£{bill}");
    Console.WriteLine($"TIP PERCENTAGE={tipPercentage * 100}%");
    Console.WriteLine($"TIP={tip}");
    Console.WriteLine($"TOTAL={total}");
}

void Unit6()
{
    Console.Write("fahrenheit? ");
    string fahrenheitText = Console.ReadLine() ?? "";
    decimal fahrenheit = Convert.ToDecimal(fahrenheitText);
    decimal celsius = (fahrenheit - 32.0m) * (5.0m / 9.0m);
    Console.WriteLine($"FAHRENHEIT={fahrenheit}");
    Console.WriteLine($"CELSIUS={celsius}");
}

Unit2();
Unit3();
Unit4();
Unit5();
Unit6();
