namespace EF_Core.Models;

public class BlogImage
{
    public int Id{ get; set; }
    public string Image{ get; set; }
    public string Captain{ get; set; }
    public int BlogId{ get; set; }
    public Blog Blog{ get; set; }
}