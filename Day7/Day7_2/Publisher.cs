namespace Day7_2;

public class Publisher
{
    // public delegate void MyDelegate(string message);
    public event EventHandler<ProsessEvent> MyEvent;
    public void DoSomething()
    {
        Console.WriteLine("Do something");
        RaiseEvent("Hallo");
    }
    public virtual void RaiseEvent(string message)
    {
        if(MyEvent != null)
        {
            foreach(MyDelegate del in MyEvent.GetInvocationList())
            {
                del.Invoke(this, new ProsessEvent(message));
                Thread.Sleep(1000);
            }
        }
        //MyEvent?.Invoke(name);
    }
}
public class ProsessEvent : EventArgs
{
    public string Message { get; }
    public ProsessEvent(string message)
    {
        Message = message;
    }
}
