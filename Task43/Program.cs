// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();

Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

if (k1 == k2)
{
    Console.WriteLine("Данные прямые параллельны и точки пересечения не имеют");
}

double[] GetArray(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[0] = k1;
        array[1] = b1;
        array[2] = k2;
        array[3] = b2;
    }
    return array;
}

double[] IntersectionPoint(double[] array)
{
    double x = 0;
    double y = 0;
    if (array[0] != array[2])
    {
        x = (array[3] - array[1]) / (array[0] - array[2]);
        y = (array[0] * array[3] - array[1] * array[2]) / (array[0] - array[2]);
    }
    return new double[] { x, y };
}

double[] arr = GetArray(4);
double[] intersectionPoint = IntersectionPoint(arr);
void PrintArray(double[] array)
{
    if (array[0] != array[2])
    {
        Console.Write($"При k1 = {array[0]}, ");
        Console.Write($"b1 = {array[1]}, ");
        Console.Write($"k2 = {array[2]}, ");
        Console.Write($"b2 = {array[3]}, ");
        Console.WriteLine($"прямые пересекаются в точке: ({Math.Round(intersectionPoint[0], 2)}; {Math.Round(intersectionPoint[1], 2)})");
    }
}

PrintArray(arr);


