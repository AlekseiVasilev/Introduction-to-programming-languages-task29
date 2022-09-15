/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов
и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

Console.Clear();
Console.WriteLine("\n Задача 29");
int[] numbers = new int[8];

int[] CreatingAnArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(0, 99);
    }
    return numbers;
}

void PrintArry(int[] numbers)
{
    int count = numbers.Length;
    int index = 0;
    Console.Write("[");
    while (index < count)
    {
        Console.Write(numbers[index]);
        index++;
        if (index < count)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}

CreatingAnArray(numbers);
PrintArry(numbers);
