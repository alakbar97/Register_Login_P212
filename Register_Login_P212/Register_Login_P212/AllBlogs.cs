using System;
using System.Windows.Forms;

namespace Register_Login_P212
{
    public partial class AllBlogs : Form
    {
        public AllBlogs()
        {
            InitializeComponent();
        }

        private void AllBlogs_Load(object sender, EventArgs e)
        {
            Database database = new Database();
            foreach (Blog item in database.GetAllBlogs())
            {
                lbx_Blogs.Items.Add($"{item.Author} {item.Title} {item.Body} \n");
               
            }
        }
    }
}
