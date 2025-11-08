using Tyuiu.BudykovaMM.Sprint4.Task7.V26.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        int rows = 5;
        int columns = 3;
        int[,] mtrx = new int[rows, columns];
        string str = "351268459614723";

        DataService ds = new DataService();

        Console.Title = "Спринт #4 │ Выполнила: Будыкова М. М. │ ПИНб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту.                *");
        Console.WriteLine("* Вариант #26                                                             *");
        Console.WriteLine("* Выполнила: Будыкова Мадина Маратовна │ ПИНб-25-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан строка из одноразрядных цифр 351268459614723. Преобразуйте ее в     *");
        Console.WriteLine("* матрицу 5 на 3 и подсчитайте произведение четных чисел.                 *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int index = 0;

        Console.WriteLine("Исходный массив: ");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"{str[index]} \t");
                index++;
            }
            Console.WriteLine();
        }

        Console.WriteLine();

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        int res = ds.Calculate(rows, columns, str);

        Console.WriteLine("Произведение чётных чисел матрицы: " + res);
        Console.ReadKey();

    }
}