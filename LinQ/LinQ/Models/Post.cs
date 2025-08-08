

using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Core.Models;

public class Post //Dependent Entity
{
    public int Id{ get; set; } 
    public string Title{ get ; set; }
    public string Content{ get; set; }
    // Forien Key
    //  Refernce Navigation Properety

    public int BlogId { get; set; } // لازم تضيف السطر ده
    public Blog Blog { get; set; }


}
