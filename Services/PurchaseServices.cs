using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Repository;
using DAL.Model;

namespace Services
{
    public class PurchaseServices
    {
        private static BookShopContext _context = new BookShopContext();
        private static BaseRepository<Purchase> _db = new BaseRepository<Purchase>(_context);

        public static ICollection<Purchase> ListClient()
        {
            return _db.GetAll();
        }

        public static string AddPurchase(Purchase entity)
        {
            try
            {                
                _db.AddManyToMany(entity);

                return "Ok";
            }
            catch (Exception e)
            {
                throw;
            }
        }

        /*public static Client GetClientById(int Id)
        {
            return _db.GetById(Id);
        }

        public static string UpdateClient(Client entity)
        {
            Client client = GetClientById(entity.Id);
            if (client != null)
            {
                try
                {
                    client.FirstName = entity.FirstName;
                    client.LastName = entity.LastName;
                    client.Phone = entity.Phone;
                    client.Category = entity.Category;
                    _db.Update(client);
                    return "Ok";
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
            else { return "Client not exist"; }
        }*/
       
    }
}
