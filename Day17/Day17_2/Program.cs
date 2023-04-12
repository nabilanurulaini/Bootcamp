using System.Diagnostics;

Trace.Listeners.Clear();
//ini adalah path dimana penyimpanan txt delimiternya akan disimpan
string path = @"C:\Users\Formulatrix\Documents\GitHub\Bootcamp\Day17\Day17_2\Trace.csv";
DelimitedListTraceListener listener = new (path);
if(File.Exists(path))
{
    File.Delete(path);
}
listener.Delimiter = ",";
Trace.Write("Date, Message");
//menambahkan kedalam listener trace 
Trace.Listeners.Add(listener);

Trace.Write(DateTime.Now.ToString());

Trace.Write("satu");

listener.Flush();
listener.Close();