namespace App.Book
{
    partial class SearchBook
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
            this.label1 = new System.Windows.Forms.Label();
            this.bookNameTxt = new System.Windows.Forms.TextBox();
            this.booksDgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.booksDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book name";
            // 
            // bookNameTxt
            // 
            this.bookNameTxt.Location = new System.Drawing.Point(8, 37);
            this.bookNameTxt.Name = "bookNameTxt";
            this.bookNameTxt.Size = new System.Drawing.Size(376, 20);
            this.bookNameTxt.TabIndex = 1;
            this.bookNameTxt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.bookNameTxt_KeyUp);
            // 
            // booksDgv
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Aqua;
            this.booksDgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.booksDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.booksDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksDgv.Location = new System.Drawing.Point(8, 81);
            this.booksDgv.Name = "booksDgv";
            this.booksDgv.Size = new System.Drawing.Size(714, 167);
            this.booksDgv.TabIndex = 2;
            this.booksDgv.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.booksDgv_CellMouseDoubleClick);
            // 
            // SearchBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 256);
            this.Controls.Add(this.booksDgv);
            this.Controls.Add(this.bookNameTxt);
            this.Controls.Add(this.label1);
            this.Name = "SearchBook";
            this.Text = "SearchBook";
            this.Load += new System.EventHandler(this.SearchBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booksDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bookNameTxt;
        private System.Windows.Forms.DataGridView booksDgv;
    }
}