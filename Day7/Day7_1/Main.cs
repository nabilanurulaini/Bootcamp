using System;

namespace Day7_1
{
    static class Program
    {
       // delegate T MyDelegate<T>(string mesagge);
        public static void Main()
        {
            Publisher publisher = new ();
            Subscriber subscriber = new ();
            Subscriber1 subscriber1 = new ();

            //ini digunakan untuk mendaftarkan subsriber ke publisher, jika tidak di daftarkan maka tidak akan menerima event, dan hanya output do something
            // kalau pakai += dia akan mendaftarkan subscriber baru dan tidak akan menghapus yang lama jadi akan memberikan value yang ada di RaiseEVent yaitu Hello
            publisher.MyEvent += subscriber.MyEventHandler;
            publisher.MyEvent += subscriber1.MyEventHandler1;
   
            //publisher.RaiseEvent("Hello");
            publisher.DoSomething();

            //subscriber.Subscribe(publisher);
            //publisher.DoSomething();
            // Console.WriteLine("Hello World!");
        }
    }
}