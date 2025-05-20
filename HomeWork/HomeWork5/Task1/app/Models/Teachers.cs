using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.Models
{
    public class Teacher
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }

        // Define delegate and event for notifications
        public delegate void NotificationHandler(string message);
        private event NotificationHandler NotificationEvent;

        public Teacher(string name, int age, string email, string subject)
        {
            Name = name;
            Age = age;
            Email = email;
            Subject = subject;
        }

        // Subscribe method
        public void Subscribe(Student student)
        {
            NotificationEvent += student.GetNotification;
            Console.WriteLine($"{student.Name} subscribed to Professor {Name}'s notifications.");
        }

        // Unsubscribe method
        public void Unsubscribe(Student student)
        {
            NotificationEvent -= student.GetNotification;
            Console.WriteLine($"{student.Name} unsubscribed from Professor {Name}'s notifications.");
        }

        public void SendNotification()
        {
            Console.WriteLine("\nSending notifications....");
            NotificationEvent?.Invoke($"Class for {Subject} will start at 10 AM.");
        }
    }
}
