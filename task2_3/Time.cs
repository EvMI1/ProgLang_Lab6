using Microsoft.Win32.SafeHandles;

namespace Lab6;

internal class Time
{
    private byte hours;
    private byte minutes;

    public Time(byte hours, byte minutes)
    {
        Hours = hours;
        Minutes = minutes;
    }

    public Time(Time obj)
    {
        hours = obj.hours;
        minutes = obj.minutes;
    }

    public byte Hours
    {
        get { return hours; }
        set
        {
            if (value > 23)
                throw new ArgumentOutOfRangeException("value", "Часы должны быть в диапазоне [0; 23].");
            hours = value;
        }
    }

    public byte Minutes
    {
        get { return minutes; }
        set
        {
            if (value > 59)
                throw new ArgumentOutOfRangeException("value", "Минуты должны быть в диапазоне [0; 59].");
            minutes = value;
        }
    }

    public Time Subtract(Time obj)
    {
        int totalMinutes = hours * 60 + minutes;
        int otherMinutes = obj.hours * 60 + obj.minutes;
        int result = totalMinutes - otherMinutes;
        result = ((result % 1440) + 1440) % 1440;
        return new Time((byte)(result / 60), (byte)(result % 60));
    }

    public static Time operator ++(Time t)
    {
        int totalMinutes = t.hours * 60 + t.minutes + 1;
        int result = ((totalMinutes % 1440) + 1440) % 1440;
        return new Time((byte)(result / 60), (byte)(result % 60));
    }

    public static Time operator --(Time t)
    {
        int totalMinutes = t.hours * 60 + t.minutes - 1;
        int result = ((totalMinutes % 1440) + 1440) % 1440;
        return new Time((byte)(result / 60), (byte)(result % 60));
    }

    public static implicit operator int(Time t)
    {
        return t.hours * 60 + t.minutes;
    }

    public static explicit operator bool(Time t)
    {
        return t.hours != 0 || t.minutes != 0;
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
        return $"{hours:D2}:{minutes:D2}";
    }
}