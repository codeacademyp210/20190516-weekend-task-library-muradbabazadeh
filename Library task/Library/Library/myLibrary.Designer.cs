namespace Library
{
    partial class myLibrary
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cxcxcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xcxccToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xcxcxcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sdsfdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txtClientSearch = new System.Windows.Forms.TextBox();
            this.ClientBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBookSearch = new System.Windows.Forms.TextBox();
            this.BookBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderBtn = new System.Windows.Forms.Button();
            this.clienstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cxcxcToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1001, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cxcxcToolStripMenuItem
            // 
            this.cxcxcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xcxccToolStripMenuItem,
            this.xcxcxcToolStripMenuItem,
            this.sdsfdToolStripMenuItem,
            this.ordersToolStripMenuItem,
            this.categoriesToolStripMenuItem});
            this.cxcxcToolStripMenuItem.Name = "cxcxcToolStripMenuItem";
            this.cxcxcToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.cxcxcToolStripMenuItem.Text = "Menu";
            // 
            // xcxccToolStripMenuItem
            // 
            this.xcxccToolStripMenuItem.Name = "xcxccToolStripMenuItem";
            this.xcxccToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.xcxccToolStripMenuItem.Text = "Books";
            this.xcxccToolStripMenuItem.Click += new System.EventHandler(this.XcxccToolStripMenuItem_Click);
            // 
            // xcxcxcToolStripMenuItem
            // 
            this.xcxcxcToolStripMenuItem.Name = "xcxcxcToolStripMenuItem";
            this.xcxcxcToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.xcxcxcToolStripMenuItem.Text = "Authors";
            // 
            // sdsfdToolStripMenuItem
            // 
            this.sdsfdToolStripMenuItem.Name = "sdsfdToolStripMenuItem";
            this.sdsfdToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.sdsfdToolStripMenuItem.Text = "Client";
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.ordersToolStripMenuItem.Text = "Orders";
            // 
            // categoriesToolStripMenuItem
            // 
            this.categoriesToolStripMenuItem.Name = "categoriesToolStripMenuItem";
            this.categoriesToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.categoriesToolStripMenuItem.Text = "Categories";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Clients";
            // 
            // txtClientSearch
            // 
            this.txtClientSearch.Location = new System.Drawing.Point(16, 99);
            this.txtClientSearch.Name = "txtClientSearch";
            this.txtClientSearch.Size = new System.Drawing.Size(277, 22);
            this.txtClientSearch.TabIndex = 2;
            // 
            // ClientBtn
            // 
            this.ClientBtn.Location = new System.Drawing.Point(369, 99);
            this.ClientBtn.Name = "ClientBtn";
            this.ClientBtn.Size = new System.Drawing.Size(91, 23);
            this.ClientBtn.TabIndex = 3;
            this.ClientBtn.Text = "Search";
            this.ClientBtn.UseVisualStyleBackColor = true;
            this.ClientBtn.Click += new System.EventHandler(this.ClientBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(520, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Books";
            // 
            // txtBookSearch
            // 
            this.txtBookSearch.Location = new System.Drawing.Point(523, 100);
            this.txtBookSearch.Name = "txtBookSearch";
            this.txtBookSearch.Size = new System.Drawing.Size(277, 22);
            this.txtBookSearch.TabIndex = 5;
            // 
            // BookBtn
            // 
            this.BookBtn.Location = new System.Drawing.Point(886, 98);
            this.BookBtn.Name = "BookBtn";
            this.BookBtn.Size = new System.Drawing.Size(91, 23);
            this.BookBtn.TabIndex = 6;
            this.BookBtn.Text = "Search";
            this.BookBtn.UseVisualStyleBackColor = true;
            this.BookBtn.Click += new System.EventHandler(this.BookBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClientName,
            this.ClientSurname,
            this.ClientEmail,
            this.ClientPhone,
            this.clienstatus});
            this.dataGridView1.Location = new System.Drawing.Point(17, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(443, 364);
            this.dataGridView1.TabIndex = 7;
            // 
            // ClientName
            // 
            this.ClientName.HeaderText = "Name";
            this.ClientName.Name = "ClientName";
            this.ClientName.ReadOnly = true;
            // 
            // ClientSurname
            // 
            this.ClientSurname.HeaderText = "Surname";
            this.ClientSurname.Name = "ClientSurname";
            this.ClientSurname.ReadOnly = true;
            // 
            // ClientEmail
            // 
            this.ClientEmail.HeaderText = "Email";
            this.ClientEmail.Name = "ClientEmail";
            this.ClientEmail.ReadOnly = true;
            // 
            // ClientPhone
            // 
            this.ClientPhone.HeaderText = "Phone";
            this.ClientPhone.Name = "ClientPhone";
            this.ClientPhone.ReadOnly = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookName,
            this.BookAuthor,
            this.BookPrice});
            this.dataGridView2.Location = new System.Drawing.Point(514, 133);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(454, 452);
            this.dataGridView2.TabIndex = 8;
            // 
            // BookName
            // 
            this.BookName.HeaderText = "Name";
            this.BookName.Name = "BookName";
            this.BookName.ReadOnly = true;
            // 
            // BookAuthor
            // 
            this.BookAuthor.HeaderText = "Author";
            this.BookAuthor.Name = "BookAuthor";
            this.BookAuthor.ReadOnly = true;
            // 
            // BookPrice
            // 
            this.BookPrice.HeaderText = "Price";
            this.BookPrice.Name = "BookPrice";
            this.BookPrice.ReadOnly = true;
            // 
            // OrderBtn
            // 
            this.OrderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.OrderBtn.Location = new System.Drawing.Point(16, 534);
            this.OrderBtn.Name = "OrderBtn";
            this.OrderBtn.Size = new System.Drawing.Size(444, 51);
            this.OrderBtn.TabIndex = 9;
            this.OrderBtn.Text = "Order";
            this.OrderBtn.UseVisualStyleBackColor = true;
            // 
            // clienstatus
            // 
            this.clienstatus.HeaderText = "Status";
            this.clienstatus.Name = "clienstatus";
            this.clienstatus.ReadOnly = true;
            // 
            // myLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 672);
            this.Controls.Add(this.OrderBtn);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BookBtn);
            this.Controls.Add(this.txtBookSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ClientBtn);
            this.Controls.Add(this.txtClientSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "myLibrary";
            this.Text = "myLibrary";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cxcxcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xcxccToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xcxcxcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sdsfdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClientSearch;
        private System.Windows.Forms.Button ClientBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBookSearch;
        private System.Windows.Forms.Button BookBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientPhone;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookPrice;
        private System.Windows.Forms.Button OrderBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienstatus;
    }
}