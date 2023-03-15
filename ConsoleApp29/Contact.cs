namespace ConsoleApp29
{
    internal class Contact
    {
        public string Name { get; set; }
        public string Number { get; set; }
        public string SecondNum { get; set; }
        public string Email { get; set; }
        public string Other { get; set; }
        public Contact()
        {

        }

        public Contact(string name, string num, string num2, string email, string info)
        {
            Name = name;
            Number = num;
            SecondNum = num2;
            Email = email;
            Other = info;
        }

        public override string ToString()
        {
            return $"Name: {Name} Number: {Number}Second number of phone: {SecondNum}Email: {Email} Other: {Other}";
        }
    }
    public class ContactController
    {
        private List<Contact> contacts;

        public ContactController()
        {
            contacts = new List<Contact>();
        }

        public void AddContact()
        {
            Contact contact = new Contact();
            Console.WriteLine("Enter name:");
            contact.Name = Console.ReadLine();
            Console.WriteLine("Enter number:");
            contact.Number = Console.ReadLine();
            Console.WriteLine("Enter 2 number:");
            contact.SecondNum = Console.ReadLine();
            Console.WriteLine("Enter email:");
            contact.Email = Console.ReadLine();
            Console.WriteLine("Enter other:");
            contact.Other = Console.ReadLine();

            contacts.Add(contact);
        }

        public void ShowContacts()
        {
            Console.WriteLine("Contacts:");
            foreach (Contact item in contacts)
            {
                Console.WriteLine(item.ToString());
            }
        }
        public void ReadFromFile(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    Contact contact = new Contact();
                    contact.Name = reader.ReadLine();
                    contact.Number = reader.ReadLine();
                    contact.SecondNum = reader.ReadLine();
                    contact.Email = reader.ReadLine();
                    contact.Other = reader.ReadLine();
                    contacts.Add(contact);
                }
            }
        }
        public void SaveToFile(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (Contact item in contacts)
                {
                    writer.WriteLine(item.Name);
                    writer.WriteLine(item.Number);
                    writer.WriteLine(item.SecondNum);
                    writer.WriteLine(item.Email);
                    writer.WriteLine(item.Other);
                }
            }
        }
    }
}
