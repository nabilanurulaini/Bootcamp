namespace Day7_2;

public class Subscriber
{
    public string data;
    public void Subscribe(Publisher publisher)
    {
        publisher.MyEvent += MyEventHandler;
    }
    public void MyEventHandler(object sender, ProssesEvent e)
    {
        string result = ((Publisher)sender).DoSomething();
        Console.WriteLine($"Subscriber 1 : {e.message, time}");
       
    }
}
public class Subscriber1{
    public void Subscribe1(Publisher publisher)
    {
        publisher.MyEvent += MyEventHandler1;
    }
    public void MyEventHandler1(object sender, ProssesEvent e)
    {
        string result = ((Publisher)sender).DoSomething();
        Console.WriteLine($"Subscriber 2 : {e.mesagge}");
       
    }
}
