// программа, кот на вход принимает 3 числа и проверяет, может ли существовать треугольник со сторонами такой длины

bool Triagle (int num1, int num2, int num3)
{
    bool result =false;
    if (num1> num2+num3)
    {
        result=true;
    }
    else if (num2>num1+num3)
    {
        result=true;
    }
    else if (num3>num1+num2)
    {
        result=true;
    }
    else result=false;
    return result;
}

Console.WriteLine("Введите первое число:");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int number2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число:");
int number3 = int.Parse(Console.ReadLine());

bool result = Triagle(number1,number2,number3);
Console.Write(result);