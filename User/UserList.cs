using System.Collections.Generic;

namespace User
{
    public sealed class UserList
    {
        private static UserList instance = null;
        public List<User> Users = new List<User>();

        private static readonly object padlock = new object();

        UserList()
        {
            //initiate the list here to prevent null excpetion when accessing the list and to control the list initalization
            Users = new List<User>();
        }

        public static UserList Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new UserList();
                    }
                    return instance;
                }
            }
        }
    }

}
