namespace Day7_5;

public static class Subscriber
{
    public void Bl_ProcessCompleted(object sender, ProcessEventArgs e)
    {
        Console.WriteLine("Process " + (e.IsSuccessful? "Completed Successfully": "failed"));
		Console.WriteLine("Completion Time: " + e.CompletionTime.ToLongDateString());
    }

   
}
