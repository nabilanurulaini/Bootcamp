namespace Day7_5;

public class Subscriber
{
    public void Subscribe(Publisher publisher)
    {
        publisher.MyEvent += MyEventHandler;
    }
    public void MyEventHandler(object sender, ProcessEvent e)
    {
        string time = DateTime.Now.ToString("HH:mm:ss");
        Console.WriteLine($"Subscriber 1 : {e.Message} at {time}");
    }
}
public class Subscriber1{
    public void MyEventHandler1(object sender, ProcessEvent e)
    {
        string time = DateTime.Now.ToString("HH:mm:ss");
        Console.WriteLine($"Subscriber 2 : {e.Message} at {time}");
    }
}