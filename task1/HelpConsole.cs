namespace Checkup;
internal class HelpConsole
{
    public static int ReadInt(string message)
    {
        while(true)
        {
            Console.Write(message);
            if (int.TryParse(Console.ReadLine(), out int value))
            {
                return value;
            }
            Console.WriteLine("Неккоректное значение. Повторите ввод");
        }
    }
}