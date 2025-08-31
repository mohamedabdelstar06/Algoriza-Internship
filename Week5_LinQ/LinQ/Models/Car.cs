using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core.Models;
public class Car
{
    public int Id { get; set; }
    public string LicensePlate{ get; set; }
    public string Make { get; set; }
    public string Model { get; set; }

    public List<RecordOfSale> SalesHistory{ get; set; }
}

public class RecordOfSale
{
    public int RecordOfSaleId { get; set; }
    public DateTime DateSold { get; set; }
    public decimal Price { get; set; }
    public string CareLicencePlate  { get; set; }
    public Car Car { get; set; }
   
}