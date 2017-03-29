namespace App.Book
{
    partial class ListBook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BookListDgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.BookListDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // BookListDgv
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Aqua;
            this.BookListDgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.BookListDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BookListDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookListDgv.Location = new System.Drawing.Point(2, 35);
            this.BookListDgv.Name = "BookListDgv";
            this.BookListDgv.Size = new System.Drawing.Size(647, 226);
            this.BookListDgv.TabIndex = 0;
            this.BookListDgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BookListDgv_CellClick);
            // 
            // ListBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 284);
            this.Controls.Add(this.BookListDgv);
            this.Name = "ListBook";
            this.Text = "ListBook";
            this.Load += new System.EventHandler(this.ListBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BookListDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView BookListDgv;
    }
}