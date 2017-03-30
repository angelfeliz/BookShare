using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace App.Client
{
    public partial class SearchClient : Form
    {
        private ShopForm _shopForm;
        public SearchClient()
        {
            InitializeComponent();
        }

        public SearchClient(Form parent)
        {
            InitializeComponent();
            _shopForm = parent as ShopForm;
        }
        private void SearchClient_Load(object sender, EventArgs e)
        {
            clientDgv.DataSource = Services.ClientServices.ListClient();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {            
            string lastName = lastNameTxt.Text;                        
            clientDgv.DataSource = Services.ClientServices.ListClient().Where(x => x.LastName.Contains(lastName)).ToList();
        }

        private void clientDgv_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _shopForm.clientIdTxt.Text = clientDgv.Rows[e.RowIndex].Cells[0].Value.ToString();
            _shopForm.fullNameTxt.Text = clientDgv.Rows[e.RowIndex].Cells[1].Value.ToString() + " " + clientDgv.Rows[e.RowIndex].Cells[2].Value.ToString();

            int memeberShipTypeId = int.Parse(clientDgv.Rows[e.RowIndex].Cells[4].Value.ToString());

            _shopForm.memberShipTypeId = memeberShipTypeId;
            switch (memeberShipTypeId)
            {
                case (int)Constants.MembershiptCategory.Standard:
                    _shopForm.memeberLbl.Text = "Standard";
                break;

                case (int)Constants.MembershiptCategory.Premium:
                    _shopForm.memeberLbl.Text = "Premium";
                break;

                case (int)Constants.MembershiptCategory.VIP:
                    _shopForm.memeberLbl.Text = "VIP";
                break;
                    
                default:
                    _shopForm.memeberLbl.Text = "No registered";
                break;
            }

            this.Close();
        }
    }
}
