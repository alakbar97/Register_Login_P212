namespace Register_Login_P212
{
    partial class AllBlogs
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
            this.lbx_Blogs = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbx_Blogs
            // 
            this.lbx_Blogs.FormattingEnabled = true;
            this.lbx_Blogs.Location = new System.Drawing.Point(4, 95);
            this.lbx_Blogs.Name = "lbx_Blogs";
            this.lbx_Blogs.Size = new System.Drawing.Size(657, 329);
            this.lbx_Blogs.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(685, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AllBlogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbx_Blogs);
            this.Name = "AllBlogs";
            this.Text = "AllBlogs";
            this.Load += new System.EventHandler(this.AllBlogs_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbx_Blogs;
        private System.Windows.Forms.Button button1;
    }
}