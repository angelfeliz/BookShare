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


namespace App.Book
{
    public partial class NewBook : Form
    {
        public NewBook()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            DAL.Model.Book book = new DAL.Model.Book();
            book.Name = nameTxt.Text;
            book.Description = descriptionTxt.Text;
            book.Price = double.Parse(priceTxt.Text);

            Services.BookServices.AddBook(book);
        }
    }
}
