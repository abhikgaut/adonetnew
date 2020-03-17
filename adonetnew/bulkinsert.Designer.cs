namespace adonetnew
{
    partial class bulkinsert
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.discount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.orderId = new System.Windows.Forms.TextBox();
            this.orderDisc = new System.Windows.Forms.TextBox();
            this.orderDesc = new System.Windows.Forms.TextBox();
            this.custId = new System.Windows.Forms.ComboBox();
            this.salesId = new System.Windows.Forms.ComboBox();
            this.orderDate = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.productId = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.productDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "order id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "date";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // discount
            // 
            this.discount.AutoSize = true;
            this.discount.Location = new System.Drawing.Point(432, 7);
            this.discount.Name = "discount";
            this.discount.Size = new System.Drawing.Size(47, 13);
            this.discount.TabIndex = 3;
            this.discount.Text = "discount";
            this.discount.Click += new System.EventHandler(this.discount_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(432, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "customer id";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(432, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "salesman id";
            // 
            // orderId
            // 
            this.orderId.Enabled = false;
            this.orderId.Location = new System.Drawing.Point(124, 7);
            this.orderId.Name = "orderId";
            this.orderId.Size = new System.Drawing.Size(100, 20);
            this.orderId.TabIndex = 6;
            // 
            // orderDisc
            // 
            this.orderDisc.Location = new System.Drawing.Point(533, 7);
            this.orderDisc.Name = "orderDisc";
            this.orderDisc.Size = new System.Drawing.Size(100, 20);
            this.orderDisc.TabIndex = 9;
            // 
            // orderDesc
            // 
            this.orderDesc.Location = new System.Drawing.Point(124, 49);
            this.orderDesc.Name = "orderDesc";
            this.orderDesc.Size = new System.Drawing.Size(100, 20);
            this.orderDesc.TabIndex = 10;
            // 
            // custId
            // 
            this.custId.FormattingEnabled = true;
            this.custId.Location = new System.Drawing.Point(533, 48);
            this.custId.Name = "custId";
            this.custId.Size = new System.Drawing.Size(121, 21);
            this.custId.TabIndex = 11;
            // 
            // salesId
            // 
            this.salesId.FormattingEnabled = true;
            this.salesId.Location = new System.Drawing.Point(533, 94);
            this.salesId.Name = "salesId";
            this.salesId.Size = new System.Drawing.Size(121, 21);
            this.salesId.TabIndex = 12;
            // 
            // orderDate
            // 
            this.orderDate.Location = new System.Drawing.Point(124, 91);
            this.orderDate.Name = "orderDate";
            this.orderDate.Size = new System.Drawing.Size(200, 20);
            this.orderDate.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productId,
            this.productDesc,
            this.qty,
            this.unitPrice,
            this.totalCost});
            this.dataGridView1.Location = new System.Drawing.Point(113, 159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(541, 268);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowLeave);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // productId
            // 
            this.productId.HeaderText = "product ID";
            this.productId.Name = "productId";
            this.productId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.productId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // productDesc
            // 
            this.productDesc.HeaderText = "description";
            this.productDesc.Name = "productDesc";
            // 
            // qty
            // 
            this.qty.HeaderText = "quantity";
            this.qty.Name = "qty";
            // 
            // unitPrice
            // 
            this.unitPrice.HeaderText = "unit price";
            this.unitPrice.Name = "unitPrice";
            // 
            // totalCost
            // 
            this.totalCost.HeaderText = "total cost";
            this.totalCost.Name = "totalCost";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(353, 463);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.orderDate);
            this.panel1.Controls.Add(this.salesId);
            this.panel1.Controls.Add(this.custId);
            this.panel1.Controls.Add(this.orderDesc);
            this.panel1.Controls.Add(this.orderDisc);
            this.panel1.Controls.Add(this.orderId);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.discount);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(118, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(731, 505);
            this.panel1.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(471, 548);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "add bill";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bulkinsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 602);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Name = "bulkinsert";
            this.Text = "bulkinsert";
            this.Load += new System.EventHandler(this.bulkinsert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label discount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox orderId;
        private System.Windows.Forms.TextBox orderDisc;
        private System.Windows.Forms.TextBox orderDesc;
        private System.Windows.Forms.ComboBox custId;
        private System.Windows.Forms.ComboBox salesId;
        private System.Windows.Forms.DateTimePicker orderDate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewComboBoxColumn productId;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCost;
    }
}