using Tyuiu.BudykovaMM.Sprint4.Task3.V16.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        int[,] mtrx = new int[5, 5] { { 5, 8, 5, 8, 4 },
                                          { 2, 3, 4, 6, 3 },
                                          { 1, 1, 2, 9, 9 },
                                          { 6, 7, 4, 1, 2 },
                                          { 5, 7, 1, 8, 7 } };
        int rows = mtrx.GetUpperBound(0) + 1;
        int columns = mtrx.Length / rows;

        DataService ds = new DataService();

        Console.Title = "Спринт #4 │ Выполнила: Будыкова М. М. │ ПИНб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Двумерные массивы (статический ввод)                              *");
        Console.WriteLine("* Вариант #16                                                             *");
        Console.WriteLine("* Выполнила: Будыкова Мадина Маратовна │ ПИНб-25-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов                     *");
        Console.WriteLine("* заполненный статическими значениями в диапазоне от 1 до 9               *");
        Console.WriteLine("* Найдите минимальный элемент в последнем столбце массива.                *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Массив : ");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"{mtrx[i, j]} \t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        int res = ds.Calculate(mtrx);
        Console.WriteLine("Минимальный элемент последнего столбца массива = " + res);
        Console.ReadKey();
    }
}