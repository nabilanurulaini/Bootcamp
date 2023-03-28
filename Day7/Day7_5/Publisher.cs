namespace Day7_5;

public class ProcessEvent : EventArgs
{
    public string Message { get; }
    public ProcessEvent(string message)
    {
        Message = message;
    }
}
public class Publisher
{
    // public delegate void MyDelegate(string message);
    public event EventHandler<ProcessEvent> MyEvent;
    public string data;
    public void DoSomething()
    {
        Console.WriteLine("Processing . . .");
        RaiseEvent("Posted a Message");
    }
    public virtual void RaiseEvent(string message)
    {
        MyEvent?.Invoke(this, new ProcessEvent(message));
        Console.WriteLine("Completed!");
    }
}
