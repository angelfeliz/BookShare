using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Model;
using DAL.Repository;

namespace Services
{
    public static class ClientServices
    {
        private static BookShopContext _context =  new BookShopContext();
        private static BaseRepository<Client> _db =  new BaseRepository<Client>(_context);
        
        public static ICollection<Client> ListClient()
        {
            return _db.GetAll();   
        }

        public static string AddClient(Client entity)
        {
            try
            {
                _db.Add(entity);

                return "Ok";
            }
            catch (Exception e) {

                throw;
            }            
        }

        public static Client GetClientById(int Id)
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
        }
        public static Dictionary<string, string> GetClientCategorys()
        {
            Dictionary<string, string> category = new Dictionary<string, string>();
            category.Add("1", "Standard");
            category.Add("2", "Premium");
            category.Add("3", "VIP");

            return category;
        }

    }
}
