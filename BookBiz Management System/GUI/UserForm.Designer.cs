namespace BookBiz_Management_System.GUI
{
    partial class UserForm
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
            this.tb_user_id = new System.Windows.Forms.TextBox();
            this.tb_designation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_employee_id = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_list = new System.Windows.Forms.Button();
            this.groupBox_user = new System.Windows.Forms.GroupBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listView_user = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_exit = new System.Windows.Forms.Button();
            this.groupBox_user.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "User ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Designation";
            // 
            // tb_user_id
            // 
            this.tb_user_id.Location = new System.Drawing.Point(60, 61);
            this.tb_user_id.Name = "tb_user_id";
            this.tb_user_id.Size = new System.Drawing.Size(128, 22);
            this.tb_user_id.TabIndex = 2;
            // 
            // tb_designation
            // 
            this.tb_designation.Location = new System.Drawing.Point(60, 118);
            this.tb_designation.Name = "tb_designation";
            this.tb_designation.Size = new System.Drawing.Size(128, 22);
            this.tb_designation.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Employee ID";
            // 
            // tb_employee_id
            // 
            this.tb_employee_id.Location = new System.Drawing.Point(60, 179);
            this.tb_employee_id.Name = "tb_employee_id";
            this.tb_employee_id.Size = new System.Drawing.Size(128, 22);
            this.tb_employee_id.TabIndex = 5;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(257, 58);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(104, 54);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "&Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_list
            // 
            this.btn_list.Location = new System.Drawing.Point(257, 139);
            this.btn_list.Name = "btn_list";
            this.btn_list.Size = new System.Drawing.Size(104, 54);
            this.btn_list.TabIndex = 7;
            this.btn_list.Text = "&List";
            this.btn_list.UseVisualStyleBackColor = true;
            this.btn_list.Click += new System.EventHandler(this.btn_list_Click);
            // 
            // groupBox_user
            // 
            this.groupBox_user.Controls.Add(this.btn_search);
            this.groupBox_user.Controls.Add(this.tb_search);
            this.groupBox_user.Controls.Add(this.label4);
            this.groupBox_user.Location = new System.Drawing.Point(418, 40);
            this.groupBox_user.Name = "groupBox_user";
            this.groupBox_user.Size = new System.Drawing.Size(195, 161);
            this.groupBox_user.TabIndex = 8;
            this.groupBox_user.TabStop = false;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(41, 88);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(104, 54);
            this.btn_search.TabIndex = 9;
            this.btn_search.Text = "S&earch";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(29, 46);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(128, 22);
            this.tb_search.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Enter User ID";
            // 
            // listView_user
            // 
            this.listView_user.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView_user.GridLines = true;
            this.listView_user.HideSelection = false;
            this.listView_user.Location = new System.Drawing.Point(13, 217);
            this.listView_user.Name = "listView_user";
            this.listView_user.Size = new System.Drawing.Size(659, 185);
            this.listView_user.TabIndex = 9;
            this.listView_user.UseCompatibleStateImageBehavior = false;
            this.listView_user.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "User ID";
            this.columnHeader1.Width = 217;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Designation";
            this.columnHeader2.Width = 233;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Employee ID";
            this.columnHeader3.Width = 203;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(282, 414);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(104, 43);
            this.btn_exit.TabIndex = 10;
            this.btn_exit.Text = "E&xit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 465);
            this.ControlBox = false;
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.listView_user);
            this.Controls.Add(this.groupBox_user);
            this.Controls.Add(this.btn_list);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.tb_employee_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_designation);
            this.Controls.Add(this.tb_user_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Form";
            this.groupBox_user.ResumeLayout(false);
            this.groupBox_user.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_user_id;
        private System.Windows.Forms.TextBox tb_designation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_employee_id;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_list;
        private System.Windows.Forms.GroupBox groupBox_user;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listView_user;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btn_exit;
    }
}