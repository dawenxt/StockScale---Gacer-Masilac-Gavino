namespace StockScale___Gacer__Masilac__Gavino
{
    partial class OrderHistoryForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.resDate = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.resPayment = new System.Windows.Forms.Label();
            this.resTotal = new System.Windows.Forms.Label();
            this.resProduct = new System.Windows.Forms.Label();
            this.resQuan = new System.Windows.Forms.Label();
            this.resStudent = new System.Windows.Forms.Label();
            this.resId = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.resOrder = new System.Windows.Forms.Label();
            this.designPanel = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.btnViewProduct = new System.Windows.Forms.Button();
            this.lowerPanel1 = new System.Windows.Forms.Panel();
            this.panelStockEdit = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
            this.designPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.lowerPanel1.SuspendLayout();
            this.panelStockEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgView
            // 
            this.dgView.AllowUserToAddRows = false;
            this.dgView.AllowUserToDeleteRows = false;
            this.dgView.AllowUserToOrderColumns = true;
            this.dgView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lexend SemiBold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgView.Location = new System.Drawing.Point(43, 85);
            this.dgView.Name = "dgView";
            this.dgView.ReadOnly = true;
            this.dgView.Size = new System.Drawing.Size(1455, 512);
            this.dgView.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "orderNumber";
            this.Column2.HeaderText = "Order Number";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "studentNumber";
            this.Column3.HeaderText = "Student Number";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "productId";
            this.Column4.HeaderText = "Product ID";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "quantity";
            this.Column5.HeaderText = "Quantity";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "totalCost";
            this.Column6.HeaderText = "Cost";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "paymentMethod";
            this.Column7.HeaderText = "Payment Method";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "orderDate";
            this.Column8.HeaderText = "Date";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Lexend SemiBold", 13F, System.Drawing.FontStyle.Bold);
            this.txtSearch.Location = new System.Drawing.Point(145, 11);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(1053, 36);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(75, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(75, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Student Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(75, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Number of Orders";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(75, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Product Number/s";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(75, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Cost";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(75, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Payment Method";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(75, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Processed by: Admin";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(75, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Date";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(133)))), ((int)(((byte)(0)))));
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Font = new System.Drawing.Font("Arial Black", 11.75F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(13, 10);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(197, 46);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // resDate
            // 
            this.resDate.AutoSize = true;
            this.resDate.Font = new System.Drawing.Font("Verdana", 10F);
            this.resDate.Location = new System.Drawing.Point(287, 233);
            this.resDate.Name = "resDate";
            this.resDate.Size = new System.Drawing.Size(41, 17);
            this.resDate.TabIndex = 18;
            this.resDate.Text = "Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 10F);
            this.label10.Location = new System.Drawing.Point(287, 261);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(156, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "Processed by: Admin";
            // 
            // resPayment
            // 
            this.resPayment.AutoSize = true;
            this.resPayment.Font = new System.Drawing.Font("Verdana", 10F);
            this.resPayment.Location = new System.Drawing.Point(287, 206);
            this.resPayment.Name = "resPayment";
            this.resPayment.Size = new System.Drawing.Size(125, 17);
            this.resPayment.TabIndex = 16;
            this.resPayment.Text = "Payment Method";
            // 
            // resTotal
            // 
            this.resTotal.AutoSize = true;
            this.resTotal.Font = new System.Drawing.Font("Verdana", 10F);
            this.resTotal.Location = new System.Drawing.Point(287, 174);
            this.resTotal.Name = "resTotal";
            this.resTotal.Size = new System.Drawing.Size(79, 17);
            this.resTotal.TabIndex = 15;
            this.resTotal.Text = "Total Cost";
            // 
            // resProduct
            // 
            this.resProduct.AutoSize = true;
            this.resProduct.Font = new System.Drawing.Font("Verdana", 10F);
            this.resProduct.Location = new System.Drawing.Point(287, 144);
            this.resProduct.Name = "resProduct";
            this.resProduct.Size = new System.Drawing.Size(136, 17);
            this.resProduct.TabIndex = 14;
            this.resProduct.Text = "Product Number/s";
            // 
            // resQuan
            // 
            this.resQuan.AutoSize = true;
            this.resQuan.Font = new System.Drawing.Font("Verdana", 10F);
            this.resQuan.Location = new System.Drawing.Point(287, 116);
            this.resQuan.Name = "resQuan";
            this.resQuan.Size = new System.Drawing.Size(135, 17);
            this.resQuan.TabIndex = 13;
            this.resQuan.Text = "Number of Orders";
            // 
            // resStudent
            // 
            this.resStudent.AutoSize = true;
            this.resStudent.Font = new System.Drawing.Font("Verdana", 10F);
            this.resStudent.Location = new System.Drawing.Point(287, 87);
            this.resStudent.Name = "resStudent";
            this.resStudent.Size = new System.Drawing.Size(125, 17);
            this.resStudent.TabIndex = 12;
            this.resStudent.Text = "Student Number";
            // 
            // resId
            // 
            this.resId.AutoSize = true;
            this.resId.Font = new System.Drawing.Font("Verdana", 10F);
            this.resId.Location = new System.Drawing.Point(287, 59);
            this.resId.Name = "resId";
            this.resId.Size = new System.Drawing.Size(24, 17);
            this.resId.TabIndex = 11;
            this.resId.Text = "ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(75, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Order #";
            // 
            // resOrder
            // 
            this.resOrder.AutoSize = true;
            this.resOrder.Font = new System.Drawing.Font("Verdana", 10F);
            this.resOrder.Location = new System.Drawing.Point(287, 27);
            this.resOrder.Name = "resOrder";
            this.resOrder.Size = new System.Drawing.Size(64, 17);
            this.resOrder.TabIndex = 20;
            this.resOrder.Text = "Order #";
            // 
            // designPanel
            // 
            this.designPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.designPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.designPanel.Controls.Add(this.label11);
            this.designPanel.Location = new System.Drawing.Point(43, 17);
            this.designPanel.Name = "designPanel";
            this.designPanel.Size = new System.Drawing.Size(1455, 54);
            this.designPanel.TabIndex = 21;
            this.designPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.designPanel_Paint);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Lexend", 16F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(26, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(169, 35);
            this.label11.TabIndex = 33;
            this.label11.Text = "Order History";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.btnViewProduct);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Location = new System.Drawing.Point(43, 618);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1455, 55);
            this.panel2.TabIndex = 29;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Lexend", 16F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(26, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 35);
            this.label13.TabIndex = 32;
            this.label13.Text = "Search:";
            // 
            // btnViewProduct
            // 
            this.btnViewProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(158)))), ((int)(((byte)(188)))));
            this.btnViewProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnViewProduct.Font = new System.Drawing.Font("Lexend", 9F);
            this.btnViewProduct.ForeColor = System.Drawing.Color.White;
            this.btnViewProduct.Location = new System.Drawing.Point(1215, 10);
            this.btnViewProduct.Name = "btnViewProduct";
            this.btnViewProduct.Size = new System.Drawing.Size(223, 35);
            this.btnViewProduct.TabIndex = 32;
            this.btnViewProduct.Text = "View Product List";
            this.btnViewProduct.UseVisualStyleBackColor = false;
            this.btnViewProduct.Click += new System.EventHandler(this.btnViewProduct_Click);
            // 
            // lowerPanel1
            // 
            this.lowerPanel1.BackColor = System.Drawing.Color.White;
            this.lowerPanel1.Controls.Add(this.panelStockEdit);
            this.lowerPanel1.Controls.Add(this.resOrder);
            this.lowerPanel1.Controls.Add(this.label9);
            this.lowerPanel1.Controls.Add(this.resDate);
            this.lowerPanel1.Controls.Add(this.label10);
            this.lowerPanel1.Controls.Add(this.resPayment);
            this.lowerPanel1.Controls.Add(this.resTotal);
            this.lowerPanel1.Controls.Add(this.resProduct);
            this.lowerPanel1.Controls.Add(this.resQuan);
            this.lowerPanel1.Controls.Add(this.resStudent);
            this.lowerPanel1.Controls.Add(this.resId);
            this.lowerPanel1.Controls.Add(this.label8);
            this.lowerPanel1.Controls.Add(this.label7);
            this.lowerPanel1.Controls.Add(this.label6);
            this.lowerPanel1.Controls.Add(this.label5);
            this.lowerPanel1.Controls.Add(this.label4);
            this.lowerPanel1.Controls.Add(this.label3);
            this.lowerPanel1.Controls.Add(this.label2);
            this.lowerPanel1.Controls.Add(this.label1);
            this.lowerPanel1.Location = new System.Drawing.Point(43, 689);
            this.lowerPanel1.Name = "lowerPanel1";
            this.lowerPanel1.Size = new System.Drawing.Size(1455, 306);
            this.lowerPanel1.TabIndex = 30;
            this.lowerPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.lowerPanel1_Paint);
            // 
            // panelStockEdit
            // 
            this.panelStockEdit.Controls.Add(this.btnEdit);
            this.panelStockEdit.Location = new System.Drawing.Point(1220, 226);
            this.panelStockEdit.Name = "panelStockEdit";
            this.panelStockEdit.Size = new System.Drawing.Size(222, 65);
            this.panelStockEdit.TabIndex = 21;
            this.panelStockEdit.Paint += new System.Windows.Forms.PaintEventHandler(this.panelStockEdit_Paint);
            // 
            // OrderHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1546, 1023);
            this.Controls.Add(this.lowerPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.designPanel);
            this.Controls.Add(this.dgView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderHistoryForm";
            this.Text = "OrderHistoryForm";
            this.Load += new System.EventHandler(this.OrderHistoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
            this.designPanel.ResumeLayout(false);
            this.designPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.lowerPanel1.ResumeLayout(false);
            this.lowerPanel1.PerformLayout();
            this.panelStockEdit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgView;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label resDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label resPayment;
        private System.Windows.Forms.Label resTotal;
        private System.Windows.Forms.Label resProduct;
        private System.Windows.Forms.Label resQuan;
        private System.Windows.Forms.Label resStudent;
        private System.Windows.Forms.Label resId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label resOrder;
        private System.Windows.Forms.Panel designPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnViewProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Panel lowerPanel1;
        private System.Windows.Forms.Panel panelStockEdit;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
    }
}