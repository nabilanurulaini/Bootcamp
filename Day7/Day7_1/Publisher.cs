namespace Day7_1;

public class Publisher
{
    public delegate void MyDelegate(string message);
    public event MyDelegate? MyEvent;
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
                del.Invoke(message);
                Thread.Sleep(1000);
            }
        }
        //MyEvent?.Invoke(name);
    }
}
// public class ProsessEvent : EventArgs
// {
//     public string Message { get; }
//     public DateTime CompletionTime { get; set; }
//     public ProsessEvent(string message)
//     {
//         Message = message;
//     }
// }