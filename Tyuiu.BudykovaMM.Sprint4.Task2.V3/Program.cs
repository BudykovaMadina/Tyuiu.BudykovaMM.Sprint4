using Tyuiu.BudykovaMM.Sprint4.Task2.V3.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Random rnd = new Random();
        DataService ds = new DataService();
        Console.Title = "Спринт #4 │ Выполнила: Будыкова М. М. │ ПИНб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Одномерные массивы (генератор случайных чисел)                    *");
        Console.WriteLine("* Вариант #3                                                              *");
        Console.WriteLine("* Выполнила: Будыкова Мадина Маратовна │ ПИНб-25-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан одномерный целочисленный массив на 12 элементов                     *");
        Console.WriteLine("* заполненный случайными значениями в диапазоне от 2 до 7                 *");
        Console.WriteLine("* подсчитать сумму четных элементов массива.                              *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int[] numsArray = new int[12];

        
        for (int i = 0; i < numsArray.Length; i++)
        {
            numsArray[i] = rnd.Next(2, 8); 
        }

        Console.WriteLine("Массив: ");
        
        for (int i = 0; i < numsArray.Length; i++)
        {
            Console.Write(numsArray[i] + "\t");
        }
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        int res = ds.Calculate(numsArray);
        Console.WriteLine("Сумма чётных элементов массива = " + res);
        Console.ReadKey();
    }
}