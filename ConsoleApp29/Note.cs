namespace ConsoleApp29
{
    internal class Note
    {
        public string Name { get; set; }
        public string Text { get; set; }
        public string Date { get; set; }
        public List<string> Tags { get; set; }
        public Note()
        {

        }

        public Note(string title, string text, List<string> tags)
        {
            Name = title;
            Text = text;
            Date = DateTime.Now.ToString();
            Tags = tags;
        }

        public override string ToString()
        {
            string tags = string.Join(", ", Tags);
            return $"Name: {Name} Text: {Text} Creation date: {Date} Tags: {tags}";
        }
    }
    public class NotesController
    {
        private List<Note> notes;

        public NotesController()
        {
            notes = new List<Note>();
        }
        public void SaveToFile(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (Note note in notes)
                {
                    writer.WriteLine(note.Name);
                    writer.WriteLine(note.Text);
                    writer.WriteLine(note.Date.ToString());
                    writer.WriteLine(string.Join(",", note.Tags));
                }
            }
        }

        public void LoadFromFile(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    Note note = new Note();
                    note.Name = reader.ReadLine();
                    note.Text = reader.ReadLine();
                    note.Date = reader.ReadLine();
                    string tagsStr = reader.ReadLine();
                    note.Tags = tagsStr.Split(',').Select(t => t.Trim()).ToList();

                    notes.Add(note);
                }
            }
        }
        public void AddNote()
        {
            Note note = new Note();
            Console.WriteLine("Enter name:");
            note.Name = Console.ReadLine();
            Console.WriteLine("Enter text:");
            note.Text = Console.ReadLine();
            Console.WriteLine("Enter tags:");
            string tagsStr = Console.ReadLine();
            List<string> tags = tagsStr.Split(',').Select(t => t.Trim()).ToList();
            note.Tags = tags;
            note.Date = DateTime.Now.ToString();
            notes.Add(note);
        }

        public void ShowNotes()
        {
            Console.WriteLine("Notes:");
            foreach (Note note in notes)
            {
                Console.WriteLine(note.ToString());
            }
        } 
    }
}
