namespace Register_Login_P212
{
    partial class RegisterForm
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
            this.tbx_Username = new System.Windows.Forms.TextBox();
            this.tbx_Email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_Password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserName";
            // 
            // tbx_Username
            // 
            this.tbx_Username.Location = new System.Drawing.Point(266, 85);
            this.tbx_Username.Name = "tbx_Username";
            this.tbx_Username.Size = new System.Drawing.Size(126, 20);
            this.tbx_Username.TabIndex = 1;
            // 
            // tbx_Email
            // 
            this.tbx_Email.Location = new System.Drawing.Point(266, 152);
            this.tbx_Email.Name = "tbx_Email";
            this.tbx_Email.Size = new System.Drawing.Size(126, 20);
            this.tbx_Email.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email";
            // 
            // tbx_Password
            // 
            this.tbx_Password.Location = new System.Drawing.Point(266, 229);
            this.tbx_Password.Name = "tbx_Password";
            this.tbx_Password.Size = new System.Drawing.Size(126, 20);
            this.tbx_Password.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(266, 288);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(100, 33);
            this.btn_Submit.TabIndex = 6;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.tbx_Password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbx_Email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbx_Username);
            this.Controls.Add(this.label1);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_Username;
        private System.Windows.Forms.TextBox tbx_Email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_Password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Submit;
    }
}