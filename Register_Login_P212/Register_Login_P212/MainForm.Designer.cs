﻿namespace Register_Login_P212
{
    partial class MainForm
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
            this.btn_Register = new System.Windows.Forms.Button();
            this.btn_Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Register
            // 
            this.btn_Register.Location = new System.Drawing.Point(226, 266);
            this.btn_Register.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(74, 23);
            this.btn_Register.TabIndex = 0;
            this.btn_Register.Text = "Register";
            this.btn_Register.UseVisualStyleBackColor = true;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(446, 266);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(74, 23);
            this.btn_Login.TabIndex = 1;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.btn_Register);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "MainForm";
            this.Text = "Glad To See You Here";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.Button btn_Login;
    }
}

