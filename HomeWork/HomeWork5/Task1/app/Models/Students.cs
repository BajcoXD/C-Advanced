using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.Models
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }

        public Student(string name, int age, string email, string subject)
        {
            Name = name;
            Age = age;
            Email = email;
            Subject = subject;
        }

        public void GetNotification(string message)
        {
            Console.WriteLine($"{Name}: Notification from Professor John: {message}");
        }
    }
}
