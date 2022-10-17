
namespace NoteAPI.Models
{
    public class Note
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Tag { get; set; }

        public Note()
        {

        }
        public Note(int id, string title, string content, string tag)
        {
            Id = id;
            Title = title;
            Content = content;
            Tag = tag;
      
        }

    }
}
