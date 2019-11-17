namespace Register_Login_P212
{
    partial class LoginForm
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
            this.tbx_Email = new System.Windows.Forms.TextBox();
            this.tbx_Password = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            // 
            // tbx_Email
            // 
            this.tbx_Email.Location = new System.Drawing.Point(186, 106);
            this.tbx_Email.Name = "tbx_Email";
            this.tbx_Email.Size = new System.Drawing.Size(100, 20);
            this.tbx_Email.TabIndex = 1;
            // 
            // tbx_Password
            // 
            this.tbx_Password.Location = new System.Drawing.Point(186, 192);
            this.tbx_Password.Name = "tbx_Password";
            this.tbx_Password.Size = new System.Drawing.Size(100, 20);
            this.tbx_Password.TabIndex = 3;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(183, 159);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(53, 13);
            this.Password.TabIndex = 2;
            this.Password.Text = "Password";
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(186, 263);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(75, 23);
            this.btn_Login.TabIndex = 4;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.tbx_Password);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.tbx_Email);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_Email;
        private System.Windows.Forms.TextBox tbx_Password;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Button btn_Login;
    }
}