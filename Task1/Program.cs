using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Введіть число N: ");
        int N = Convert.ToInt32(Console.ReadLine());
        double[] array = new double[N];
        Random rand = new Random();

        // Заповнення масиву 
        for (int i = 0; i < N; i++)
        {
            array[i] = rand.NextDouble() * 20 - 10;  // [-10, 10)
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();

        double sumNegative = 0;
        double minElement = array[0];
        int maxIndex = 0;
        double maxAbs = Math.Abs(array[0]);
        int sumPositiveIndexes = 0;
        int countIntegers = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                sumNegative += array[i];
            }

            if (array[i] < minElement)
            {
                minElement = array[i];
            }

            if (array[i] > array[maxIndex])
            {
                maxIndex = i;
            }

            if (Math.Abs(array[i]) > maxAbs)
            {
                maxAbs = Math.Abs(array[i]);
            }

            if (array[i] > 0)
            {
                sumPositiveIndexes += i;
            }

            if (array[i] == Math.Round(array[i]))
            {
                countIntegers++;
            }
        }

        Console.WriteLine("Сума від’ємних елементів масиву: " + sumNegative);
        Console.WriteLine("Мінімальний елемент масиву: " + minElement);
        Console.WriteLine("Індекс найблільшого елемента масиву: " + maxIndex);
        Console.WriteLine("Максимальний за модулем елемент масиву: " + maxAbs);
        Console.WriteLine("Сума індексів додатних елементів: " + sumPositiveIndexes);
        Console.WriteLine("Кількість цілих чисел у масиві: " + countIntegers);


        Console.ReadLine();
    }
}
