using System;
using System.Threading;

class Program
{
    static EventWaitHandle waitHandle = new EventWaitHandle(false, EventResetMode.AutoReset);

    static void Main(string[] args)
    {
        Console.WriteLine("Main thread waiting for signal form worker");
        // menunggu antrian dari threadpool dan menjalankan worker thread
        ThreadPool.QueueUserWorkItem(WorkerThread);
       //  Task task1 = Task.Run(() => WorkerThread("Task 1"));
        waitHandle.WaitOne();
        Console.WriteLine("Main thread received signal");
    }

    static void WorkerThread(object state)
    {
        Console.WriteLine("Worker thread started");

        waitHandle.Set();
        Console.WriteLine("Worker thread signaled");
    }
}
