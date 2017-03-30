namespace App.Client
{
    partial class ListClient
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
            this.clientListDgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.clientListDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // clientListDgv
            // 
            this.clientListDgv.AllowUserToAddRows = false;
            this.clientListDgv.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Aqua;
            this.clientListDgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.clientListDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.clientListDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientListDgv.Location = new System.Drawing.Point(12, 12);
            this.clientListDgv.Name = "clientListDgv";
            this.clientListDgv.ReadOnly = true;
            this.clientListDgv.Size = new System.Drawing.Size(957, 290);
            this.clientListDgv.TabIndex = 0;
            this.clientListDgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clientListDgv_CellClick);
            // 
            // ListClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 321);
            this.Controls.Add(this.clientListDgv);
            this.Name = "ListClient";
            this.Text = "ListClient";
            this.Load += new System.EventHandler(this.ListClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientListDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView clientListDgv;
    }
}