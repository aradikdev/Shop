using System.ComponentModel.DataAnnotations;

namespace Shop.Models;

public class Products
{
    [Key]
    public int Product_id { get; set; }
    public string Name { get; set; }
    public int Price { get; set; }
    public string Info { get; set; }

    public int Category_id { get; set; }
    public Categories Categories { get; set; }
    public int Brand_id { get; set; }
    public Brands Brands { get; set; }

}
