// программа, кот принимает на вход координаты 2х точек и находит расстояние между ними в 2D пространстве

double GetDistance (double x1, double y1, double x2, double y2)
{
    double d = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1));
    return d;   
}


Console.WriteLine("Введите координату x для для точки A");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y для для точки A");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату x для для точки B");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y для для точки B");
int y2 = Convert.ToInt32(Console.ReadLine());
double d = 0;

double distanse = GetDistance (x1, y1, x2, y2);
Console.WriteLine($"Растояние между 2 точками ({x1},{x2}) и ({y1},{y2}) равно {Math.Round(distanse,2)}");