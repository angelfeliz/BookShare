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

namespace App
{
    public partial class MainForm : Form
    {
        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }
        public MainForm()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewClient newClient = new NewClient();
            newClient.MdiParent = this;
            newClient.Show();
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListClient listClient = new ListClient();
            listClient.MdiParent = this;
            listClient.Show();
        }

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NewBook newBook = new NewBook();
            newBook.MdiParent = this;
            newBook.Show();
        }

        private void listToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ListBook listBook = new ListBook();
            listBook.MdiParent = this;
            listBook.Show();
        }

        private void shopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShopForm shopForm = new ShopForm();
            shopForm.MdiParent = this;
            shopForm.Show();            
        }
    }
}
