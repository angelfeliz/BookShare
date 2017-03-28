using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DAL.BookShopContext context = new DAL.BookShopContext();
            DAL.Repository.BaseRepository<DAL.Model.Client> db = new DAL.Repository.BaseRepository<DAL.Model.Client>(context);

        }
    }
}
