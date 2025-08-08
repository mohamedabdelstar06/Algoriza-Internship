

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace EF_Core.Models;
public class Book
{
    //[Key]
    public int Abdelstar { get; set; }
    public string Name { get; set; }
    public string  Author { get; set; }
}
