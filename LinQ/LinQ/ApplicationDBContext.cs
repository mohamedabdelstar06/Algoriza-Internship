using EF_Core.Configuration;
using EF_Core.Models;
using Microsoft.EntityFrameworkCore;

namespace EF_Core
{
    public class ApplicationDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options) =>
             options.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=EFCoreDb;Trusted_Connection=True;");


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new BlogEntityTypeConfiguration().Configure(modelBuilder.Entity<Blog>());
            //modelBuilder.Entity<Post>()
            //    .ToTable("Postat");
            //    modelBuilder.HasDefaultSchema("Blogging");
          

            //modelBuilder.Entity<Blog>()
            //    .Property(p => p.Url).HasMaxLength(200);

            modelBuilder.Entity<Blog>()
                .Property(p => p.Url).HasComment("Mohamed Abdlstar Mazal Dawla");

            //modelBuilder.Entity<Blog>()
            //    .Property(p => p.Url);
            modelBuilder.Entity<Book>()
                .HasKey(p => p.Abdelstar)
                .HasName("PK_Abdelstar");

            //modelBuilder.Entity<Blog>()
            //    .Property(p => p.Rating).HasDefaultValue("Mohamed Abdelstar");


            modelBuilder.Entity<Author>()
                .Property(p => p.FirstName).HasMaxLength(50).IsRequired();

            modelBuilder.Entity<Author>()
                .Property(p => p.LastName).HasMaxLength(50).IsRequired();

            modelBuilder.Entity<Author>()
                .Property(p => p.DisplayName).HasMaxLength(200).IsRequired();


            modelBuilder.Entity<Author>()
                .Property(p => p.DisplayName).HasComputedColumnSql("[FirstName] + ' ' + [LastName]",stored:true);

            //modelBuilder.Entity<Category>()
            //   .Property(p => p.Name).HasMaxLength(50).IsRequired();
            //modelBuilder.Entity<Category>()
            //              .Property(p => p.Id).UseIdentityColumn(1, 1);

            //modelBuilder.Entity<Blog>()
            //   .HasMany(p => p.Posts)
            //   .WithOne();


            //modelBuilder.Entity<Post>()
            //   .HasOne(p => p.Blog)
            //   .WithMany(b=>b.Posts);

            modelBuilder.Entity<Post>()
                        .HasOne<Blog>()
                        .WithMany()
                        .HasForeignKey(p => p.BlogId)
                        ;

            modelBuilder.Entity<RecordOfSale>()
                .HasOne(r => r.Car)
                .WithMany(s => s.SalesHistory)
                .HasForeignKey(c => c.CareLicencePlate)
                .HasPrincipalKey(d => d.LicensePlate);

        

        }


        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Post> Posts{ get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        //public DbSet<Category> Categories { get; set; }
      
    }
}
