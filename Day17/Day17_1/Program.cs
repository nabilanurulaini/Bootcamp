using System.Diagnostics;

Trace.Listeners.Clear();
Debug.WriteLine("Debug");
Debug.Assert(false, "Debug Assert");
//ini adalah path dimana penyimpanan txt delimiternya akan disimpan
string path = @"C:\Users\Formulatrix\Documents\GitHub\Bootcamp\Day17\Day17_1\Trace.csv";
TextWriterTraceListener listener = new (path);
if(File.Exists(path))
{
    File.Delete(path);
}
//menambahkan kedalam listener trace 
Trace.Listeners.Add(listener);

Trace.Assert(false, DateTime.Now.ToString());

listener.Flush();
listener.Close();