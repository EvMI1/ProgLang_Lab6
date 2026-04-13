namespace Lab6;

internal class Character
{
    private int damage;
    private int critMultiplier;
    private int attackSpeed;

    public Character(int damage, int critMultiplier, int attackSpeed)
    {
        Damage = damage;
        this.critMultiplier = critMultiplier;
        AttackSpeed = attackSpeed;
    }

    public Character(Character obj)
    {
        damage = obj.damage;
        critMultiplier = obj.critMultiplier;
        attackSpeed = obj.attackSpeed;
    }

    public int Damage
    {
        get { return damage; }
        set
        {
            if (value <= 0)
                throw new ArgumentOutOfRangeException("value", "Урон должен быть больше 0.");
            damage = value;
        }
    }

    public int CritMultiplier
    {
        get { return critMultiplier; }
        set { critMultiplier = value; }
    }

    public int AttackSpeed
    {
        get { return attackSpeed; }
        set
        {
            if (value <= 0)
                throw new ArgumentOutOfRangeException("value", "Скорость атаки должна быть больше 0.");
            attackSpeed = value;
        }
    }

    public int GetTotalDamage()
    {
        return damage * critMultiplier * attackSpeed;
    }

    public override string ToString()
    {
        return $"Базовый урон = {damage}, Множитель урона = {critMultiplier}, Скорость атаки = {attackSpeed}";
    }
}