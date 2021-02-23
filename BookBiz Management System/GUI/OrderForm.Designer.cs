namespace BookBiz_Management_System.GUI
{
    partial class OrderForm
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
            this.lbl_order_id = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_order_id = new System.Windows.Forms.TextBox();
            this.tb_client_id = new System.Windows.Forms.TextBox();
            this.tb_book_id = new System.Windows.Forms.TextBox();
            this.tb_quantity = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.groupBox_search_delete = new System.Windows.Forms.GroupBox();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listView_orders = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_list = new System.Windows.Forms.Button();
            this.groupBox_search_delete.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_order_id
            // 
            this.lbl_order_id.AutoSize = true;
            this.lbl_order_id.Location = new System.Drawing.Point(55, 42);
            this.lbl_order_id.Name = "lbl_order_id";
            this.lbl_order_id.Size = new System.Drawing.Size(62, 17);
            this.lbl_order_id.TabIndex = 0;
            this.lbl_order_id.Text = "Order ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Client ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Book ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Quantity";
            // 
            // tb_order_id
            // 
            this.tb_order_id.Location = new System.Drawing.Point(58, 63);
            this.tb_order_id.Name = "tb_order_id";
            this.tb_order_id.Size = new System.Drawing.Size(111, 22);
            this.tb_order_id.TabIndex = 4;
            // 
            // tb_client_id
            // 
            this.tb_client_id.Location = new System.Drawing.Point(210, 62);
            this.tb_client_id.Name = "tb_client_id";
            this.tb_client_id.Size = new System.Drawing.Size(111, 22);
            this.tb_client_id.TabIndex = 5;
            // 
            // tb_book_id
            // 
            this.tb_book_id.Location = new System.Drawing.Point(58, 127);
            this.tb_book_id.Name = "tb_book_id";
            this.tb_book_id.Size = new System.Drawing.Size(111, 22);
            this.tb_book_id.TabIndex = 6;
            // 
            // tb_quantity
            // 
            this.tb_quantity.Location = new System.Drawing.Point(210, 127);
            this.tb_quantity.Name = "tb_quantity";
            this.tb_quantity.Size = new System.Drawing.Size(111, 22);
            this.tb_quantity.TabIndex = 7;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(387, 37);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(103, 49);
            this.btn_add.TabIndex = 8;
            this.btn_add.Text = "&Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(51, 120);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(103, 39);
            this.btn_cancel.TabIndex = 9;
            this.btn_cancel.Text = "&Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(51, 75);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(103, 39);
            this.btn_search.TabIndex = 10;
            this.btn_search.Text = "S&earch";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // groupBox_search_delete
            // 
            this.groupBox_search_delete.Controls.Add(this.tb_search);
            this.groupBox_search_delete.Controls.Add(this.label4);
            this.groupBox_search_delete.Controls.Add(this.btn_cancel);
            this.groupBox_search_delete.Controls.Add(this.btn_search);
            this.groupBox_search_delete.Location = new System.Drawing.Point(546, 7);
            this.groupBox_search_delete.Name = "groupBox_search_delete";
            this.groupBox_search_delete.Size = new System.Drawing.Size(200, 168);
            this.groupBox_search_delete.TabIndex = 12;
            this.groupBox_search_delete.TabStop = false;
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(38, 37);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(121, 22);
            this.tb_search.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Enter Order ID";
            // 
            // listView_orders
            // 
            this.listView_orders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView_orders.GridLines = true;
            this.listView_orders.HideSelection = false;
            this.listView_orders.Location = new System.Drawing.Point(13, 191);
            this.listView_orders.Name = "listView_orders";
            this.listView_orders.Size = new System.Drawing.Size(775, 188);
            this.listView_orders.TabIndex = 13;
            this.listView_orders.UseCompatibleStateImageBehavior = false;
            this.listView_orders.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Order ID";
            this.columnHeader1.Width = 187;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Client ID";
            this.columnHeader2.Width = 167;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Book ID";
            this.columnHeader3.Width = 228;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Quantity";
            this.columnHeader4.Width = 188;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(342, 386);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(103, 37);
            this.btn_exit.TabIndex = 14;
            this.btn_exit.Text = "E&xit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_list
            // 
            this.btn_list.Location = new System.Drawing.Point(387, 114);
            this.btn_list.Name = "btn_list";
            this.btn_list.Size = new System.Drawing.Size(103, 49);
            this.btn_list.TabIndex = 15;
            this.btn_list.Text = "&List";
            this.btn_list.UseVisualStyleBackColor = true;
            this.btn_list.Click += new System.EventHandler(this.btn_list_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 435);
            this.ControlBox = false;
            this.Controls.Add(this.btn_list);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.listView_orders);
            this.Controls.Add(this.groupBox_search_delete);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.tb_quantity);
            this.Controls.Add(this.tb_book_id);
            this.Controls.Add(this.tb_client_id);
            this.Controls.Add(this.tb_order_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_order_id);
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Form";
            this.groupBox_search_delete.ResumeLayout(false);
            this.groupBox_search_delete.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_order_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_order_id;
        private System.Windows.Forms.TextBox tb_client_id;
        private System.Windows.Forms.TextBox tb_book_id;
        private System.Windows.Forms.TextBox tb_quantity;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.GroupBox groupBox_search_delete;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listView_orders;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_list;
    }
}