

using CQRS_lib.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace CQRS_lib.Repos;
public interface IItemsRepo
{
    public List<Items> GetItems();
    public Items GetItem(int id);
    public int InsertItem(Items item);
    public int UpdateItem(Items item);
    public int DeleteItem(int id);

}

