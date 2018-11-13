using System.Collections.Generic;
using System.Linq;

namespace User
{
    public class User
    {
        protected string Name { get; set; }
        protected List<User> Users { get { return UserList.Instance.Users; } }

        public List<User> GetUserList()
        {
            return Users;
        }

        public void Add(string name)
        {
            this.Name = name;
            Users.Add(this);
        }

        public int GetUsersCount()
        {
            return Users.Count;
        }

        public string allUsers()
        {
            return string.Join(", ", Users.Select(z => z.Name));
        }
    }

}
