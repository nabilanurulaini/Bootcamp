
namespace EFCore
{
    public partial class Program
    {
        public static void Main()
        {

            Northwind db = new Northwind();
            //print Microsoft.EntityFrameworkCore.Sqlite ini tandanya jika database sudah connect
            Console.WriteLine(db.Database.ProviderName);
            //show menu progam
            Menu();
        }
        static void Menu()
        {
            string inputMenu;
            bool isValidInput = false;
            Clear();
            while(!isValidInput)
            {   
                PrintTitle("Menu");
                PrintLn("1. Menu For Category");
                PrintLn("2. Menu For Product");
                PrintLn("1. Add Category");
                PrintLn("2. Show Category");
                PrintLn("3. Find Category");
                PrintLn("4. Edit Category");
                PrintLn("5. Delete Category By Id");
                PrintLn("6. Delete Category By Name");
                PrintLn("7. Show Category With Description");
                PrintLn("8. Add Category Description By Id");
                PrintLn("9. Show Product With Category And Stock");
                PrintLn("10. Search Product By Stock");
                PrintLn("11. Show SUpplier With Product");
                PrintLn("12. Exit");
                Print("Choose menu = ");
                inputMenu = GetInput();
                switch(inputMenu)
                {
                    case "1":
                        AddCategory();
                        break;
                    case "2":
                        ShowCategory();
                        break;
                    case "3":
                        FindCategory();
                        break;
                    case "4":
                        EditCategory();
                        break;
                    case "5":
                        DeleteCategoryById();
                        break;
                    case "6":
                        DeleteCategoryByName();
                        break;
                    case "7":
                        ShowCategoryWithDescription();
                        break;
                    case "8":
                        AddCategoryDescriptionById();
                        break;
                    case "9":
                        ShowProductWithCategoryAndStock();
                        break;
                    case "10":
                        SearchProductByStock();
                        break;
                    case "11":
                        ShowSupplierWithProduct();
                        break;
                    case "12":
                        isValidInput = true;
                        break;
                    default:
                        PrintLn("Invalid input");
                        break;
                }   
            }
        
        }
    }
}