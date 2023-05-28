try
{
Console.Write("Введите номер задачи: ");
int task = Convert.ToInt32(Console.ReadLine());
switch (task)
    {
        case 1:
        {
            SearchNumbers();
            break;
        }
        case 2:
        {
            InterPoint();
            break;
        }
        default:
        {
            Console.WriteLine("Такой задачи нет");
            break;
        }
    }
}
catch
{
    Console.WriteLine("Некорректный ввод");
}
/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/
void SearchNumbers()
{
    try
    {
        Console.Write("Введите свои числа(через пробел): ");
        int[] arr = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
        if(arr is not null)
        {
        int count = 0;
 
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                count++;
                }
            }
 
        Console.WriteLine($"{count} элементов больше нуля");
        }
        else
        {
            Console.WriteLine("ничего не введено");
        }
    }
    catch
    {
        Console.WriteLine("Некорректный ввод(возможно вы поставили пробел после знака отрицания в одном или нескольких числах)");
    }
}
/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/
void InterPoint()
{
    try
    {
    Console.WriteLine("Введите координаты точек первой прямой(через пробел) в порядке b1 k1 и b2 k2");
    double[] Line1 = Array.ConvertAll(Console.ReadLine()!.Split(), double.Parse);
    double k1 = Line1[0];
    double b1 = Line1[1];
    double k2 = Line1[2];
    double b2 = Line1[3];
    
    double x = -(k1 - k2) / (b1 - b2);
    double y = b1 * x + k1;
 
    x = Math.Round(x, 3);
    y = Math.Round(y, 3);
    Console.WriteLine($"точка пересечения прямых: ({x};{y})");
    }
    catch
    {
        Console.WriteLine("Некорректный ввод");
    }
    
}
