using System.Collections;
using System.Web.Helpers;

namespace Register_Login_P212
{
    class Database
    {
        private static readonly ArrayList UserList;
        private static readonly ArrayList BlogList;
        static Database()
        {
            UserList = new ArrayList();
            BlogList = new ArrayList();
        }

        public void AddUser(User item)
        {
            UserList.Add(item);
        }

        public bool CheckUser(string email, string password)
        {
            bool isTrue = false;
            foreach (User item in UserList)
            {
                if (item.Email == email && Crypto.VerifyHashedPassword(item.Password, password))
                {
                    isTrue = true;
                    break;
                }
            }
            return isTrue;
        }

        public User GetUser(string email, string password)
        {
            User user = null;
            foreach (User item in UserList)
            {
                if (item.Email == email && Crypto.VerifyHashedPassword(item.Password, password))
                {
                    user = item;
                    break;
                }
            }
            return user;
        }

        public void AddBlog(Blog blog)
        {
            BlogList.Add(blog);
        }

        public Blog[] GetAllBlogs()
        {
            return (Blog[])BlogList.ToArray(typeof(Blog)); 
        }
    }
}
