namespace BookBiz_Management_System.GUI
{
    partial class EmployeeForm
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
            this.tb_employee_id = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.maskedTextBox_phone_no = new System.Windows.Forms.MaskedTextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_list = new System.Windows.Forms.Button();
            this.groupBox_search = new System.Windows.Forms.GroupBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listView_employee = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_exit = new System.Windows.Forms.Button();
            this.groupBox_search.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone Number";
            // 
            // tb_employee_id
            // 
            this.tb_employee_id.Location = new System.Drawing.Point(65, 49);
            this.tb_employee_id.Name = "tb_employee_id";
            this.tb_employee_id.Size = new System.Drawing.Size(136, 22);
            this.tb_employee_id.TabIndex = 3;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(65, 108);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(136, 22);
            this.tb_name.TabIndex = 4;
            // 
            // maskedTextBox_phone_no
            // 
            this.maskedTextBox_phone_no.Location = new System.Drawing.Point(65, 168);
            this.maskedTextBox_phone_no.Mask = "(999) 000-0000";
            this.maskedTextBox_phone_no.Name = "maskedTextBox_phone_no";
            this.maskedTextBox_phone_no.Size = new System.Drawing.Size(136, 22);
            this.maskedTextBox_phone_no.TabIndex = 5;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(269, 50);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(103, 55);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "&Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_list
            // 
            this.btn_list.Location = new System.Drawing.Point(269, 135);
            this.btn_list.Name = "btn_list";
            this.btn_list.Size = new System.Drawing.Size(103, 55);
            this.btn_list.TabIndex = 7;
            this.btn_list.Text = "&List";
            this.btn_list.UseVisualStyleBackColor = true;
            this.btn_list.Click += new System.EventHandler(this.btn_list_Click);
            // 
            // groupBox_search
            // 
            this.groupBox_search.Controls.Add(this.btn_search);
            this.groupBox_search.Controls.Add(this.tb_search);
            this.groupBox_search.Controls.Add(this.label4);
            this.groupBox_search.Location = new System.Drawing.Point(462, 28);
            this.groupBox_search.Name = "groupBox_search";
            this.groupBox_search.Size = new System.Drawing.Size(180, 162);
            this.groupBox_search.TabIndex = 8;
            this.groupBox_search.TabStop = false;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(39, 90);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(103, 55);
            this.btn_search.TabIndex = 9;
            this.btn_search.Text = "S&earch";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(22, 48);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(136, 22);
            this.tb_search.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Enter Employee ID";
            // 
            // listView_employee
            // 
            this.listView_employee.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView_employee.GridLines = true;
            this.listView_employee.HideSelection = false;
            this.listView_employee.Location = new System.Drawing.Point(65, 217);
            this.listView_employee.Name = "listView_employee";
            this.listView_employee.Size = new System.Drawing.Size(577, 143);
            this.listView_employee.TabIndex = 9;
            this.listView_employee.UseCompatibleStateImageBehavior = false;
            this.listView_employee.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Employee ID";
            this.columnHeader1.Width = 163;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 217;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Phone Number";
            this.columnHeader3.Width = 191;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(301, 375);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(103, 38);
            this.btn_exit.TabIndex = 10;
            this.btn_exit.Text = "E&xit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 424);
            this.ControlBox = false;
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.listView_employee);
            this.Controls.Add(this.groupBox_search);
            this.Controls.Add(this.btn_list);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.maskedTextBox_phone_no);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.tb_employee_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Form";
            this.groupBox_search.ResumeLayout(false);
            this.groupBox_search.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_employee_id;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_phone_no;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_list;
        private System.Windows.Forms.GroupBox groupBox_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listView_employee;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btn_exit;
    }
}