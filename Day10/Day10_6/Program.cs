using System;
using System.Collections;

class Program
{
    static void Main()
    {
        PatientQueue queue = new();

        // Enqueue pasien baru
        queue.Enqueue(new Patient("Jono", "Sakit kepala"));
        queue.Enqueue(new Patient("Joni", "Demam"));
        queue.Enqueue(new Patient("Ismail", "Flu"));
        queue.Enqueue(new Patient("Adam", "Luka bakar"));
        queue.Enqueue(new Patient("Hawa", "Patah tulang"));
        List<Patient> list = queue.ToList();
        Console.WriteLine("Daftar Pasien:");
        foreach (Patient patient in list)
        {
            //assign list index pasien ditambah 1 karena mulai dari 0 ke dalam variabel i
            int i = list.IndexOf(patient)+1;
            Console.WriteLine(i+". "+patient.Name+", "+patient.Condition);
        }
        // Menu bisa pilih 1 atau dua selain itu menu tidak tersedia
        Console.WriteLine("\n1. Cari Pasien");
        Console.WriteLine("2. Update Pasien dan Lihat Daftar Pasien yang Tersisa");
        Console.Write("Pilih menu: ");
        int pilih = Convert.ToInt32(Console.ReadLine());
        switch(pilih)
        {
            case 1:
            Console.Write("Masukkan nama pasien: ");
            string CariNama = Console.ReadLine().ToLower();
            bool ketemu = false;

            foreach (Patient patient in list)
            {
               
                if (CariNama == patient.Name.ToLower())
                {   
                    Console.WriteLine("Pasien ditemukan:");
                    int CariIndex = list.IndexOf(patient)+1;
                    Console.WriteLine(patient.Name + ", " + patient.Condition+" index ke "+CariIndex);
                    ketemu = true;
                    Console.WriteLine("Klik enter untuk keluar");
                    Console.ReadKey();
                    break;
                }
            
                else
                {
                    ketemu = false;
                }
            }
            break;
            case 2:
             // akan berkurang karena pasien pertama sudah diperiksa
                Console.WriteLine("Update Pasien : "+queue.Dequeue().Name);
                Console.WriteLine("Cek daftar pasian yang tersisa : ");
                List<Patient> list2 = queue.ToList();
                
                foreach (Patient patient in list2)
                {
                     int CariIndex1 = list.IndexOf(patient)+1;
                    Console.WriteLine(CariIndex1+". "+patient.Name+", "+patient.Condition);
                }
                break;
            default:
                Console.WriteLine("Menu tidak tersedia");
                break;
        } 
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
    private Queue<Patient> queue = new Queue<Patient>();
    public int Count
    {
        get
        {
            return queue.Count;
        }
    }
    public void Add(Patient patient)
    {
        queue.Enqueue(patient);
    }
    public void Enqueue(Patient patient)
    {
        queue.Enqueue(patient);
    }
    public Patient Dequeue()
    {
        return (Patient)queue.Dequeue();
    }
    public Patient Peek()
    {
        return (Patient)queue.Peek();
    }
    public void Clear()
    {
        queue.Clear();
    }
    public List<Patient> ToList()
	{
		return queue.ToList();
	}
}
