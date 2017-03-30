using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.Client;
using Services;
using BusinessLayer;


namespace App
{
    public partial class ShopForm : Form
    {
        IList<DAL.Model.Book> books = new List<DAL.Model.Book>();
        private MembershipFactory _factory = new MembershipFactory();
        public ShopForm()
        {
            InitializeComponent();
        }

        private void findClientBtn_Click(object sender, EventArgs e)
        {
            SearchClient searchClient = new SearchClient();
            searchClient.ShowDialog(this);
        }

        private void ShopForm_Load(object sender, EventArgs e)
        {           
            var client = ClientServices.ListClient();
            client.Add(new DAL.Model.Client()
            {
                Id = 0,
                FirstName = "Select client"
            });
            var clientSort = client.OrderBy(x => x.Id).ToList();  
            clientCbo.DataSource = client.OrderBy(x => x.Id).ToList(); 
            clientCbo.DisplayMember = "FirstName";
            clientCbo.ValueMember = "Id";

         
            var books = BookServices.ListBook();
            books.Add(new DAL.Model.Book()
            {
                Id = 0,
                Name = "Select a book"
            });
            bookCbo.DataSource = books.OrderBy(x => x.Id).ToList();
            bookCbo.DisplayMember = "Name";
            bookCbo.ValueMember = "Id";

            memeberTxt.Text = "1";
            memeberLbl.Text = "Standard";
        }

        private void clientCbo_Format(object sender, ListControlConvertEventArgs e)
        {
            string lastName = ((DAL.Model.Client)e.ListItem).LastName;
            string firstName = ((DAL.Model.Client)e.ListItem).FirstName;
            e.Value = lastName + " " + firstName;
        }

        private void clientCbo_SelectedIndexChanged(object sender, EventArgs e)
        {
                int selectValue;               

                if (int.TryParse(clientCbo.SelectedValue.ToString(), out selectValue))
                {
                  if (selectValue >= 1)
                  {
                    clientIdTxt.Text = clientCbo.SelectedValue.ToString();
                    fullNameTxt.Text = clientCbo.Text;
                  }
                }
        }

        private void bookCbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectValue;

            if (int.TryParse(bookCbo.SelectedValue.ToString(), out selectValue))
            {
                if (selectValue >= 1)
                {                    
                    DAL.Model.Book b = BookServices.GetBookById(selectValue);
                    books.Add(b);
                    itemDgv.Rows.Add(b.Id.ToString(), b.Name, b.Price.ToString());
                    double price = Convert.ToDouble(totalTxt.Text);
                    totalTxt.Text = (price + b.Price).ToString();
                }
            }
        }

        private void itemDgv_Click(object sender, EventArgs e)
        {

        }

        private void buyBtn_Click(object sender, EventArgs e)
        {
            int memberCategoryId;
            double price;
            if (int.TryParse(memeberTxt.Text, out memberCategoryId))
            {
                double.TryParse(totalTxt.Text, out price);
                _factory.GetAccountMemeber(memberCategoryId).MembershipDiscout(price);
            }
            
            
        }
    }
}
