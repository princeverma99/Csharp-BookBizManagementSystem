namespace BookBiz_Management_System.GUI
{
    partial class ClientsForm
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
            this.label_client_name = new System.Windows.Forms.Label();
            this.lbl_address = new System.Windows.Forms.Label();
            this.label_street = new System.Windows.Forms.Label();
            this.label_city = new System.Windows.Forms.Label();
            this.label_postal_code = new System.Windows.Forms.Label();
            this.label_client_id = new System.Windows.Forms.Label();
            this.label_phone_no = new System.Windows.Forms.Label();
            this.label_fax = new System.Windows.Forms.Label();
            this.label_credit_limit = new System.Windows.Forms.Label();
            this.textBox_client_id = new System.Windows.Forms.TextBox();
            this.textBox_street = new System.Windows.Forms.TextBox();
            this.textBox_city = new System.Windows.Forms.TextBox();
            this.textBox_client_name = new System.Windows.Forms.TextBox();
            this.textBox_credit_limit = new System.Windows.Forms.TextBox();
            this.maskedTextBox_phone_no = new System.Windows.Forms.MaskedTextBox();
            this.button_add_to_list = new System.Windows.Forms.Button();
            this.button_search = new System.Windows.Forms.Button();
            this.button_list = new System.Windows.Forms.Button();
            this.listView_clients = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_exit = new System.Windows.Forms.Button();
            this.label_search = new System.Windows.Forms.Label();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.textBox_postal_code = new System.Windows.Forms.TextBox();
            this.textBox_fax_number = new System.Windows.Forms.TextBox();
            this.groupBox_search = new System.Windows.Forms.GroupBox();
            this.groupBox_search.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_client_name
            // 
            this.label_client_name.AutoSize = true;
            this.label_client_name.Location = new System.Drawing.Point(252, 32);
            this.label_client_name.Name = "label_client_name";
            this.label_client_name.Size = new System.Drawing.Size(84, 17);
            this.label_client_name.TabIndex = 1;
            this.label_client_name.Text = "Client Name";
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Location = new System.Drawing.Point(61, 86);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(93, 17);
            this.lbl_address.TabIndex = 2;
            this.lbl_address.Text = "Add Address:";
            // 
            // label_street
            // 
            this.label_street.AutoSize = true;
            this.label_street.Location = new System.Drawing.Point(67, 107);
            this.label_street.Name = "label_street";
            this.label_street.Size = new System.Drawing.Size(46, 17);
            this.label_street.TabIndex = 3;
            this.label_street.Text = "Street";
            // 
            // label_city
            // 
            this.label_city.AutoSize = true;
            this.label_city.Location = new System.Drawing.Point(67, 156);
            this.label_city.Name = "label_city";
            this.label_city.Size = new System.Drawing.Size(31, 17);
            this.label_city.TabIndex = 4;
            this.label_city.Text = "City";
            // 
            // label_postal_code
            // 
            this.label_postal_code.AutoSize = true;
            this.label_postal_code.Location = new System.Drawing.Point(67, 208);
            this.label_postal_code.Name = "label_postal_code";
            this.label_postal_code.Size = new System.Drawing.Size(84, 17);
            this.label_postal_code.TabIndex = 5;
            this.label_postal_code.Text = "Postal Code";
            // 
            // label_client_id
            // 
            this.label_client_id.AutoSize = true;
            this.label_client_id.Location = new System.Drawing.Point(61, 31);
            this.label_client_id.Name = "label_client_id";
            this.label_client_id.Size = new System.Drawing.Size(60, 17);
            this.label_client_id.TabIndex = 6;
            this.label_client_id.Text = "Client ID";
            // 
            // label_phone_no
            // 
            this.label_phone_no.AutoSize = true;
            this.label_phone_no.Location = new System.Drawing.Point(252, 86);
            this.label_phone_no.Name = "label_phone_no";
            this.label_phone_no.Size = new System.Drawing.Size(103, 17);
            this.label_phone_no.TabIndex = 7;
            this.label_phone_no.Text = "Phone Number";
            // 
            // label_fax
            // 
            this.label_fax.AutoSize = true;
            this.label_fax.Location = new System.Drawing.Point(252, 146);
            this.label_fax.Name = "label_fax";
            this.label_fax.Size = new System.Drawing.Size(84, 17);
            this.label_fax.TabIndex = 8;
            this.label_fax.Text = "Fax Number";
            // 
            // label_credit_limit
            // 
            this.label_credit_limit.AutoSize = true;
            this.label_credit_limit.Location = new System.Drawing.Point(252, 208);
            this.label_credit_limit.Name = "label_credit_limit";
            this.label_credit_limit.Size = new System.Drawing.Size(78, 17);
            this.label_credit_limit.TabIndex = 9;
            this.label_credit_limit.Text = "Credit Limit";
            // 
            // textBox_client_id
            // 
            this.textBox_client_id.Location = new System.Drawing.Point(64, 52);
            this.textBox_client_id.Name = "textBox_client_id";
            this.textBox_client_id.Size = new System.Drawing.Size(130, 22);
            this.textBox_client_id.TabIndex = 10;
            // 
            // textBox_street
            // 
            this.textBox_street.Location = new System.Drawing.Point(70, 127);
            this.textBox_street.Name = "textBox_street";
            this.textBox_street.Size = new System.Drawing.Size(130, 22);
            this.textBox_street.TabIndex = 11;
            // 
            // textBox_city
            // 
            this.textBox_city.Location = new System.Drawing.Point(70, 176);
            this.textBox_city.Name = "textBox_city";
            this.textBox_city.Size = new System.Drawing.Size(130, 22);
            this.textBox_city.TabIndex = 12;
            // 
            // textBox_client_name
            // 
            this.textBox_client_name.Location = new System.Drawing.Point(255, 52);
            this.textBox_client_name.Name = "textBox_client_name";
            this.textBox_client_name.Size = new System.Drawing.Size(130, 22);
            this.textBox_client_name.TabIndex = 14;
            // 
            // textBox_credit_limit
            // 
            this.textBox_credit_limit.Location = new System.Drawing.Point(255, 228);
            this.textBox_credit_limit.Name = "textBox_credit_limit";
            this.textBox_credit_limit.Size = new System.Drawing.Size(130, 22);
            this.textBox_credit_limit.TabIndex = 17;
            // 
            // maskedTextBox_phone_no
            // 
            this.maskedTextBox_phone_no.Location = new System.Drawing.Point(255, 107);
            this.maskedTextBox_phone_no.Mask = "(999) 000-0000";
            this.maskedTextBox_phone_no.Name = "maskedTextBox_phone_no";
            this.maskedTextBox_phone_no.Size = new System.Drawing.Size(130, 22);
            this.maskedTextBox_phone_no.TabIndex = 19;
            // 
            // button_add_to_list
            // 
            this.button_add_to_list.Location = new System.Drawing.Point(416, 86);
            this.button_add_to_list.Name = "button_add_to_list";
            this.button_add_to_list.Size = new System.Drawing.Size(129, 57);
            this.button_add_to_list.TabIndex = 20;
            this.button_add_to_list.Text = "&Add to List";
            this.button_add_to_list.UseVisualStyleBackColor = true;
            this.button_add_to_list.Click += new System.EventHandler(this.button_add_to_list_Click);
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(35, 85);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(129, 57);
            this.button_search.TabIndex = 21;
            this.button_search.Text = "S&earch";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // button_list
            // 
            this.button_list.Location = new System.Drawing.Point(416, 168);
            this.button_list.Name = "button_list";
            this.button_list.Size = new System.Drawing.Size(129, 57);
            this.button_list.TabIndex = 22;
            this.button_list.Text = "&List";
            this.button_list.UseVisualStyleBackColor = true;
            this.button_list.Click += new System.EventHandler(this.button_list_Click);
            // 
            // listView_clients
            // 
            this.listView_clients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listView_clients.GridLines = true;
            this.listView_clients.HideSelection = false;
            this.listView_clients.Location = new System.Drawing.Point(12, 283);
            this.listView_clients.Name = "listView_clients";
            this.listView_clients.Size = new System.Drawing.Size(796, 154);
            this.listView_clients.TabIndex = 23;
            this.listView_clients.UseCompatibleStateImageBehavior = false;
            this.listView_clients.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Client ID";
            this.columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Client Name";
            this.columnHeader2.Width = 166;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Street";
            this.columnHeader3.Width = 64;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "City";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Postal Code";
            this.columnHeader5.Width = 88;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Phone Number";
            this.columnHeader6.Width = 116;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Fax Number";
            this.columnHeader7.Width = 111;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Credit Limit";
            this.columnHeader8.Width = 96;
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(354, 450);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(111, 36);
            this.button_exit.TabIndex = 24;
            this.button_exit.Text = "E&xit";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // label_search
            // 
            this.label_search.AutoSize = true;
            this.label_search.Location = new System.Drawing.Point(16, 23);
            this.label_search.Name = "label_search";
            this.label_search.Size = new System.Drawing.Size(161, 17);
            this.label_search.TabIndex = 25;
            this.label_search.Text = "Enter Client ID to search";
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(34, 43);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(130, 22);
            this.textBox_search.TabIndex = 26;
            // 
            // textBox_postal_code
            // 
            this.textBox_postal_code.Location = new System.Drawing.Point(70, 229);
            this.textBox_postal_code.Name = "textBox_postal_code";
            this.textBox_postal_code.Size = new System.Drawing.Size(130, 22);
            this.textBox_postal_code.TabIndex = 27;
            // 
            // textBox_fax_number
            // 
            this.textBox_fax_number.Location = new System.Drawing.Point(255, 168);
            this.textBox_fax_number.Name = "textBox_fax_number";
            this.textBox_fax_number.Size = new System.Drawing.Size(130, 22);
            this.textBox_fax_number.TabIndex = 28;
            // 
            // groupBox_search
            // 
            this.groupBox_search.Controls.Add(this.label_search);
            this.groupBox_search.Controls.Add(this.textBox_search);
            this.groupBox_search.Controls.Add(this.button_search);
            this.groupBox_search.Location = new System.Drawing.Point(585, 67);
            this.groupBox_search.Name = "groupBox_search";
            this.groupBox_search.Size = new System.Drawing.Size(200, 158);
            this.groupBox_search.TabIndex = 29;
            this.groupBox_search.TabStop = false;
            // 
            // ClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 498);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox_search);
            this.Controls.Add(this.textBox_fax_number);
            this.Controls.Add(this.textBox_postal_code);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.listView_clients);
            this.Controls.Add(this.button_list);
            this.Controls.Add(this.button_add_to_list);
            this.Controls.Add(this.maskedTextBox_phone_no);
            this.Controls.Add(this.textBox_credit_limit);
            this.Controls.Add(this.textBox_client_name);
            this.Controls.Add(this.textBox_city);
            this.Controls.Add(this.textBox_street);
            this.Controls.Add(this.textBox_client_id);
            this.Controls.Add(this.label_credit_limit);
            this.Controls.Add(this.label_fax);
            this.Controls.Add(this.label_phone_no);
            this.Controls.Add(this.label_client_id);
            this.Controls.Add(this.label_postal_code);
            this.Controls.Add(this.label_city);
            this.Controls.Add(this.label_street);
            this.Controls.Add(this.lbl_address);
            this.Controls.Add(this.label_client_name);
            this.Name = "ClientsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clients";
            this.Load += new System.EventHandler(this.Clients_Load);
            this.groupBox_search.ResumeLayout(false);
            this.groupBox_search.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_client_name;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.Label label_street;
        private System.Windows.Forms.Label label_city;
        private System.Windows.Forms.Label label_postal_code;
        private System.Windows.Forms.Label label_client_id;
        private System.Windows.Forms.Label label_phone_no;
        private System.Windows.Forms.Label label_fax;
        private System.Windows.Forms.Label label_credit_limit;
        private System.Windows.Forms.TextBox textBox_client_id;
        private System.Windows.Forms.TextBox textBox_street;
        private System.Windows.Forms.TextBox textBox_city;
        private System.Windows.Forms.TextBox textBox_client_name;
        private System.Windows.Forms.TextBox textBox_credit_limit;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_phone_no;
        private System.Windows.Forms.Button button_add_to_list;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Button button_list;
        private System.Windows.Forms.ListView listView_clients;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Label label_search;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.TextBox textBox_postal_code;
        private System.Windows.Forms.TextBox textBox_fax_number;
        private System.Windows.Forms.GroupBox groupBox_search;
    }
}