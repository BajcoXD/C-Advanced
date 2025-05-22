
    Console.WriteLine("Welcome to Online Classes System");
    Console.Write("Please enter your name: ");
    string userName = Console.ReadLine();

    CheckUserPermissions(userName);


static void CheckUserPermissions(string name)
{
    // Case-insensitive comparison
    string lowerName = name.ToLower();

    if (lowerName == "bob" || lowerName == "jill" || lowerName == "alice")
    {
        Console.WriteLine($"{name} - User Found.");
        Console.WriteLine("Sending Email to Administration...");
        SendEmailToAdmin(name);
        Console.WriteLine("Email Sent.");
        Console.WriteLine("Warning Alarm Started...");
        TriggerAlarm();
        Console.WriteLine("Logging out.");
    }
    else
    {
        Console.WriteLine($"Welcome {name}.");
    }
}

static void SendEmailToAdmin(string restrictedUser)
{
    // In a real application, you would implement actual email sending logic here
    // This is just a simulation
    try
    {
        // Simulate email sending
        System.Threading.Thread.Sleep(1000); // Delay to simulate email sending
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error sending email: {ex.Message}");
    }
}

static void TriggerAlarm()
{
    try
    {
        // Beep alarm - will work on Windows
        for (int i = 0; i < 3; i++)
        {
            Console.Beep(1000, 500); // Frequency 1000Hz, duration 500ms
            System.Threading.Thread.Sleep(300);
        }
    }
    catch (Exception)
    {
        // If Console.Beep isn't supported (like on some Linux/macOS)
        Console.WriteLine("[ALARM SOUND]");
    }
}