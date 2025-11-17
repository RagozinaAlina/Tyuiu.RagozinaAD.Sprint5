using Tyuiu.RagozinaAD.Sprint5.Task6.V21.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #5 | Выполнила: Рагозина А.Д | АСОиУБ-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Создания итогового решения по спринту                             *");
        Console.WriteLine("* Задание #6                                                              *");
        Console.WriteLine("* Вариант #21                                                             *");
        Console.WriteLine("* Выполнила: Рагозина А.Д | АСОиУБ-25-1                                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан файл в котором есть набор символьных данных.                        *");
        Console.WriteLine("* данных. Найти количество удвоенных букв тт в заданной строке.           *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        string path = @"C:\Users\Алина\AppData\Local\Temp\InPutDataFileTask6V21.txt";

        Console.WriteLine("Данные находяться в файле: " + path);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        double res = ds.LoadFromDataFile(path);
        Console.WriteLine(res);
        Console.ReadKey();
    }
}