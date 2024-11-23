using System;

class Program
{
    static void Main()
    {

        string[] array = { "раз", "два", "три", "четыре", "пять" };
        int taskLength = 3;
        string[] resultArray = new string[0];
        int resultLength = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= taskLength)
            {
                Array.Resize(ref resultArray, resultLength + 1);

                resultArray[resultLength] = array[i];
                resultLength++;
            }
        }

        Console.WriteLine("Результирующий массив:");
        Console.WriteLine(string.Join(", ", resultArray));
    }
}
