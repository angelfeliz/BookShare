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
        private ListBook _listBook;
        public EditBook(DAL.Model.Book book, Form parent)
        {
            InitializeComponent();
            _listBook = parent as ListBook;     
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

            try
            {
                Services.BookServices.UpdateBook(book);
                _listBook.BookListDgv.DataSource = Services.BookServices.ListBook();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
