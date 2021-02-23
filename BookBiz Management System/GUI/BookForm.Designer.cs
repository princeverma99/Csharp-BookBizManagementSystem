namespace BookBiz_Management_System.GUI
{
    partial class BookForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_isbn = new System.Windows.Forms.TextBox();
            this.tb_unit_price = new System.Windows.Forms.TextBox();
            this.tb_title = new System.Windows.Forms.TextBox();
            this.tb_year_published = new System.Windows.Forms.TextBox();
            this.tb_quantity_on_hand = new System.Windows.Forms.TextBox();
            this.btn_add_to_list = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox_search = new System.Windows.Forms.GroupBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listView_book = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_exit = new System.Windows.Forms.Button();
            this.groupBox_search.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ISBN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Unit Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(197, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Year Published";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quantity on Hand";
            // 
            // tb_isbn
            // 
            this.tb_isbn.Location = new System.Drawing.Point(44, 47);
            this.tb_isbn.Name = "tb_isbn";
            this.tb_isbn.Size = new System.Drawing.Size(116, 22);
            this.tb_isbn.TabIndex = 5;
            // 
            // tb_unit_price
            // 
            this.tb_unit_price.Location = new System.Drawing.Point(44, 110);
            this.tb_unit_price.Name = "tb_unit_price";
            this.tb_unit_price.Size = new System.Drawing.Size(116, 22);
            this.tb_unit_price.TabIndex = 6;
            // 
            // tb_title
            // 
            this.tb_title.Location = new System.Drawing.Point(200, 47);
            this.tb_title.Name = "tb_title";
            this.tb_title.Size = new System.Drawing.Size(116, 22);
            this.tb_title.TabIndex = 7;
            // 
            // tb_year_published
            // 
            this.tb_year_published.Location = new System.Drawing.Point(200, 110);
            this.tb_year_published.Name = "tb_year_published";
            this.tb_year_published.Size = new System.Drawing.Size(116, 22);
            this.tb_year_published.TabIndex = 8;
            // 
            // tb_quantity_on_hand
            // 
            this.tb_quantity_on_hand.Location = new System.Drawing.Point(44, 171);
            this.tb_quantity_on_hand.Name = "tb_quantity_on_hand";
            this.tb_quantity_on_hand.Size = new System.Drawing.Size(116, 22);
            this.tb_quantity_on_hand.TabIndex = 9;
            // 
            // btn_add_to_list
            // 
            this.btn_add_to_list.Location = new System.Drawing.Point(374, 65);
            this.btn_add_to_list.Name = "btn_add_to_list";
            this.btn_add_to_list.Size = new System.Drawing.Size(119, 47);
            this.btn_add_to_list.TabIndex = 10;
            this.btn_add_to_list.Text = "&Add to List";
            this.btn_add_to_list.UseVisualStyleBackColor = true;
            this.btn_add_to_list.Click += new System.EventHandler(this.btn_add_to_list_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(374, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 47);
            this.button1.TabIndex = 11;
            this.button1.Text = "&List";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox_search
            // 
            this.groupBox_search.Controls.Add(this.btn_search);
            this.groupBox_search.Controls.Add(this.tb_search);
            this.groupBox_search.Controls.Add(this.label6);
            this.groupBox_search.Location = new System.Drawing.Point(526, 36);
            this.groupBox_search.Name = "groupBox_search";
            this.groupBox_search.Size = new System.Drawing.Size(172, 167);
            this.groupBox_search.TabIndex = 12;
            this.groupBox_search.TabStop = false;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(26, 101);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(119, 47);
            this.btn_search.TabIndex = 13;
            this.btn_search.Text = "S&earch";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(29, 50);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(116, 22);
            this.tb_search.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Enter ISBN to search";
            // 
            // listView_book
            // 
            this.listView_book.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView_book.GridLines = true;
            this.listView_book.HideSelection = false;
            this.listView_book.Location = new System.Drawing.Point(13, 228);
            this.listView_book.Name = "listView_book";
            this.listView_book.Size = new System.Drawing.Size(685, 167);
            this.listView_book.TabIndex = 13;
            this.listView_book.UseCompatibleStateImageBehavior = false;
            this.listView_book.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ISBN";
            this.columnHeader1.Width = 81;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Title";
            this.columnHeader2.Width = 229;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Unit Price";
            this.columnHeader3.Width = 143;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Year Published";
            this.columnHeader4.Width = 109;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Quantity on Hand";
            this.columnHeader5.Width = 118;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(292, 413);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(123, 38);
            this.btn_exit.TabIndex = 14;
            this.btn_exit.Text = "E&xit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 463);
            this.ControlBox = false;
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.listView_book);
            this.Controls.Add(this.groupBox_search);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_add_to_list);
            this.Controls.Add(this.tb_quantity_on_hand);
            this.Controls.Add(this.tb_year_published);
            this.Controls.Add(this.tb_title);
            this.Controls.Add(this.tb_unit_price);
            this.Controls.Add(this.tb_isbn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Form";
            this.Load += new System.EventHandler(this.BookForm_Load);
            this.groupBox_search.ResumeLayout(false);
            this.groupBox_search.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_isbn;
        private System.Windows.Forms.TextBox tb_unit_price;
        private System.Windows.Forms.TextBox tb_title;
        private System.Windows.Forms.TextBox tb_year_published;
        private System.Windows.Forms.TextBox tb_quantity_on_hand;
        private System.Windows.Forms.Button btn_add_to_list;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView listView_book;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}