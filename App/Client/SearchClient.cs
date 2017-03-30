using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Services;

namespace App.Client
{
    public partial class SearchClient : Form
    {
        public SearchClient()
        {
            InitializeComponent();
        }

        private void SearchClient_Load(object sender, EventArgs e)
        {
            clientDgv.DataSource = Services.ClientServices.ListClient();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            DataTable dt = new DataTable();
            dt = (DataTable)Services.ClientServices.ListClient();
            var clients = Services.ClientServices.ListClient().ToList();
            var filter = dt;
            clientDgv.DataSource = clients;

        }
    }
}
