using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DAL.Model;
using DAL.Repository;

namespace App
{
    public partial class BookForm : Form
    {
        public BookForm()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            BookShopContext _context = new BookShopContext();
            BaseRepository<Book> _db = new BaseRepository<Book>(_context);

            Book _book = new Book();
            _book.Name = nameTxt.Text;
            _book.Description = descriptionTxt.Text;
            _book.Price = double.Parse(priceTxt.Text);

            _db.Add(_book);
        }
    }
}
