using ConsoleApp29;
Console.WriteLine("Enter choice");
Console.WriteLine("1. Note");
Console.WriteLine("2. Contact");
string num = Console.ReadLine();
if (num == "1")
{
    NotesController controller = new NotesController();

    while (true)
    {
        Console.WriteLine("Enter choice:");
        Console.WriteLine("1. Save to file");
        Console.WriteLine("2. Read from file");
        Console.WriteLine("3. Add note");
        Console.WriteLine("4. Show");
        Console.WriteLine("5. Exit");

        var choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                controller.SaveToFile("notes.txt");
                break;
            case "2":
                controller.LoadFromFile("notes.txt");
                break;
            case "3":
                controller.AddNote();
                break;
            case "4":
                controller.ShowNotes();
                break;
               
            case "5":
                return;
            default: 
                break;
        } 
    }
}
else if (num == "2")
{
    ContactController controller = new ContactController();

    while (true)
    {
        Console.WriteLine("Choose an action:");
        Console.WriteLine("1. Add contact");
        Console.WriteLine("2. Show");
        Console.WriteLine("3. Save to file");
        Console.WriteLine("4. Read from file");
        Console.WriteLine("5. Exit");

        var choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                controller.AddContact();
                break;
            case "2":
                controller.ShowContacts();
                break;
            case "3":
                controller.SaveToFile("contacts.txt");
                break;
            case "4":
                controller.ReadFromFile("contacts.txt");
                break;
            case "5":
                return;
            default: 
                break;
        } 
    }
}
