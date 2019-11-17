using System;
using System.Windows.Forms;

namespace Register_Login_P212
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            Database database = new Database();
            if (database.CheckUser(tbx_Email.Text, tbx_Password.Text))
            {
                BlogForm blogForm = new BlogForm();
                blogForm.user = database.GetUser(tbx_Email.Text, tbx_Password.Text);
                blogForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Fail");
            }


        }
    }
}
