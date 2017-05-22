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
using App.Book;
using Services;
using BusinessLayer;


namespace App
{
    public partial class ShopForm : Form
    {        
        private MembershipFactory _factory = new MembershipFactory();

        IList<DAL.Model.Book> books = new List<DAL.Model.Book>();
        public int memberShipTypeId = 0;

        public ShopForm()
        {
            InitializeComponent();
        }

        private void findClientBtn_Click(object sender, EventArgs e)
        {
            SearchClient searchClient = new SearchClient(this);
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

           
           // memeberLbl.Text = "Standard";
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
                }
            }
        }

        private void itemDgv_Click(object sender, EventArgs e)
        {

        }

        private void buyBtn_Click(object sender, EventArgs e)
        {
            buyBtn.Enabled = false;
            try
            {
                DAL.Model.Purchase purchase = new DAL.Model.Purchase();                
                var b = purchase.books;
                for (int x = 0; x < itemDgv.Rows.Count; x++)
                {
                    purchase.books.Add(new DAL.Model.Book()
                    {
                        Id = int.Parse(itemDgv.Rows[x].Cells[0].Value.ToString()),
                    });
                }
                purchase.ClientId = int.Parse(clientIdTxt.Text);
                purchase.Total = double.Parse(totalTxt.Text);

                Services.PurchaseServices.AddPurchase(purchase);
                clientIdTxt.Text = string.Empty;
                fullNameTxt.Text = string.Empty;
                subTotalTxt.Text = "0";
                discountTxt.Text = "0";
                totalTxt.Text = "0";
                itemDgv.Rows.Clear();
                itemDgv.Refresh();
                buyBtn.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on purchase", MessageBoxButtons.OK);
                buyBtn.Enabled = true;
            }
        }
             

        private void searchBookBtn_Click(object sender, EventArgs e)
        {
            SearchBook searchBookForm = new SearchBook(this);
            searchBookForm.Show();
        }

        private void itemDgv_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            double total = 0;
            double price;
            for (int x = 0; x < itemDgv.Rows.Count; x++)
            {
                double.TryParse(itemDgv.Rows[x].Cells[2].Value.ToString(), out price);
                total = total + price;
            }
            subTotalTxt.Text = Math.Round(total, 2).ToString();
        }

        private void subTotalTxt_TextChanged(object sender, EventArgs e)
        {
            
          double subTotalPrice;            
          double.TryParse(subTotalTxt.Text, out subTotalPrice);

          double discount = _factory.GetAccountMemeber(memberShipTypeId).MembershipDiscout(subTotalPrice);            
          discountTxt.Text = Math.Round(discount,2).ToString();
            
        }

        private void discountTxt_TextChanged(object sender, EventArgs e)
        {
            totalTxt.Text = Math.Round((double.Parse(subTotalTxt.Text) - double.Parse(discountTxt.Text))).ToString();
        }
    }
}
