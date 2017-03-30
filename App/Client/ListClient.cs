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
    public partial class ListClient : Form
    {
        public ListClient()
        {
            InitializeComponent();
        }

        private void ListClient_Load(object sender, EventArgs e)
        {
            clientListDgv.DataSource = ClientServices.ListClient();
            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
            btnColumn.HeaderText = "#";
            btnColumn.Text = "Edit";
            btnColumn.UseColumnTextForButtonValue = true;
            clientListDgv.Columns.Add(btnColumn);
        }

        private void clientListDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0) {
                string IdStr = clientListDgv.Rows[e.RowIndex].Cells[1].Value.ToString();
                int Id = int.Parse(IdStr);
                EditClient editForm = new EditClient(ClientServices.GetClientById(Id), this);
                editForm.Show();
            }
        }
    }
}
