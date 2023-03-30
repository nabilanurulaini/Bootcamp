using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        PatientQueue queue = new PatientQueue();

        // Enqueue pasien
        queue.Enqueue(new Patient("Pasien 1", "Sakit kepala"));
        queue.Enqueue(new Patient("Pasien 2", "Demam"));
        queue.Enqueue(new Patient("Pasien 3", "Flu"));
        queue.Enqueue(new Patient("Pasien 4", "Luka bakar"));
        queue.Enqueue(new Patient("Pasien 5", "Patah tulang"));

       
        // Dequeue pasien
        while (queue.Count > 0)
        {
            Patient nextPatient = queue.Dequeue();
            Console.WriteLine("Pasien selanjutnya: "+nextPatient.Name+", "+ nextPatient.Condition);
        }

        Console.ReadKey();
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
    private Queue queue = new Queue();

    public int Count { get 
    { 
        return queue.Count; 
        } }

    public void Enqueue(Patient patient)
    {
        queue.Enqueue(patient);
    }

    public Patient Dequeue()
    {
        return (Patient)queue.Dequeue();
    }
}
