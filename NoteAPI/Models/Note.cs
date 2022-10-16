using System.ComponentModel.DataAnnotations;

namespace NoteAPI.Models
{
    public class Note
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        //public Tag Tags { get; set; }
        public Note()
        {

        }
        public Note(int id, string title, string content)
        {
            Id = id;
            Title = title;
            Content = content;
      
        }

       


    }
}
