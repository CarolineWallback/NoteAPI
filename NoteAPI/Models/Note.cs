namespace NoteAPI.Models
{
    public class Note
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        private List<string> Tags { get; set; }

        public Note(int id, string title, string content)
        {
            Id = id;
            Title = title;
            Content = content;
        }

        public Note()
        {

        }


    }
}
