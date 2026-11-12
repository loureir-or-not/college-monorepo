using BillingCalculator;

double subtotal = 49.99;
double tax = Calculator.CalculateTax(subtotal);
double total = Calculator.CalculateTotal(subtotal, tax);
Console.WriteLine($"SUBTOTAL={subtotal:C}");
Console.WriteLine($"TAX={tax:C}");
Console.WriteLine($"TOTAL={total:C}");

double taxHalfVAT = Calculator.CalculateTax(subtotal, rate: 0.10);
double totalHalfVAT = Calculator.CalculateTotal(subtotal, taxHalfVAT);
Console.WriteLine($"SUBTOTAL={subtotal:C}");
Console.WriteLine($"TAX={taxHalfVAT:C}");
Console.WriteLine($"TOTAL={totalHalfVAT:C}");
