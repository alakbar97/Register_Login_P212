namespace Register_Login_P212
{
    partial class BlogForm
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
            this.tbx_Title = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbx_Body = new System.Windows.Forms.RichTextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Show = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(312, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // tbx_Title
            // 
            this.tbx_Title.Location = new System.Drawing.Point(185, 87);
            this.tbx_Title.Multiline = true;
            this.tbx_Title.Name = "tbx_Title";
            this.tbx_Title.Size = new System.Drawing.Size(338, 29);
            this.tbx_Title.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(312, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Body";
            // 
            // rtbx_Body
            // 
            this.rtbx_Body.Location = new System.Drawing.Point(185, 226);
            this.rtbx_Body.Name = "rtbx_Body";
            this.rtbx_Body.Size = new System.Drawing.Size(338, 171);
            this.rtbx_Body.TabIndex = 3;
            this.rtbx_Body.Text = "";
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(592, 367);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 4;
            this.btn_Add.Text = "Add Article";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Show
            // 
            this.btn_Show.Location = new System.Drawing.Point(592, 295);
            this.btn_Show.Name = "btn_Show";
            this.btn_Show.Size = new System.Drawing.Size(100, 37);
            this.btn_Show.TabIndex = 5;
            this.btn_Show.Text = "Show All Articles";
            this.btn_Show.UseVisualStyleBackColor = true;
            this.btn_Show.Click += new System.EventHandler(this.btn_Show_Click);
            // 
            // BlogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Show);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.rtbx_Body);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbx_Title);
            this.Controls.Add(this.label1);
            this.Name = "BlogForm";
            this.Text = "BlogForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_Title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbx_Body;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Show;
    }
}