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
        #region Client forms instance
        NewClient newClient = new NewClient();
        ListClient listClient = new ListClient();
        #endregion
        #region Book forms instance
        NewBook newBook = new NewBook();
        ListBook listBook = new ListBook();
        #endregion

        private void MainForm_Load(object sender, EventArgs e)
        {
            newClient.MdiParent = this;
            listClient.MdiParent = this;
            newBook.MdiParent = this;
            listBook.MdiParent = this;
        }
        public MainForm()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newClient.Show();
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listClient.Show();
        }

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            newBook.Show();
        }

        private void listToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            listBook.Show();
        }
    }
}
