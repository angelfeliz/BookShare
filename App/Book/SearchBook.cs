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
    public partial class SearchBook : Form
    {
        private ShopForm _shopForm;
        public SearchBook()
        {
            InitializeComponent();
        }

        public SearchBook(Form parent)
        {
            InitializeComponent();
            _shopForm = parent as ShopForm;
        }

        private void bookNameTxt_KeyUp(object sender, KeyEventArgs e)
        {
            string name = bookNameTxt.Text;
            booksDgv.DataSource = BookServices.ListBook().Where(x => x.Name.Contains(name)).ToList();
        }

        private void SearchBook_Load(object sender, EventArgs e)
        {            
            booksDgv.DataSource = BookServices.ListBook();
        }

        private void booksDgv_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string id = booksDgv.Rows[e.RowIndex].Cells[0].Value.ToString();
            string name = booksDgv.Rows[e.RowIndex].Cells[1].Value.ToString();
            string price = booksDgv.Rows[e.RowIndex].Cells[2].Value.ToString();

            _shopForm.itemDgv.Rows.Add(id, name, price);

            this.Close();
        }
    }
}
