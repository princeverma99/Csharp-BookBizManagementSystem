namespace BookBiz_Management_System.GUI
{
    partial class MISManagerLogin
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
            this.btn_users = new System.Windows.Forms.Button();
            this.btn_employees = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_users
            // 
            this.btn_users.Location = new System.Drawing.Point(178, 145);
            this.btn_users.Name = "btn_users";
            this.btn_users.Size = new System.Drawing.Size(189, 105);
            this.btn_users.TabIndex = 0;
            this.btn_users.Text = "&Users";
            this.btn_users.UseVisualStyleBackColor = true;
            this.btn_users.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_employees
            // 
            this.btn_employees.Location = new System.Drawing.Point(434, 145);
            this.btn_employees.Name = "btn_employees";
            this.btn_employees.Size = new System.Drawing.Size(189, 105);
            this.btn_employees.TabIndex = 1;
            this.btn_employees.Text = "&Employees";
            this.btn_employees.UseVisualStyleBackColor = true;
            this.btn_employees.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(339, 339);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 47);
            this.button3.TabIndex = 2;
            this.button3.Text = "E&xit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please Choose from the following : ";
            // 
            // MISManagerLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_employees);
            this.Controls.Add(this.btn_users);
            this.Name = "MISManagerLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MISManagerLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_users;
        private System.Windows.Forms.Button btn_employees;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
    }
}