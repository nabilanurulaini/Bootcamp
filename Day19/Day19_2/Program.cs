using System;
using System.Threading;

class Program
{
    static EventWaitHandle waitHandle = new EventWaitHandle(false, EventResetMode.ManualReset);

    static void Main(string[] args)
    {
        Console.WriteLine("Main thread waiting for signal form worker");
        // menunggu antrian dari threadpool dan menjalankan worker thread
        ThreadPool.QueueUserWorkItem(new WaitCallback(WorkerThread));
        //nunggu 
        waitHandle.WaitOne();
        Console.WriteLine("Main thread received signal");
    }

    static void WorkerThread(object state)
    {
        Console.WriteLine("Worker thread started");
        Thread.Sleep(2000);
        waitHandle.Set();
        Console.WriteLine("Worker thread signaled");
    }
}
