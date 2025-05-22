string currentDirectory = Directory.GetCurrentDirectory();
Console.WriteLine(currentDirectory);

#region DirectoryManipulation - Directory
string relativePath = @"..\..\..\";

string absolutePath = "C:\\Users\\code\\source\\repos\\C-Advanced\\ClassWork\\Class09\\FileSystem\\bin\\Debug\\net8.0";
Console.WriteLine($"Absolute Path: {absolutePath}");

Console.WriteLine("====== Creating new Directory ======");
bool ifDemoFolderExists = Directory.Exists(relativePath + @"DemoFolder");
bool ifDemoFolderExistsString = Directory.Exists(absolutePath + @"DemoFolder");

Console.WriteLine($"Does DemoFolder exists: {ifDemoFolderExists}");
Console.WriteLine($"Does DemoFolder AbsolutePath exists: {ifDemoFolderExistsString}");


string demoFolderPath = relativePath + @"DemoFolder";
Console.WriteLine($"DemoFolder exists before: {Directory.Exists(demoFolderPath)}");

if (!Directory.Exists(demoFolderPath))
{
    Directory.CreateDirectory(demoFolderPath);
    Console.WriteLine("DemoFolder created.");
}

Console.WriteLine($"Does DemoFolder exsists after: {Directory.Exists(demoFolderPath)}");

//Console.WriteLine("Press any key to delete the folder!");
//if (Directory.Exists(demoFolderPath))
//{
//    Directory.Delete(demoFolderPath);
//    Console.ForegroundColor = ConsoleColor.Red;
//    Console.WriteLine("DemoFolder was deleted");
//    Console.ReadLine();

//}
//else
//{
//    Console.WriteLine($"DemoFolder does not exists");
//}
//Console.ReadLine();

#endregion

Console.WriteLine(" ");
Console.WriteLine("=================================");
Console.WriteLine(" ");
#region FileManipulation - File

Console.ReadLine();


string folderPath = relativePath + @"DemoFolder_1\";
string filePath = folderPath + @"demo.txt";
if (!Directory.Exists(folderPath))
{
    Directory.CreateDirectory(folderPath);
    Console.WriteLine("A new folder has been created");
}

// File Create
if (!File.Exists(folderPath + @"demo.txt"))
{
    File.Create(folderPath + @"demo.txt").Close();
    Console.WriteLine("A file was Created");
}

//Console.ReadLine();
// File Delete
//if (File.Exists(folderPath + @"demo.txt"))
//{
//    File.Delete(folderPath + @"demo.txt");
//    Console.WriteLine("A file was Deleted");
//}


// Write in file
if(File.Exists(folderPath + @"demo.txt"))
{
    File.WriteAllText(filePath, "Hello there we are learning how to insert text in file and it is awesome!");
    Console.WriteLine("Successfuly written in a file");
}

//Read from file

if (File.Exists(filePath))
{
    string content = File.ReadAllText(filePath);
    Console.WriteLine("This content comes from a file.");
    Console.WriteLine(content);
}

#endregion