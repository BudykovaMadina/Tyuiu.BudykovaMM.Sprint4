using Tyuiu.BudykovaMM.Sprint4.Task0.V29.Lib;
internal class Program
{
    private static void Main(string[] args)  
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #4 │ Выполнила: Будыкова М. М. │ ПИНб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                             *");
        Console.WriteLine("* Вариант #29                                                             *");
        Console.WriteLine("* Выполнила: Будыкова Мадина Маратовна │ ПИНб-25-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов                     *");
        Console.WriteLine("* заполненный статическими значениями в диапазоне от 0 до 9               *");
        Console.WriteLine("* подсчитать сумму нечетных элементов массива.                            *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int[] numsArray = { 7, 4, 3, 2, 1, 5, 9, 8, 7, 4 };
        Console.WriteLine("Исходный массив: ");
        for (int i = 0; i < numsArray.Length; i++)
        {
            Console.WriteLine(numsArray[i]);
        }
            
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Сумма нечётных элементов массива = " + ds.GetSumOddArrEl(numsArray));
        Console.ReadKey();
    }
}