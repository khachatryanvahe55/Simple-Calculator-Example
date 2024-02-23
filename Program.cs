Console.WriteLine("Enter first number");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter operator (+,-,*, / )");
char oper = Convert.ToChar(Console.ReadLine());

if (oper == '+')

{
Console.WriteLine(num1 + num2);
}
else if (oper == '-')
{
Console.WriteLine(num1 - num2);

}
else if (oper == '*')
{
Console.WriteLine(num1 * num2);
}
else if (oper == '/')
{
    Console.WriteLine(num1 / num2 != 0);
   
}
 else
    {
        Console.WriteLine("Error");
    }