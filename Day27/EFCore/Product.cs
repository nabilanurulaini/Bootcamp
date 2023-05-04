using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCore;

public class Product
{
    //karena sudah menggunakan nama ProductID, maka tidak perlu menambahkan [Key]
    public int ProductID { get; set; }
    [Required]
    [StringLength(40)]
    public string ProductName { get; set; } = null!;

    [Column("UnitPrice", TypeName = "money")]
    public decimal? Cost { get; set; }
    [Column("UnitsInStock")]
    public short? Stock { get; set; }
    public bool Discontinued { get; set; }
    public int CategoryID { get; set; }
    //karena 1 product hanya memiliki 1 category, maka kita buat Category (untuk hubungan one to one)
    public virtual Category Category { get; set; } = null!;

}
