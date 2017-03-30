namespace App
{
    partial class ShopForm
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
            this.clientIdTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fullNameTxt = new System.Windows.Forms.TextBox();
            this.clientCbo = new System.Windows.Forms.ComboBox();
            this.itemDgv = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bookCbo = new System.Windows.Forms.ComboBox();
            this.findClientBtn = new System.Windows.Forms.Button();
            this.buyBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.subTotalTxt = new System.Windows.Forms.TextBox();
            this.memeberLbl = new System.Windows.Forms.Label();
            this.searchBookBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.discountTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.totalTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.itemDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Client No";
            // 
            // clientIdTxt
            // 
            this.clientIdTxt.Location = new System.Drawing.Point(12, 53);
            this.clientIdTxt.Name = "clientIdTxt";
            this.clientIdTxt.ReadOnly = true;
            this.clientIdTxt.Size = new System.Drawing.Size(100, 20);
            this.clientIdTxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Full Name";
            // 
            // fullNameTxt
            // 
            this.fullNameTxt.Location = new System.Drawing.Point(12, 110);
            this.fullNameTxt.Name = "fullNameTxt";
            this.fullNameTxt.ReadOnly = true;
            this.fullNameTxt.Size = new System.Drawing.Size(420, 20);
            this.fullNameTxt.TabIndex = 3;
            // 
            // clientCbo
            // 
            this.clientCbo.FormattingEnabled = true;
            this.clientCbo.Location = new System.Drawing.Point(213, 12);
            this.clientCbo.Name = "clientCbo";
            this.clientCbo.Size = new System.Drawing.Size(302, 21);
            this.clientCbo.TabIndex = 4;
            this.clientCbo.Visible = false;
            this.clientCbo.SelectedIndexChanged += new System.EventHandler(this.clientCbo_SelectedIndexChanged);
            // 
            // itemDgv
            // 
            this.itemDgv.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Aqua;
            this.itemDgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.itemDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.itemDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.NameItem,
            this.Price,
            this.Delete});
            this.itemDgv.Location = new System.Drawing.Point(12, 146);
            this.itemDgv.Name = "itemDgv";
            this.itemDgv.Size = new System.Drawing.Size(843, 158);
            this.itemDgv.TabIndex = 5;
            this.itemDgv.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.itemDgv_RowsAdded);
            this.itemDgv.Click += new System.EventHandler(this.itemDgv_Click);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // NameItem
            // 
            this.NameItem.HeaderText = "Name";
            this.NameItem.Name = "NameItem";
            this.NameItem.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // bookCbo
            // 
            this.bookCbo.FormattingEnabled = true;
            this.bookCbo.Location = new System.Drawing.Point(213, 35);
            this.bookCbo.Name = "bookCbo";
            this.bookCbo.Size = new System.Drawing.Size(356, 21);
            this.bookCbo.TabIndex = 6;
            this.bookCbo.Visible = false;
            this.bookCbo.SelectedIndexChanged += new System.EventHandler(this.bookCbo_SelectedIndexChanged);
            // 
            // findClientBtn
            // 
            this.findClientBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.findClientBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.findClientBtn.Location = new System.Drawing.Point(118, 52);
            this.findClientBtn.Name = "findClientBtn";
            this.findClientBtn.Size = new System.Drawing.Size(75, 23);
            this.findClientBtn.TabIndex = 7;
            this.findClientBtn.Text = "Find client";
            this.findClientBtn.UseVisualStyleBackColor = false;
            this.findClientBtn.Click += new System.EventHandler(this.findClientBtn_Click);
            // 
            // buyBtn
            // 
            this.buyBtn.Location = new System.Drawing.Point(679, 453);
            this.buyBtn.Name = "buyBtn";
            this.buyBtn.Size = new System.Drawing.Size(176, 23);
            this.buyBtn.TabIndex = 8;
            this.buyBtn.Text = "Buy";
            this.buyBtn.UseVisualStyleBackColor = true;
            this.buyBtn.Click += new System.EventHandler(this.buyBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(616, 401);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Total";
            // 
            // subTotalTxt
            // 
            this.subTotalTxt.Location = new System.Drawing.Point(679, 319);
            this.subTotalTxt.Name = "subTotalTxt";
            this.subTotalTxt.ReadOnly = true;
            this.subTotalTxt.Size = new System.Drawing.Size(176, 20);
            this.subTotalTxt.TabIndex = 10;
            this.subTotalTxt.TextChanged += new System.EventHandler(this.subTotalTxt_TextChanged);
            // 
            // memeberLbl
            // 
            this.memeberLbl.AutoSize = true;
            this.memeberLbl.Location = new System.Drawing.Point(633, 52);
            this.memeberLbl.Name = "memeberLbl";
            this.memeberLbl.Size = new System.Drawing.Size(0, 13);
            this.memeberLbl.TabIndex = 11;
            // 
            // searchBookBtn
            // 
            this.searchBookBtn.Location = new System.Drawing.Point(653, 117);
            this.searchBookBtn.Name = "searchBookBtn";
            this.searchBookBtn.Size = new System.Drawing.Size(202, 23);
            this.searchBookBtn.TabIndex = 13;
            this.searchBookBtn.Text = "Search book";
            this.searchBookBtn.UseVisualStyleBackColor = true;
            this.searchBookBtn.Click += new System.EventHandler(this.searchBookBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(616, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Discount";
            // 
            // discountTxt
            // 
            this.discountTxt.Location = new System.Drawing.Point(679, 358);
            this.discountTxt.Name = "discountTxt";
            this.discountTxt.ReadOnly = true;
            this.discountTxt.Size = new System.Drawing.Size(176, 20);
            this.discountTxt.TabIndex = 15;
            this.discountTxt.TextChanged += new System.EventHandler(this.discountTxt_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(612, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Sub-total";
            // 
            // totalTxt
            // 
            this.totalTxt.Location = new System.Drawing.Point(679, 394);
            this.totalTxt.Name = "totalTxt";
            this.totalTxt.ReadOnly = true;
            this.totalTxt.Size = new System.Drawing.Size(176, 20);
            this.totalTxt.TabIndex = 17;
            // 
            // ShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 488);
            this.Controls.Add(this.totalTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.discountTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.searchBookBtn);
            this.Controls.Add(this.memeberLbl);
            this.Controls.Add(this.subTotalTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buyBtn);
            this.Controls.Add(this.findClientBtn);
            this.Controls.Add(this.bookCbo);
            this.Controls.Add(this.itemDgv);
            this.Controls.Add(this.clientCbo);
            this.Controls.Add(this.fullNameTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clientIdTxt);
            this.Controls.Add(this.label1);
            this.Name = "ShopForm";
            this.Text = "ShopForm_";
            this.Load += new System.EventHandler(this.ShopForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox clientCbo;
        private System.Windows.Forms.ComboBox bookCbo;
        private System.Windows.Forms.Button findClientBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Button buyBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox subTotalTxt;
        public System.Windows.Forms.TextBox clientIdTxt;
        public System.Windows.Forms.TextBox fullNameTxt;
        public System.Windows.Forms.Label memeberLbl;
        private System.Windows.Forms.Button searchBookBtn;
        public System.Windows.Forms.DataGridView itemDgv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox discountTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox totalTxt;
    }
}