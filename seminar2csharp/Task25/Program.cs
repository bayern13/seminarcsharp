
double NaturalDegree(double num1,double num2)
{

    double res = Math.Pow(num1, num2);
    return res;
}



Console.WriteLine("Введите первое число : ");
double number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число : ");
double number2 = Convert.ToInt32(Console.ReadLine());

double naturalDegree = NaturalDegree(number1, number2);
Console.WriteLine($"{number1},{number2} -> {naturalDegree}");