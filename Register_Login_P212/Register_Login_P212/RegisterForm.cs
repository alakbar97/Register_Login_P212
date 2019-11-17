using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Helpers;
using System.Windows.Forms;

namespace Register_Login_P212
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            User person = new User();
            if (String.IsNullOrWhiteSpace(tbx_Email.Text)||String.IsNullOrWhiteSpace(tbx_Password.Text)||String.IsNullOrWhiteSpace(tbx_Username.Text))
            {
                MessageBox.Show("Inputs cannot be empty!");
            }
            else
            {
                person.Email = tbx_Email.Text;
                person.UserName = tbx_Username.Text;
                person.Password = Crypto.HashPassword(tbx_Password.Text);

                Database database = new Database();
                database.AddUser(person);
                this.Close();
            }
        }
    }
}
