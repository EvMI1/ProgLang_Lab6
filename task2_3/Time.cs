namespace Lab6;

internal class Time
{
    private byte _hours;
    private byte _minutes;

    public Time(byte hours, byte minutes)
    {
        Hours = hours;
        Minutes = minutes;
    }

    public Time(Time obj)
    {
        _hours = obj._hours;
        _minutes = obj._minutes;
    }

    public byte Hours
    {
        get 
        { 
            return _hours;
        }
        set
        {
            if (value > 23)
                throw new ArgumentOutOfRangeException(nameof(value),
                "Часы должны быть в диапазоне [0; 23].");
            _hours = value;
        }
    }

    public byte Minutes
    {
        get 
        { 
            return _minutes; 
        }
        set
        {
            if (value > 59)
                throw new ArgumentOutOfRangeException(nameof(value),
                "Минуты должны быть в диапазоне [0; 59].");
            _minutes = value;
        }
    }

    public Time Subtract(Time obj)
    {
        int totalMinutes = _hours * 60 + _minutes;
        int otherMinutes = obj._hours * 60 + obj._minutes;
        int result = totalMinutes - otherMinutes;
        result = ((result % 1440) + 1440) % 1440;
        return new Time((byte)(result / 60), (byte)(result % 60));
    }

    public static Time operator ++(Time t)
    {
        int totalMinutes = t._hours * 60 + t._minutes + 1;
        int result = ((totalMinutes % 1440) + 1440) % 1440;
        return new Time((byte)(result / 60), (byte)(result % 60));
    }

    public static Time operator --(Time t)
    {
        int totalMinutes = t._hours * 60 + t._minutes - 1;
        int result = ((totalMinutes % 1440) + 1440) % 1440;
        return new Time((byte)(result / 60), (byte)(result % 60));
    }

    public static implicit operator int(Time t)
    {
        return t._hours * 60 + t._minutes;
    }

    public static explicit operator bool(Time t)
    {
        return t._hours != 0 || t._minutes != 0;
    }

    public static bool operator <(Time t1, Time t2)
    {
        return (int)t1 < (int)t2;
    }

    public static bool operator >(Time t1, Time t2)
    {
        return (int)t1 > (int)t2;
    }

    public override string ToString()
    {
        return $"{_hours:D2}:{_minutes:D2}";
    }
}