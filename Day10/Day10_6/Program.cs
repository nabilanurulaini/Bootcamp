using System;
using System.Collections;
using System.Linq;
class Program
{
    static void Main()
    {
        PatientQueue queue = new();

        // Enqueue pasien
        queue.Enqueue(new Patient("Jono", "Sakit kepala"));
        queue.Enqueue(new Patient("Joni", "Demam"));
        queue.Enqueue(new Patient("Budi", "Flu"));
        queue.Enqueue(new Patient("Adam", "Luka bakar"));
        queue.Enqueue(new Patient("Hawa", "Patah tulang"));

       
        queue.Enqueue(new Patient("Pasien 1", "Sakit kepala"));
        queue.Enqueue(new Patient("Pasien 2", "Demam"));
        queue.Enqueue(new Patient("Pasien 3", "Flu"));
        queue.Enqueue(new Patient("Pasien 4", "Luka bakar"));
        queue.Enqueue(new Patient("Pasien 5", "Patah tulang"));
        // Dequeue pasien
        while (queue.Count > 0)
        {
            int i = queue.Count;
            

            Patient nextPatient = queue.Dequeue();
            
            Console.WriteLine("Pasien ke "+nextPatient.Name+", "+ nextPatient.Condition);
        }
        
        List<Patient> ClonedQueue = queue.Clone();
        Console.WriteLine(+ClonedQueue.Count);
        foreach(var item in ClonedQueue){
            Console.WriteLine(item);
        }
        Console.WriteLine("");
    }
}

class Patient
{
    public string Name { get; }
    public string Condition { get;  }

    public Patient(string name, string condition)
    {
        Name = name;
        Condition = condition;
    }
}

class PatientQueue
{
    private Queue<Patient> queue = new();
    

    public int Count
    {
        get
        {
            return queue.Count;
        }
    }

    public void Enqueue(Patient patient)
    {
        queue.Enqueue(patient);
    }

    public Patient Dequeue()
    {
        return (Patient)queue.Dequeue();
    }
    public List<Patient> Clone(){
        List<Patient> MyList = queue.ToList();
        return MyList;
    }

}
