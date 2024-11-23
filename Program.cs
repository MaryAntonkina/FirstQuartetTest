using System;

class Program
{
    static void Main()
    {
        string[] array = GetInputArray();
        int taskLength = 3;
        string[] resultArray = FilterArrayByLength(array, taskLength);
        PrintResultArray(resultArray);
    }

    static string[] GetInputArray()
    {
        Console.Write("Введите количество слов в массиве: ");
        int arrayLength = int.Parse(Console.ReadLine());
        string[] array = new string[arrayLength];

        Console.WriteLine("Введите слова поочередно:");
        for (int i = 0; i < arrayLength; i++)
        {
            Console.Write($"Слово {i + 1}: ");
            array[i] = Console.ReadLine();
        }

        return array;
    }

    static string[] FilterArrayByLength(string[] array, int maxLength)
    {
        string[] resultArray = new string[0];
        int resultLength = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= maxLength)
            {
                Array.Resize(ref resultArray, resultLength + 1);
                resultArray[resultLength] = array[i];
                resultLength++;
            }
        }

        return resultArray;
    }

    static void PrintResultArray(string[] array)
    {
        Console.WriteLine("Результирующий массив:");
        Console.WriteLine(string.Join(", ", array));
    }
}
