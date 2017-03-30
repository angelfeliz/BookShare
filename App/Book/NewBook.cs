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
            saveBtn.Enabled = false;
            DAL.Model.Book book = new DAL.Model.Book();
            book.Name = nameTxt.Text;
            book.Description = descriptionTxt.Text;
            book.Price = double.Parse(priceTxt.Text);

            try
            {
                Services.BookServices.AddBook(book);
                nameTxt.Text = string.Empty;
                descriptionTxt.Text = string.Empty;
                priceTxt.Text = string.Empty;
                saveBtn.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                saveBtn.Enabled = true;
            }
            
        }
    }
}
