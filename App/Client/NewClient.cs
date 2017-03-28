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
    public partial class NewClient : Form
    {
        public NewClient()
        {
            InitializeComponent();            
            categoryCbx.DataSource = new BindingSource(ClientServices.GetClientCategorys(), null);
            categoryCbx.DisplayMember = "Value";
            categoryCbx.ValueMember = "Key";
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            DAL.Model.Client client = new DAL.Model.Client();
            client.FirstName = firstNameTxt.Text;
            client.LastName = lastNameTxt.Text;
            client.Phone = phoneTxt.Text;
            client.Category = int.Parse(categoryCbx.SelectedValue.ToString());

            try
            {
                Services.ClientServices.AddClient(client);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
