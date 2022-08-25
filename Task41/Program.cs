// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();

Console.WriteLine("Введите количество задаваемых чисел  ");
int size = Convert.ToInt32(Console.ReadLine());
if (size <= 0)
{
    Console.WriteLine("Ввели некорректное значение");
    return;
}

int[] GetArray(int size)
{
    int[] array = new int[size];

    Console.WriteLine("Введите целые числа через пробел");
    string[] numbers = Console.ReadLine().Split(' ');
    for (int i = 0; i < size; i++)
    {
        array[i] = Convert.ToInt32(numbers[i]);

    }
    return array;
}

int CountPosElem(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]},");
        else Console.Write(array[i]);
    }
}

int[] arr = GetArray(size);
PrintArray(arr);
int countPosElem = CountPosElem(arr);
Console.WriteLine($" -> Количество введенных чисел > 0 равна: {countPosElem}");

