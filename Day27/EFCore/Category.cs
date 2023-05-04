using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCore;

public class Category
{
    [Key]
    public int CategoryID { get; set; }
    [Required]// harus reqired karena not null
    [StringLength(15)]
    public string CategoryName { get; set; } = null!;
    [Column(TypeName = "ntext")]
    public string? Description { get; set; }
    //karena 1 category bisa memiliki banyak product, maka kita buat ICollection (untuk hubungan one to many
    //dibuat virtual agar bisa lazy loading (bisa diakses dari luar class, hanya data yang dibutuhkan yang diload) dan eager loading (tidak bisa diakses dari luar class, load semua data) dan manual loading (bisa diakses dari luar class, hanya data yang dibutuhkan yang diload)
    public virtual ICollection<Product> Products { get; set; } = null!;
    public Category()
    {
        //setiap product yang dibuat akan dimasukkan ke dalam ICollection dan hasrus berbeda karena hashset tidak bisa memiliki duplikat
        Products = new HashSet<Product>();
    }   

}
