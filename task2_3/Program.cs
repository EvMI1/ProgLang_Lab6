using Checkup;

namespace Lab6;

internal class Program
{
    public static void Main(string[] args)
    {
        try
        {
            byte hours = HelpConsole.ReadByte("Введите часы (0-23): ");
            byte minutes = HelpConsole.ReadByte("Введите минуты (0-59): ");
            Time t1 = new Time(hours, minutes);
            Console.WriteLine("Время 1: " + t1);
            Time t2 = new Time(t1);
            Console.WriteLine("Копия: " + t2);
            byte hours2 = HelpConsole.ReadByte("Введите часы для второго времени (0-23): ");
            byte minutes2 = HelpConsole.ReadByte("Введите минуты для второго времени (0-59): ");
            Time t3 = new Time(hours2, minutes2);
            Console.WriteLine("Время 2: " + t3);
            Console.WriteLine($"{t1} - {t3} = {t1.Subtract(t3)}");
            Console.WriteLine($"{t1}++ = {++t1}");
            Console.WriteLine($"{t1}-- = {--t1}");
            Console.WriteLine($"Время1 в минутах (int): {(int)t1}");
            Console.WriteLine($"Время2 не нулевое (bool): {(bool)t2}");
            Console.WriteLine($"{t1} < {t3}: {t1 < t3}");
            Console.WriteLine($"{t1} > {t3}: {t1 > t3}");
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine("Ошибка: " + ex.Message);
        }
    }
}