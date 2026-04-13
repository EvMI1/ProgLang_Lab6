namespace Lab6;

internal class Mage : Character
{
    private int mana;
    private int spellDamage;

    public Mage(int damage, int critMultiplier, int attackSpeed, int mana, int spellDamage)
    : base(damage, critMultiplier, attackSpeed)
    {
        Mana = mana;
        SpellDamage = spellDamage;
    }

    public Mage(Mage obj): base(obj)
    {
        mana = obj.mana;
        spellDamage = obj.spellDamage;
    }

    public int Mana
    { 
        get { return mana; }
        set
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException("value", "Мана не может быть меньше 0.");
            mana = value;
        }
    }

    public int SpellDamage
    {
        get { return spellDamage; }
        set
        {
            if (value > 100)
                throw new ArgumentOutOfRangeException("value", "Урон заклинания не может превышать 100.");
            spellDamage = value;
        }
    }

    public int CastSpell()
    {
        if (IsOutOfMana())
        {
            Console.WriteLine("Недостаточно маны!");
            return 0;
        }
        mana -= 10;
        return spellDamage;
    }

    public bool IsOutOfMana()
    {
        return mana < 10;
    }

    public override string ToString()
    {
        return $"{base.ToString()}, Мана = {mana}, Урон заклинанием = {spellDamage}";
    }
}