using app.Models;

Teacher professorJohn = new Teacher("John", 45, "john@university.edu", "Math");

Student alice = new Student("Alice", 20, "alice@student.edu", "Math");
Student bob = new Student("Bob", 22, "bob@student.edu", "Math");
Student charlie = new Student("Charlie", 21, "charlie@student.edu", "Math");

// Subscribe all students
professorJohn.Subscribe(alice);
professorJohn.Subscribe(bob);
professorJohn.Subscribe(charlie);

// Send notification
professorJohn.SendNotification();

// Unsubscribe Alice and Charlie
professorJohn.Unsubscribe(alice);
professorJohn.Unsubscribe(charlie);

// Send notification again
professorJohn.SendNotification();