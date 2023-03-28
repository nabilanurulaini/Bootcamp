namespace Day8_1;

class MyClass{
    private int value;
    //ini constructor
    public MyClass(int value){
        this.value = value;
    }
    public static string operator + (MyClass a, MyClass b){
        return (a.value + b.value).ToString();
    }
    public static string operator - (MyClass a, MyClass b){
        return (a.value - b.value).ToString();
    }
    public static string operator * (MyClass a, MyClass b){
        return (a.value * b.value).ToString();
    }
    public static string operator / (MyClass a, MyClass b){
        return (a.value / b.value).ToString();
    }
}