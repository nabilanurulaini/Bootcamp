using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCore;

public class Supplier
{
    [Key]
    public long SupplierId { get; set; }

    [Column(TypeName = "nvarchar (40)")]
    public string CompanyName { get; set; } = null!;

    [Column(TypeName = "nvarchar (30)")]
    public string? ContactName { get; set; }

    [Column(TypeName = "nvarchar (30)")]
    public string? ContactTitle { get; set; }

    [Column(TypeName = "nvarchar (60)")]
    public string? Address { get; set; }

    [Column(TypeName = "nvarchar (15)")]
    public string? City { get; set; }

    [Column(TypeName = "nvarchar (15)")]
    public string? Region { get; set; }

    [Column(TypeName = "nvarchar (10)")]
    public string? PostalCode { get; set; }

    [Column(TypeName = "nvarchar (15)")]
    public string? Country { get; set; }

    [Column(TypeName = "nvarchar (24)")]
    public string? Phone { get; set; }

    [Column(TypeName = "nvarchar (24)")]
    public string? Fax { get; set; }

    [Column(TypeName = "ntext")]
    public string? HomePage { get; set; }
      public virtual ICollection<Product> Products { get; set; } = null!;
    public Supplier()
    {
        //setiap product yang dibuat akan dimasukkan ke dalam ICollection dan hasrus berbeda karena hashset tidak bisa memiliki duplikat
        Products = new HashSet<Product>();
    }   
}
