namespace App.Client
{
    partial class SearchClient
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.clientDgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.clientDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lastname";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(11, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(425, 20);
            this.textBox1.TabIndex = 2;
            // 
            // clientDgv
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Aqua;
            this.clientDgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.clientDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.clientDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientDgv.Location = new System.Drawing.Point(11, 66);
            this.clientDgv.Name = "clientDgv";
            this.clientDgv.Size = new System.Drawing.Size(631, 164);
            this.clientDgv.TabIndex = 3;
            // 
            // SearchClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 239);
            this.Controls.Add(this.clientDgv);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "SearchClient";
            this.Text = "SearchClient";
            this.Load += new System.EventHandler(this.SearchClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView clientDgv;
    }
}