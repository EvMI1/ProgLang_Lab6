namespace Lab6;

internal class Mage : Character
{
    private int _mana;
    private int _spellDamage;

    public Mage(int damage, int critMultiplier, int attackSpeed, int mana, int spellDamage)
    : base(damage, critMultiplier, attackSpeed)
    {
        _mana = mana;
        _spellDamage = spellDamage;
    }

    public Mage(Mage obj) : base(obj)
    {
        _mana = obj._mana;
        _spellDamage = obj._spellDamage;
    }

    public int Mana
    {
        get 
        { 
            return _mana; 
        }
        set
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException(nameof(value), 
                "Мана не может быть меньше 0.");
            _mana = value;
        }
    }

    public int SpellDamage
    {
        get 
        {
             return _spellDamage; 
        }
        set
        {
            if (value > 100)
                throw new ArgumentOutOfRangeException(nameof(value), 
                "Урон заклинания не может превышать 100.");
            _spellDamage = value;
        }
    }

    public int CastSpell()
    {
        if (IsOutOfMana())
        {
            Console.WriteLine("Недостаточно маны!");
            return 0;
        }
        _mana -= 10;
        return _spellDamage;
    }

    public bool IsOutOfMana()
    {
        return _mana < 10;
    }

    public override string ToString()
    {
        return $"{base.ToString()}, Мана = {_mana}, Урон заклинанием = {_spellDamage}";
    }
}