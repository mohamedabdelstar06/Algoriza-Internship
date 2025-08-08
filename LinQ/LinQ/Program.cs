using EF_Core;
using EF_Core.Models;

using var context = new ApplicationDBContext();

// تأكد من إنشاء قاعدة البيانات
context.Database.EnsureCreated();

// استدعاء الدالة المسؤولة عن Seeding البيانات
SeedData();


// ---------------------------
// الدالة الخاصة بإضافة البيانات التجريبية
void SeedData()
{
    var existingBlog = context.Blogs.FirstOrDefault(b => b.Url == "www.google.com");

    if (existingBlog == null)
    {
        var blog = new Blog
        {
            Url = "www.google.com"
        };

        context.Blogs.Add(blog);
        context.SaveChanges();

        Console.WriteLine("Blog seeded successfully.");
    }
    else
    {
        Console.WriteLine("Blog already exists.");
    }
}
