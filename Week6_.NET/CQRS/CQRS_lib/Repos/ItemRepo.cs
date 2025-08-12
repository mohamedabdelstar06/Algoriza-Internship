
using CQRS_lib.Data;
using CQRS_lib.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace CQRS_lib.Repos;
public class ItemRepo : IItemsRepo
{
    private ApplicationDbContext _db;

    public ItemRepo(ApplicationDbContext applicationDb)
    {
        _db = applicationDb;
    }

    public List<Items> GetItems()
    {
        return _db.Items.ToList();
        
    }
    public Items GetItem(int id)
    {
        var item = _db.Items.Where(x => x.Id ==id).FirstOrDefault();
        return item ?? new();
    }

    public int InsertItem(Items item)
    {
        _db.Items.Add(item);
        return _db.SaveChanges();
    }

    public int UpdateItem(Items item)
    {
        try
        {
            _db.Items.Attach(item);
            _db.Entry(item).State = EntityState.Modified;
            return 1;
        }
        catch
        {
            return 0;
        }
    }

    public int DeleteItem(int id)
    {
        var item = _db.Items.Where(x => x.Id ==id).FirstOrDefault();
        if (item != null)
            _db.Items.Remove(item);
        return _db.SaveChanges();
    }

    
   

   
}
