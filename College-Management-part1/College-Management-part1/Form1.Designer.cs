namespace College_Management_part1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label7 = new Label();
            label5 = new Label();
            txtStudentId = new TextBox();
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtAge = new TextBox();
            btnCheck = new Button();
            btnRegister = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(334, 70);
            label1.Name = "label1";
            label1.Size = new Size(114, 15);
            label1.TabIndex = 0;
            label1.Text = "Student Registration";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(249, 180);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 1;
            label2.Text = "Nmae:";
            label2.Click += this.label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(249, 214);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 2;
            label3.Text = "Email";
            label3.Click += this.label3_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(249, 143);
            label7.Name = "label7";
            label7.Size = new Size(65, 15);
            label7.TabIndex = 3;
            label7.Text = "Student ID:";
            label7.Click += this.label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(249, 246);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 4;
            label5.Text = "Age:";
            label5.Click += label5_Click;
            // 
            // txtStudentId
            // 
            txtStudentId.Location = new Point(416, 140);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(100, 23);
            txtStudentId.TabIndex = 5;
            txtStudentId.TextChanged += txtStudentId_TextChanged;
            // 
            // txtName
            // 
            txtName.Location = new Point(416, 169);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 6;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(416, 206);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 7;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(416, 238);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(100, 23);
            txtAge.TabIndex = 8;
            txtAge.TextChanged += txtAge_TextChanged;
            // 
            // btnCheck
            // 
            btnCheck.Location = new Point(226, 335);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(136, 34);
            btnCheck.TabIndex = 9;
            btnCheck.Text = "Check Student";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(405, 335);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(149, 34);
            btnRegister.TabIndex = 10;
            btnRegister.Text = "Register Student";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(249, 302);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 11;
            label4.Text = "Result:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(btnRegister);
            Controls.Add(btnCheck);
            Controls.Add(txtAge);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(txtStudentId);
            Controls.Add(label5);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label7;
        private Label label5;
        private TextBox txtStudentId;
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtAge;
        private Button btnCheck;
        private Button btnRegister;
        private Label label4;
    }
}
