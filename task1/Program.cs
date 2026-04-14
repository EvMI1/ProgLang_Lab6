using Checkup;

namespace Lab6;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("===БАЗОВЫЙ КЛАСС (персонаж)===");
            int damage = HelpConsole.ReadInt("Введите урон: ");
            int critMultiplier = HelpConsole.ReadInt("Введите множитель крита: ");
            int attackSpeed = HelpConsole.ReadInt("Введите скорость атаки: ");
            Character obj1 = new Character(damage, critMultiplier, attackSpeed);
            Console.WriteLine($"Объект базового класса: {obj1}");
            Console.WriteLine($"Произведение значений полей = {obj1.GetTotalDamage()}");
            Character objCopy = new Character(obj1);
            Console.WriteLine($"Скопированный объект: {objCopy}");
            Console.WriteLine("\n===ДОЧЕРНИЙ КЛАСС (маг)===");
            damage = HelpConsole.ReadInt("Введите урон: ");
            critMultiplier = HelpConsole.ReadInt("Введите множитель крита: ");
            attackSpeed = HelpConsole.ReadInt("Введите скорость атаки: ");
            int mana = HelpConsole.ReadInt("Введите ману: ");
            int spellDamage = HelpConsole.ReadInt("Введите урон заклинания: ");
            Mage mage1 = new Mage(damage, critMultiplier, attackSpeed, mana, spellDamage);
            Console.WriteLine("\nМаг 1: " + mage1);
            Console.WriteLine("Общий урон: " + mage1.GetTotalDamage());
            Console.WriteLine("\nПрименяем заклинание: " + mage1.CastSpell());
            Console.WriteLine("Мана после каста: " + mage1.Mana);
            Console.WriteLine("Мана на нуле: " + mage1.IsOutOfMana());
            Mage mage2 = new Mage(mage1);
            Console.WriteLine("\nКопия мага: " + mage2);
            mage1.Mana = HelpConsole.ReadInt("\nИзменить ману у мага 1: ");
            Console.WriteLine("Маг 1 после изменения: " + mage1);
            Console.WriteLine("Маг 2 не изменился:    " + mage2);
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine("Ошибка: " + ex.Message);
        }
    }
}