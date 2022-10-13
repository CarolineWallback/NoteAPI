namespace NoteAPI.Models
{
    public class CreateNoteViewModel
    {
        public int NoteId { get; set; }
        public string NoteName { get; set; }
        public string NoteContent { get; set; }
        public List<string> Tags { get; set; }

        
    }
}
