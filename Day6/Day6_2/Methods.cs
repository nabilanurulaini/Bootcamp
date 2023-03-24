    public class MethodsCal<T>
    {
        public static T? Sum(T a, T b)
        {
            if(a is int key1 && b is int key2)
            {
                return (T)(object)(key1 + key2);
            }
            else if(a is int key3 && b is int key4)
            {
                return (T)(object)(key3 + key4);
            }
            else
                return default(T);
        }

    
    public static T? Multiply(T a, T b)
    {
        if(a is int key5 && b is int key6)
        {
            return (T)(object)(key5 * key6);
        }
         else if(a is int key7 && b is int key8)
        {
                return (T)(object)(key7 * key8);
        }
        else
            return default(T);
    }
    public static T? Substraction(T a, T b)
    {
        if(a is int key9 && b is int key10)
        {
            return (T)(object)(key9 - key10);
        }
        else if(a is int key11 && b is int key12)
        {
            return (T)(object)(key11 - key12);
        }
        else if(a is int key13 && b is int key14)
        {

            return (T)(object)(key13 - key14);
        }
        else
            return default(T);
    }
    }






    // public static Sum
    // {
    //         return a + b;
    // }
    //     public static int Multiply(int a, int b)
    //     {
    //         return a * b;
    //     }
    //     public static int Substraction(int a, int b)
    //     {
    //         return a - b;
    //     }
