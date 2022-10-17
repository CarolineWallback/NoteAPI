using Microsoft.AspNetCore.Mvc;
using NoteAPI.Data;
using NoteAPI.Models;

namespace NoteAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NoteController : ControllerBase
    {
        private NoteDbContext _dbContext;
        public NoteController(NoteDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public List<Note> GetAllNotes()
        {
            return _dbContext.Notes.ToList();
        }

        [HttpGet("{tag}")]
        public List<Note> GetNotesByTag(string tag)
        {
            var notes = _dbContext.Notes.Where(x => x.Tag.Contains(tag)).ToList();
            return notes;
        }

        // POST api/<NoteController>
        [HttpPost]
        public List<Note> CreateNewNote(Note note)
        {
            _dbContext.Notes.Add(note);
            _dbContext.SaveChanges();
            
            return _dbContext.Notes.ToList();
        }

        // PUT api/<NoteController>/5
        [HttpPut("{id}")]
        public List<Note> EditNote(int id, [FromBody] Note note)
        {
            Note noteToEdit = _dbContext.Notes.Find(id);
            if(noteToEdit != null)
            {
                noteToEdit.Title = note.Title;
                noteToEdit.Content = note.Content;
                noteToEdit.Tag = note.Tag;

                _dbContext.SaveChanges();
            }
            
             return _dbContext.Notes.ToList();
        }

        // DELETE api/<NoteController>/5
        [HttpDelete("{id}")]
        public List<Note> DeleteNote(int id)
        {
            Note note = _dbContext.Notes.Find(id);
            _dbContext.Notes.Remove(note);
            _dbContext.SaveChanges();

            return _dbContext.Notes.ToList();
        }
    }
}
