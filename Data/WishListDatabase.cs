using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Costea_Maria_ClaudiaBakery.Models;

namespace Costea_Maria_ClaudiaBakery.Data
{
    public class WishListDatabase
    {
        readonly SQLiteAsyncConnection _database;
        public WishListDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<WishList>().Wait();
        }
        public Task<List<WishList>> GetWishListsAsync()
        {
            return _database.Table<WishList>().ToListAsync();
        }
        public Task<WishList> GetWishListAsync(int id)
        {
            return _database.Table<WishList>()
            .Where(i => i.ID == id)
           .FirstOrDefaultAsync();
        }
        public Task<int> SaveWishListAsync(WishList slist)
        {
            if (slist.ID != 0)
            {
                return _database.UpdateAsync(slist);
            }
            else
            {
                return _database.InsertAsync(slist);
            }
        }
        public Task<int> DeleteWishListAsync(WishList slist)
        {
            return _database.DeleteAsync(slist);
        }

    }
}
