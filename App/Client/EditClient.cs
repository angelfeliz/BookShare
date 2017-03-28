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
    public partial class EditClient : Form
    {
        public EditClient(DAL.Model.Client client)
        {
            InitializeComponent();
            firstNameTxt.Text = client.FirstName;
            lastNameTxt.Text = client.LastName;
            phoneTxt.Text = client.Phone;
            categoryCbx.DataSource = new BindingSource(ClientServices.GetClientCategorys(), null);
            categoryCbx.DisplayMember = "Value";
            categoryCbx.ValueMember = "Key";
            categoryCbx.SelectedValue = client.Category;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            DAL.Model.Client client = new DAL.Model.Client();
            client.FirstName = firstNameTxt.Text;
            client.LastName = lastNameTxt.Text;
            client.Phone = phoneTxt.Text;
            client.Category = int.Parse(categoryCbx.SelectedValue.ToString());

            ClientServices.UpdateClient(client);
        }
     }
}
