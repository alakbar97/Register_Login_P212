using System;
using System.Windows.Forms;

namespace Register_Login_P212
{
    public partial class BlogForm : Form
    {
        public User user { get; set; }
        public BlogForm()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(tbx_Title.Text) || !String.IsNullOrWhiteSpace(rtbx_Body.Text))
            {
                Blog blog = new Blog();
                blog.Body = rtbx_Body.Text;
                blog.Title = tbx_Title.Text;
                blog.Author = user.UserName;
                Database database = new Database();
                database.AddBlog(blog);
                MessageBox.Show("Blog Added");
            }
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            AllBlogs allBlogs = new AllBlogs();
            allBlogs.ShowDialog();
        }
    }
}
