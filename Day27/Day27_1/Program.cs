using DB;
namespace ProgramDB
{
    public class Program
    {
        public static void Main()
        {

            Northwind db = new Northwind();
            //print Microsoft.EntityFrameworkCore.Sqlite ini tandanya jika database sudah connect
            Console.WriteLine(db.Database.ProviderName);
            //menampilkan semua data dari table categories
            
        }
    }
}