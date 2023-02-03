double Sum(double num1, double num2)
    => num1+ num2;

double Sub(double num1, double num2)
    => num1 - num2;
double Div(double num1, double num2)
    => num1 / num2;
double Mult(double num1, double num2)
    => num1 * num2;
double Pow(double num1,double num2)
{
    double pow = 1;
    for(int i = 0; i < num2; i++)
    {
        pow *= num1;
    }
        return pow;
}
while (true)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine();
    Console.WriteLine("Please choose operator between ('+', '-', '/', '*')");
    Console.WriteLine("If you want to get power of number enter 1.");
    Console.WriteLine("If you want to exit press 'q'");
    var operation = Convert.ToChar(Console.ReadLine());
    if (operation == 'q')
        break;
    Console.Write("Enter the first number: ");
    var num1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Enter the second number: ");
    var num2 = Convert.ToDouble(Console.ReadLine());
    if (operation == '+')
    {
        var sum = Sum(num1, num2);
        Console.WriteLine($"Sum of {num1} and {num2} = {sum}");
    }
    else if (operation == '-')
    {
        var sub = Sub(num1, num2);
        Console.WriteLine($"Substraction of {num1} and {num2} = {sub}");
    }
    else if (operation == '/')
    {
        if (num2 == 0)
        {
            throw new ArgumentNullException("The divisor cannot be null.");
        }
        else
        {
            var div = Div(num1, num2);
            Console.WriteLine($"Division of {num1} and {num2} = {div}");
        }
    }
    else if (operation == '*')
    {
        var mult = Mult(num1, num2);
        Console.WriteLine($"Multiplication of {num1} and {num2} = {mult}");
    }
    else if (operation == '1')
    {
        double pow = Pow(num1, num2);
        Console.WriteLine($"{num1}'s power to {num2} is {pow}");
    }
    else
        Console.WriteLine("Wrong input");
}