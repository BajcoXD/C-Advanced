using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Entities.Models
{
    public static class UserDatabase
    {
        public static List<User> users = new List<User>
        {
             new User(1, "Alice", 25),
             new User(2, "Bob", 30),
             new User(3, "Charlie", 25)
        };
        public static User SearchById(int id)
        {
            return users.FirstOrDefault(u => u.Id == id);
        }
        public static List<User> SearchByName(string name)
        {
            return users.Where(u => u.Name.Equals(name, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public static List<User> SearchByAge(int age)
        {
            return users.Where(u => u.Age == age).ToList();
        }

        public static void PrintUsers(List<User> users)
        {
            if (users.Count == 0)
            {
                Console.WriteLine("No users found.");
            }
            else
            {
                foreach (var user in users)
                {
                    Console.WriteLine(user);
                }
            }
        }

    }
}
