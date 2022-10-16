using Microsoft.AspNetCore.Mvc;
using NoteAPI.Data;
using NoteAPI.Models;
using System;


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

        // GET: api/<NoteController>
        [HttpGet]
        public List<Note> Get()
        {
            return _dbContext.Notes.ToList();
        }

        // GET api/<NoteController>/5
        [HttpGet("{id}", Name = "Get")]
        public Note Get(int id)
        {
            Note note = _dbContext.Notes.Find(id);
            return note;
        }

        // POST api/<NoteController>
        [HttpPost]
        public List<Note> Post(Note note)
        {
            _dbContext.Notes.Add(note);
            _dbContext.SaveChanges();

            return _dbContext.Notes.ToList();
        }

        // PUT api/<NoteController>/5
        [HttpPut("{id}")]
        public List<Note> Put(int id, [FromBody] Note note)
        {
            Note noteToEdit = _dbContext.Notes.Find(id);
            if(noteToEdit != null)
            {
                noteToEdit.Title = note.Title;
                noteToEdit.Content = note.Content;

                _dbContext.SaveChanges();
            }
            
             return _dbContext.Notes.ToList();
        }

        // DELETE api/<NoteController>/5
        [HttpDelete("{id}")]
        public List<Note> Delete(int id)
        {
            Note note = _dbContext.Notes.Find(id);
            _dbContext.Notes.Remove(note);
            _dbContext.SaveChanges();

            return _dbContext.Notes.ToList();
        }
    }
}
