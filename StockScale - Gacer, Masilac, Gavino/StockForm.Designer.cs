namespace StockScale___Gacer__Masilac__Gavino
{
    partial class StockForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblOn = new System.Windows.Forms.Label();
            this.lblSales = new System.Windows.Forms.Label();
            this.lblOut = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblDes = new System.Windows.Forms.Label();
            this.lblproduct = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.lblNext = new System.Windows.Forms.Label();
            this.lblReorder = new System.Windows.Forms.Label();
            this.lblLast = new System.Windows.Forms.Label();
            this.lblStorage = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.designPanel = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.panelSearchStock = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.btnViewProduct = new System.Windows.Forms.Button();
            this.panelStock = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.designPanel.SuspendLayout();
            this.panelSearchStock.SuspendLayout();
            this.panelStock.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Lexend SemiBold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column12,
            this.Column11,
            this.Column13});
            this.dataGridView1.Location = new System.Drawing.Point(45, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1455, 512);
            this.dataGridView1.TabIndex = 0;
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
            this.Column2.DataPropertyName = "ProductNum";
            this.Column2.HeaderText = "Product Number";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "description";
            this.Column3.HeaderText = "Description";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "openingStock";
            this.Column4.HeaderText = "Opening Stock";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "stockValue";
            this.Column5.HeaderText = "Stock Value";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "out";
            this.Column6.HeaderText = "Out";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "costItem";
            this.Column7.HeaderText = "Cost Per Item";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "sales";
            this.Column8.HeaderText = "Sales";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "status";
            this.Column9.HeaderText = "Status";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "storageNumber";
            this.Column10.HeaderText = "Storage No.";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "lastUpdate";
            this.Column12.HeaderText = "Last Update";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "reorder";
            this.Column11.HeaderText = "Reorder";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "nextStock";
            this.Column13.HeaderText = "Next Stock";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Lexend SemiBold", 13F, System.Drawing.FontStyle.Bold);
            this.tbSearch.Location = new System.Drawing.Point(152, 10);
            this.tbSearch.Multiline = true;
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(1050, 36);
            this.tbSearch.TabIndex = 1;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(91, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(91, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Product Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(91, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(91, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Opening Stock";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(91, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Stock Value";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(91, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Out";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(91, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Sales";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(91, 242);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Status";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(567, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "Next Stock";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(567, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 17);
            this.label10.TabIndex = 12;
            this.label10.Text = "Reorder";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(567, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 17);
            this.label11.TabIndex = 11;
            this.label11.Text = "Last Update";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(567, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(135, 17);
            this.label12.TabIndex = 10;
            this.label12.Text = "Storage Number";
            // 
            // lblOn
            // 
            this.lblOn.AutoSize = true;
            this.lblOn.Font = new System.Drawing.Font("Verdana", 10F);
            this.lblOn.Location = new System.Drawing.Point(273, 243);
            this.lblOn.Name = "lblOn";
            this.lblOn.Size = new System.Drawing.Size(55, 17);
            this.lblOn.TabIndex = 21;
            this.lblOn.Text = "Status";
            // 
            // lblSales
            // 
            this.lblSales.AutoSize = true;
            this.lblSales.Font = new System.Drawing.Font("Verdana", 10F);
            this.lblSales.Location = new System.Drawing.Point(273, 215);
            this.lblSales.Name = "lblSales";
            this.lblSales.Size = new System.Drawing.Size(45, 17);
            this.lblSales.TabIndex = 20;
            this.lblSales.Text = "Sales";
            // 
            // lblOut
            // 
            this.lblOut.AutoSize = true;
            this.lblOut.Font = new System.Drawing.Font("Verdana", 10F);
            this.lblOut.Location = new System.Drawing.Point(273, 183);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(34, 17);
            this.lblOut.TabIndex = 19;
            this.lblOut.Text = "Out";
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Font = new System.Drawing.Font("Verdana", 10F);
            this.lblValue.Location = new System.Drawing.Point(273, 154);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(90, 17);
            this.lblValue.TabIndex = 18;
            this.lblValue.Text = "Stock Value";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Verdana", 10F);
            this.lblStock.Location = new System.Drawing.Point(273, 121);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(111, 17);
            this.lblStock.TabIndex = 17;
            this.lblStock.Text = "Opening Stock";
            // 
            // lblDes
            // 
            this.lblDes.AutoSize = true;
            this.lblDes.Font = new System.Drawing.Font("Verdana", 10F);
            this.lblDes.Location = new System.Drawing.Point(273, 88);
            this.lblDes.Name = "lblDes";
            this.lblDes.Size = new System.Drawing.Size(87, 17);
            this.lblDes.TabIndex = 16;
            this.lblDes.Text = "Description";
            // 
            // lblproduct
            // 
            this.lblproduct.AutoSize = true;
            this.lblproduct.Font = new System.Drawing.Font("Verdana", 10F);
            this.lblproduct.Location = new System.Drawing.Point(273, 56);
            this.lblproduct.Name = "lblproduct";
            this.lblproduct.Size = new System.Drawing.Size(122, 17);
            this.lblproduct.TabIndex = 15;
            this.lblproduct.Text = "Product Number";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Verdana", 10F);
            this.lblid.Location = new System.Drawing.Point(273, 26);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(24, 17);
            this.lblid.TabIndex = 14;
            this.lblid.Text = "ID";
            // 
            // lblNext
            // 
            this.lblNext.AutoSize = true;
            this.lblNext.Font = new System.Drawing.Font("Verdana", 10F);
            this.lblNext.Location = new System.Drawing.Point(741, 122);
            this.lblNext.Name = "lblNext";
            this.lblNext.Size = new System.Drawing.Size(86, 17);
            this.lblNext.TabIndex = 25;
            this.lblNext.Text = "Next Stock";
            // 
            // lblReorder
            // 
            this.lblReorder.AutoSize = true;
            this.lblReorder.Font = new System.Drawing.Font("Verdana", 10F);
            this.lblReorder.Location = new System.Drawing.Point(741, 89);
            this.lblReorder.Name = "lblReorder";
            this.lblReorder.Size = new System.Drawing.Size(64, 17);
            this.lblReorder.TabIndex = 24;
            this.lblReorder.Text = "Reorder";
            // 
            // lblLast
            // 
            this.lblLast.AutoSize = true;
            this.lblLast.Font = new System.Drawing.Font("Verdana", 10F);
            this.lblLast.Location = new System.Drawing.Point(741, 57);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(93, 17);
            this.lblLast.TabIndex = 23;
            this.lblLast.Text = "Last Update";
            // 
            // lblStorage
            // 
            this.lblStorage.AutoSize = true;
            this.lblStorage.Font = new System.Drawing.Font("Verdana", 10F);
            this.lblStorage.Location = new System.Drawing.Point(741, 27);
            this.lblStorage.Name = "lblStorage";
            this.lblStorage.Size = new System.Drawing.Size(124, 17);
            this.lblStorage.TabIndex = 22;
            this.lblStorage.Text = "Storage Number";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(133)))), ((int)(((byte)(0)))));
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Font = new System.Drawing.Font("Arial Black", 11.75F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(1229, 235);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(197, 46);
            this.btnEdit.TabIndex = 26;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // designPanel
            // 
            this.designPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.designPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.designPanel.Controls.Add(this.label14);
            this.designPanel.Location = new System.Drawing.Point(45, 18);
            this.designPanel.Name = "designPanel";
            this.designPanel.Size = new System.Drawing.Size(1455, 54);
            this.designPanel.TabIndex = 27;
            this.designPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.designPanel_Paint);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Lexend", 18F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(27, 8);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 38);
            this.label14.TabIndex = 32;
            this.label14.Text = "Stock";
            // 
            // panelSearchStock
            // 
            this.panelSearchStock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSearchStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.panelSearchStock.Controls.Add(this.label13);
            this.panelSearchStock.Controls.Add(this.btnViewProduct);
            this.panelSearchStock.Controls.Add(this.tbSearch);
            this.panelSearchStock.Location = new System.Drawing.Point(45, 615);
            this.panelSearchStock.Name = "panelSearchStock";
            this.panelSearchStock.Size = new System.Drawing.Size(1455, 55);
            this.panelSearchStock.TabIndex = 28;
            this.panelSearchStock.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSearchStock_Paint);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Lexend", 16F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(28, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 35);
            this.label13.TabIndex = 31;
            this.label13.Text = "Search:";
            // 
            // btnViewProduct
            // 
            this.btnViewProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(158)))), ((int)(((byte)(188)))));
            this.btnViewProduct.FlatAppearance.BorderSize = 0;
            this.btnViewProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnViewProduct.Font = new System.Drawing.Font("Lexend", 10F);
            this.btnViewProduct.ForeColor = System.Drawing.Color.White;
            this.btnViewProduct.Location = new System.Drawing.Point(1217, 10);
            this.btnViewProduct.Name = "btnViewProduct";
            this.btnViewProduct.Size = new System.Drawing.Size(223, 35);
            this.btnViewProduct.TabIndex = 30;
            this.btnViewProduct.Text = "View Product List";
            this.btnViewProduct.UseVisualStyleBackColor = false;
            this.btnViewProduct.Click += new System.EventHandler(this.btnViewProduct_Click);
            // 
            // panelStock
            // 
            this.panelStock.BackColor = System.Drawing.Color.White;
            this.panelStock.Controls.Add(this.lblNext);
            this.panelStock.Controls.Add(this.lblReorder);
            this.panelStock.Controls.Add(this.btnEdit);
            this.panelStock.Controls.Add(this.lblLast);
            this.panelStock.Controls.Add(this.lblStorage);
            this.panelStock.Controls.Add(this.lblOn);
            this.panelStock.Controls.Add(this.lblSales);
            this.panelStock.Controls.Add(this.lblOut);
            this.panelStock.Controls.Add(this.lblValue);
            this.panelStock.Controls.Add(this.lblStock);
            this.panelStock.Controls.Add(this.lblDes);
            this.panelStock.Controls.Add(this.lblproduct);
            this.panelStock.Controls.Add(this.lblid);
            this.panelStock.Controls.Add(this.label9);
            this.panelStock.Controls.Add(this.label10);
            this.panelStock.Controls.Add(this.label11);
            this.panelStock.Controls.Add(this.label12);
            this.panelStock.Controls.Add(this.label8);
            this.panelStock.Controls.Add(this.label7);
            this.panelStock.Controls.Add(this.label6);
            this.panelStock.Controls.Add(this.label5);
            this.panelStock.Controls.Add(this.label4);
            this.panelStock.Controls.Add(this.label3);
            this.panelStock.Controls.Add(this.label2);
            this.panelStock.Controls.Add(this.label1);
            this.panelStock.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.panelStock.Location = new System.Drawing.Point(45, 691);
            this.panelStock.Name = "panelStock";
            this.panelStock.Size = new System.Drawing.Size(1455, 306);
            this.panelStock.TabIndex = 29;
            this.panelStock.Paint += new System.Windows.Forms.PaintEventHandler(this.panelStock_Paint);
            // 
            // StockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1546, 1023);
            this.Controls.Add(this.panelSearchStock);
            this.Controls.Add(this.designPanel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelStock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StockForm";
            this.Text = "StockForm";
            this.Load += new System.EventHandler(this.StockForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.designPanel.ResumeLayout(false);
            this.designPanel.PerformLayout();
            this.panelSearchStock.ResumeLayout(false);
            this.panelSearchStock.PerformLayout();
            this.panelStock.ResumeLayout(false);
            this.panelStock.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblOn;
        private System.Windows.Forms.Label lblSales;
        private System.Windows.Forms.Label lblOut;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblDes;
        private System.Windows.Forms.Label lblproduct;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblNext;
        private System.Windows.Forms.Label lblReorder;
        private System.Windows.Forms.Label lblLast;
        private System.Windows.Forms.Label lblStorage;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.Panel designPanel;
        private System.Windows.Forms.Panel panelSearchStock;
        private System.Windows.Forms.Button btnViewProduct;
        private System.Windows.Forms.Panel panelStock;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}