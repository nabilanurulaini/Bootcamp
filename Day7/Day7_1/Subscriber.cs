namespace Day7_1;

public class Subscriber
{
    public void Subscribe(Publisher publisher)
    {
        publisher.MyEvent += MyEventHandler;
    }
    public void MyEventHandler(string message)
    {
        Console.WriteLine($"Subscriber 1 : {message}");
        
    }
}
public class Subscriber1{
    public void Subscribe1(Publisher publisher)
    {
        publisher.MyEvent += MyEventHandler1;
    }
    public void MyEventHandler1(string mesagge)
    {
        Console.WriteLine($"Subscriber 2 : {mesagge}");
    }
}
