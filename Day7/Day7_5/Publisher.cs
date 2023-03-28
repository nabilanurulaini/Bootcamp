namespace Day7_5;
//public delegate void Notify();
class ProcessEventArgs : EventArgs
{
    public bool IsSuccessful { get; set;}
    public DateTime CompletionTime { get; set;}
}
public class ProcessBusinessLogic
{
    public event EventHandler<ProcessEventArgs> ProcessCompleted; // event

    public void StartProcess()
    {
		var data = new ProcessEventArgs();
		
		try
		{
			Console.WriteLine("Process Started!");
			
			//uncomment following to see the result
			//throw new NullReferenceException();
			
        	// some process code here..
			
			data.IsSuccessful = true;
			data.CompletionTime = DateTime.Now;
        	OnProcessCompleted(data);
		}
		catch(Exception ex)
		{
			data.IsSuccessful = false;
			data.CompletionTime = DateTime.Now;
			OnProcessCompleted(data);
		}
    }


    protected virtual void OnProcessCompleted(ProcessEventArgs e)
    {
        ProcessCompleted?.Invoke(this, e);
    }
}
