namespace Lab6;

internal class Character
{
    private int _damage;
    private int _critMultiplier;
    private int _attackSpeed;

    public Character(int damage, int critMultiplier, int attackSpeed)
    {
        Damage = damage;
        _critMultiplier = critMultiplier;
        AttackSpeed = attackSpeed;
    }

    public Character(Character obj)
    {
        _damage = obj._damage;
        _critMultiplier = obj._critMultiplier;
        _attackSpeed = obj._attackSpeed;
    }

    public int Damage
    {
        get 
        { 
            return _damage; 
        }
        set
        {
            if (value <= 0)
                throw new ArgumentOutOfRangeException(nameof(value), 
                "Урон должен быть больше 0.");
            _damage = value;
        }
    }

    public int CritMultiplier
    {
        get 
        { 
            return _critMultiplier; 
        }
        set { _critMultiplier = value; }
    }

    public int AttackSpeed
    {
        get 
        { 
            return _attackSpeed; 
        }
        set
        {
            if (value <= 0)
                throw new ArgumentOutOfRangeException(nameof(value),
                "Скорость атаки должна быть больше 0.");
            _attackSpeed = value;
        }
    }

    public int GetTotalDamage()
    {
        return _damage * _critMultiplier * _attackSpeed;
    }

    public override string ToString()
    {
        return $"Базовый урон = {_damage}, Множитель урона = {_critMultiplier}, Скорость атаки = {_attackSpeed}";
    }
}