// программа, кот по заданному номеру четверти показывает диапазон возможных координат точек в этой четверти


void Coordinates(int area)
{
    if (area == 1)
    {
        Console.WriteLine("Значения x и y от больше 0 ");
    }
    else if (area == 2)
    {
        Console.WriteLine("Значения x меньше 0, значения y больше 0 ");   
    }
    else if (area == 3)
    {
        Console.WriteLine("Значения x и y от меньше 0 ");
    }
    else if (area ==4)
    {
        Console.WriteLine("Значения x больше 0, значения y меньше 0");
    }
    else Console.WriteLine ("Введено неверное значение, нужно ввести от 1 до 4");
}


Console.WriteLine("Введите номер четверти от 1 до 4: ");
int area = Convert.ToInt32(Console.ReadLine());
Coordinates(area);
