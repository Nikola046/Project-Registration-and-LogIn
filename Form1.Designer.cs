
namespace Registration_and_login
{
    partial class Form1
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
            this.tbusername = new System.Windows.Forms.TextBox();
            this.tbpassword = new System.Windows.Forms.TextBox();
            this.tbconfirmpassword = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnregister = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnbacktologin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "GET STARTED";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Confirm password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 399);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Already Have an Account ?";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // tbusername
            // 
            this.tbusername.BackColor = System.Drawing.Color.Gainsboro;
            this.tbusername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbusername.Location = new System.Drawing.Point(16, 87);
            this.tbusername.Name = "tbusername";
            this.tbusername.Size = new System.Drawing.Size(300, 20);
            this.tbusername.TabIndex = 4;
            this.tbusername.TextChanged += new System.EventHandler(this.tbusername_TextChanged);
            // 
            // tbpassword
            // 
            this.tbpassword.BackColor = System.Drawing.Color.Gainsboro;
            this.tbpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbpassword.Location = new System.Drawing.Point(16, 152);
            this.tbpassword.Name = "tbpassword";
            this.tbpassword.PasswordChar = '*';
            this.tbpassword.Size = new System.Drawing.Size(300, 20);
            this.tbpassword.TabIndex = 5;
            // 
            // tbconfirmpassword
            // 
            this.tbconfirmpassword.BackColor = System.Drawing.Color.Gainsboro;
            this.tbconfirmpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbconfirmpassword.Location = new System.Drawing.Point(16, 212);
            this.tbconfirmpassword.Name = "tbconfirmpassword";
            this.tbconfirmpassword.PasswordChar = '*';
            this.tbconfirmpassword.Size = new System.Drawing.Size(300, 20);
            this.tbconfirmpassword.TabIndex = 6;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(214, 250);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(102, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnregister
            // 
            this.btnregister.BackColor = System.Drawing.Color.Red;
            this.btnregister.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregister.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnregister.Location = new System.Drawing.Point(98, 293);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(150, 39);
            this.btnregister.TabIndex = 8;
            this.btnregister.Text = "REGISTER";
            this.btnregister.UseVisualStyleBackColor = false;
            this.btnregister.Click += new System.EventHandler(this.btnregister_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnclear.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.ForeColor = System.Drawing.Color.Red;
            this.btnclear.Location = new System.Drawing.Point(98, 355);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(150, 30);
            this.btnclear.TabIndex = 9;
            this.btnclear.Text = "CLEAR";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnbacktologin
            // 
            this.btnbacktologin.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnbacktologin.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbacktologin.ForeColor = System.Drawing.Color.Red;
            this.btnbacktologin.Location = new System.Drawing.Point(16, 428);
            this.btnbacktologin.Name = "btnbacktologin";
            this.btnbacktologin.Size = new System.Drawing.Size(119, 35);
            this.btnbacktologin.TabIndex = 10;
            this.btnbacktologin.Text = "Go to LOGIN";
            this.btnbacktologin.UseVisualStyleBackColor = false;
            this.btnbacktologin.Click += new System.EventHandler(this.btnbacktologin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 475);
            this.Controls.Add(this.btnbacktologin);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnregister);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.tbconfirmpassword);
            this.Controls.Add(this.tbpassword);
            this.Controls.Add(this.tbusername);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbusername;
        private System.Windows.Forms.TextBox tbpassword;
        private System.Windows.Forms.TextBox tbconfirmpassword;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnregister;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnbacktologin;
    }
}

