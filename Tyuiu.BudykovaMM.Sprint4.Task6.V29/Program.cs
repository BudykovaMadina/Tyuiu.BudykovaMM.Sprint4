using Tyuiu.BudykovaMM.Sprint4.Task6.V29.Lib;
internal class Program
    // используя класс Array подсчитайте количество элементов, длина которых больше 4
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #4 │ Выполнила: Будыкова М. М. │ ПИНб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Класс Array                                                       *");
        Console.WriteLine("* Вариант #29                                                             *");
        Console.WriteLine("* Выполнила: Будыкова Мадина Маратовна │ ПИНб-25-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан строковый массив данных [Весна, Лето, Осень, Зима]                  *");
        Console.WriteLine("* заполненный статическими значениями в диапазоне от 0 до 9. Используя    *");
        Console.WriteLine("* класс Array подсчитайте количество элементов, длина которых больше 4.   *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        var season = new string[] { "Весна", "Лето", "Осень", "Зима" };

        Console.WriteLine("Исходный массив: ");
        for (int i = 0; i <= season.Length -1; i++)
        {
            Console.WriteLine(season[i]);
        }

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Количество элементов, длина которых больше 4: " + ds.Calculate(season));
        Console.ReadKey();
    }
}