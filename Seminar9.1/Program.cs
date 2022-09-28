// найти фактриал при помощи рекурсии

// 5!=1*2*3*4*5=120

int Factorial(int n)
{
    if (n == 0)
    {
        return 1;
    }
    if (n == 1)
    {
        return 1;
    }
    int result = n * Factorial(n - 1);
    return result;
}

var res=Factorial(5);
Console.ReadKey();
