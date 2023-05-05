namespace EFCore;

public partial class Program
{
    //add category
    public static void AddCategory()
    {
        using (Northwind db = new Northwind())
        {
            PrintTitle("Add Category");
            Print("Input new category name = ");
            string inputCategory = GetInput();
            Category category = new Category
            {
                CategoryName = inputCategory
            };
            db.Categories.Add(category);
            db.SaveChanges();

            PrintSuccessMessage("Success add new category");
            PrintLn("");
            ShowCategory();
        }
    }
    //show category
    public static void ShowCategory()
    {
        using (Northwind db = new Northwind())
        {
            PrintTitle("Show Category");
            var categories = db.Categories.OrderBy(c => c.CategoryID);
            foreach (var category in categories)
            {
                PrintLn($"{category.CategoryID}. {category.CategoryName}");
            }
        }
    }
    //find category by name 
    public static void FindCategory()
    {
        using (Northwind db = new Northwind())
        {
            PrintTitle("Find Category");
            Print("Input category name = ");
            string inputCategory = GetInput();
            var categories = db.Categories.Where(c => c.CategoryName.Contains(inputCategory));
            //check category is exist
            if (categories.Count() == 0)
            {
                PrintFailedMessage("Category not found");
                PrintLn("");
                return;
            }
            else
            {
                foreach (var category in categories)
                {
                    PrintLn($"{category.CategoryID}. {category.CategoryName}");
                }
            }
        }
        PrintLn("");
    }
    //edit category
    public static void EditCategory()
    {
        using (Northwind db = new Northwind())
        {
            
            
            ShowCategory();
            PrintTitle("Edit Category");
            Print("Input category id = ");
            int inputCategoryID = Convert.ToInt32(GetInput());
            
            Print("Input new category name = ");
            string inputCategory = GetInput();
            
            Category category = db.Categories.Find(inputCategoryID);
            category.CategoryName = inputCategory;
            db.SaveChanges();
            
            PrintSuccessMessage("Success edit category");
            PrintLn("");
            ShowCategory();
        }
    }
    //delete category by Id
    public static void DeleteCategoryById()
    {
        using (Northwind db = new Northwind())
        {
            ShowCategory();

            PrintTitle("Delete Category By Id ");

            Print("Input category id = ");
            int inputCategoryID = Convert.ToInt32(GetInput());

            Category category = db.Categories.Find(inputCategoryID);
            db.Categories.Remove(category);
            db.SaveChanges();
           
           
            PrintSuccessMessage("Success delete category");
            PrintLn("");
    
            ShowCategory();
        }
    }
    //delete category by name
    public static void DeleteCategoryByName()
    {
        using (Northwind db = new Northwind())
        {
            ShowCategory();

            PrintTitle("Delete Category By Name ");

            Print("Input category name = ");
            string inputCategoryName = GetInput();

            Category category = db.Categories.Where(c => c.CategoryName == inputCategoryName).FirstOrDefault();
            db.Categories.Remove(category);
            db.SaveChanges();
           
           
            PrintSuccessMessage("Success delete category");
            PrintLn("");
    
            ShowCategory();
        }
    
    }
    //show category with description
    public static void ShowCategoryWithDescription()
    {
        using(Northwind db = new Northwind())
        {
            PrintTitle("Show Category With Description");
            var categories = db.Categories.OrderBy(c => c.CategoryID);
            foreach (var category in categories)
            {
                PrintLn($"{category.CategoryID}. {category.CategoryName} - {category.Description}");
            }
        }
        PrintLn("");
    }
    //add category description
    public static void AddCategoryDescriptionById()
    {
        using(Northwind db = new Northwind())
        {
            ShowCategory();
            PrintTitle("Add Category Description");
            
            Print("Input category id = ");
            int inputCategoryID = Convert.ToInt32(GetInput());

            Print("Input category description = ");
            string inputCategoryDescription = GetInput();

            Category category = db.Categories.Find(inputCategoryID);
            category.Description = inputCategoryDescription;

            db.SaveChanges();

            PrintSuccessMessage("Success add category description");
            PrintLn("");

            ShowCategory();
        }
    }

    
}
