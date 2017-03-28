using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DAL.Model;

namespace App
{
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
            Dictionary<string, string> category = new Dictionary<string, string>();
            category.Add("1", "Standard");
            category.Add("2", "Premium");
            category.Add("3", "VIP");
            categoryCbx.DataSource = new BindingSource(category, null);
            categoryCbx.DisplayMember = "Value";
            categoryCbx.ValueMember = "Key";
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            BookShopContext _context = new BookShopContext();
            DAL.Repository.BaseRepository<Client> _db = new DAL.Repository.BaseRepository<Client>(_context);

            Client _client = new Client();
            _client.FirstName = firstNameTxt.Text;
            _client.LastName = lastNameTxt.Text;
            _client.Phone = phoneTxt.Text;
            _client.Category = int.Parse(categoryCbx.SelectedValue.ToString());

            _db.Add(_client);
        }
    }
}
