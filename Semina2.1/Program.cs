//ввод целого числа 
Console.Write ("Введите целое число ");
try
{
    int x =Convert.ToInt32 (Console.ReadLine());
    Console.WriteLine(x*10);
}
catch
{
    Console.WriteLine("надо было вводить целое число");

}
