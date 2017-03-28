using DAL.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BookShopContext : DbContext
    {
        public BookShopContext(): base("name=BookShop")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<BookShopContext, Migrations.Configuration>("BookShop"));
        }
        public DbSet<Book> Book { get; set; }
        public DbSet<Client> Client { get; set; }
    }
}
