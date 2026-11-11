// See https://aka.ms/new-console-template for more information

void Unit2()
{
    Console.WriteLine("Hello, world!");
    Console.WriteLine('H');
    Console.WriteLine(100);
    Console.WriteLine(100.00);
    Console.WriteLine(true);
    Console.WriteLine("100" + "100");
    Console.WriteLine(100 + 100);
}

void Unit3()
{
    string name = "John";
    Console.WriteLine(name);
    int age = 19;
    Console.WriteLine(age);
    var isUnit3 = true;
    var pi = 3.1m;
    Console.WriteLine(pi);
    Console.WriteLine(isUnit3);
}

void Unit4()
{
    string favouriteFood = "pizza";
    int slicesEaten = 3;
    bool isHungry = true;
    var favouriteTopping = "pepperoni";
    Console.WriteLine($"My favourite food is {favouriteFood}");
    Console.WriteLine($"I like my pizza with {favouriteTopping}");
    Console.WriteLine($"Is hungry: {isHungry}");
    Console.WriteLine($"I have eaten {slicesEaten} slices");
    slicesEaten = 5;
    Console.WriteLine($"I have eaten {slicesEaten} slices");
}

void Unit5()
{
    
}

Unit2();
Unit3();
Unit4();
