System.Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("Привіт у калькуляторі))");

double firstValue, secondValue;

string dia;

Console.WriteLine("Введи цифру 1");
firstValue = double.Parse(Console.ReadLine());

Console.WriteLine("Виберіть дію '+' '-' '/' '*'");
dia = Console.ReadLine();

Console.WriteLine("Введи цифру 2");
secondValue = double.Parse(Console.ReadLine());
Console.WriteLine("Ваш результат = ");

switch (dia)
{
    case "+":
        Console.WriteLine(firstValue + secondValue);
        break;
    case "-":
        Console.WriteLine(firstValue - secondValue);
        break;
    case "*":
        Console.WriteLine(firstValue * secondValue);
        break;
    case "/":
        Console.WriteLine(firstValue / secondValue);
        break;

    default:
        Console.WriteLine("Невідома дія");
        break;

}
Console.WriteLine();
