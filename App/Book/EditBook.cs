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
    public partial class EditBook : Form
    {
        public EditBook(int Id)
        {
            InitializeComponent();
            DAL.Model.Book book = Services.BookServices.GetBookById(Id);
            idTxt.Text = book.Id.ToString();
            nameTxt.Text = book.Name;
            descriptionTxt.Text = book.Description;
            priceTxt.Text = book.Price.ToString();            
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            DAL.Model.Book book = new DAL.Model.Book();
            book.Id = int.Parse(idTxt.Text);
            book.Name = nameTxt.Text;
            book.Description = descriptionTxt.Text;
            book.Price = double.Parse(priceTxt.Text);

            Services.BookServices.UpdateBook(book);
        }
    }
}
