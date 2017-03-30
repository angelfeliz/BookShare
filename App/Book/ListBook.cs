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
    public partial class ListBook : Form
    {
        public ListBook()
        {
            InitializeComponent();

        }

        private void ListBook_Load(object sender, EventArgs e)
        {

            BookListDgv.DataSource = Services.BookServices.ListBook();
            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
            btnColumn.HeaderText = "#";
            btnColumn.Text = "Edit";
            btnColumn.UseColumnTextForButtonValue = true;
            BookListDgv.Columns.Add(btnColumn);
        }

        private void BookListDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                string IdStr = BookListDgv.Rows[e.RowIndex].Cells[1].Value.ToString();
                int Id = int.Parse(IdStr);
                EditBook editForm = new EditBook(Services.BookServices.GetBookById(Id), this);
                editForm.Show();
            }
        }
    }
}
