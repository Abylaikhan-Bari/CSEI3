using System;

class MyClass
{
    public int Value { get; }

    public MyClass(int value)
    {
        Value = value;
    }

    public static bool operator ==(MyClass obj1, MyClass obj2)
    {
        if (ReferenceEquals(obj1, obj2))
            return true;
        if (obj1 is null || obj2 is null)
            return false;
        return obj1.Value == obj2.Value;
    }

    public static bool operator !=(MyClass obj1, MyClass obj2)
    {
        return !(obj1 == obj2);
    }

    public override bool Equals(object obj)
    {
        if (obj is MyClass other)
        {
            return this.Value == other.Value;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return Value.GetHashCode();
    }
}
