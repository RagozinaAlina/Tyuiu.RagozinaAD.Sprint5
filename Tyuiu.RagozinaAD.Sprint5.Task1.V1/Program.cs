using Tyuiu.RagozinaAD.Sprint5.Task1.V1.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        int startValue = -5;
        int stopValue = 5;

        DataService ds = new DataService();
        Console.Title = "Спринт #5 | Выполнила: Рагозина А.Д | АСОиУБ-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Создания итогового решения по спринту                             *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #1                                                              *");
        Console.WriteLine("* Выполнила: Рагозина А.Д | АСОиУБ-25-1                                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Условие:                                                                *");
        Console.WriteLine("* Произвести табулирование функции на диапазоне от -5 до 5 с шагом 1.     *");
        Console.WriteLine("* При делении на 0 вернуть значение 0. Результат сохранить в текстовый    *");
        Console.WriteLine("* файл и вывести на консоль в таблицу.                                    *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДВННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("startValue =  " + startValue);
        Console.WriteLine("stopValue =  " + stopValue);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        string res = ds.SaveToFileTextData(startValue, stopValue);
        Console.WriteLine("Файл: " + res);
        Console.WriteLine("Создан!");
        Console.ReadKey();

    }
}