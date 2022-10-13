using Microsoft.AspNetCore.Mvc;
using NoteAPI.Models;


namespace NoteAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NoteController : ControllerBase
    {
        List<Note> notes = new List<Note>()
        {   
            new Note(0, "Viktigt", "Ät upp din choklad"),
            new Note(1, "Torsdag", "kalas på lekland"),
            new Note(2, "Sommar", "semester vecka 32")
        };

        // GET: api/<NoteController>
        [HttpGet]
        public List<Note> Get()
        {
            return notes;
        }

        // GET api/<NoteController>/5
        [HttpGet("{id}", Name = "Get")]
        public Note Get(int id)
        {
            Note note = notes.Find(f => f.Id== id);
            return note;
        }

        // POST api/<NoteController>
        [HttpPost]
        public List<Note> Post([FromBody] Note note)
        {
            notes.Add(note);
            return notes;
        }

        // PUT api/<NoteController>/5
        [HttpPut("{id}")]
        public List<Note> Put(int id, [FromBody] Note note)
        {
            Note noteToEdit = notes.Find(f => f.Id== id);
            int index = notes.IndexOf(note);

            notes[index].Title = note.Title;
            notes[index].Content = note.Content;

            return notes;
            
        }

        // DELETE api/<NoteController>/5
        [HttpDelete("{id}")]
        public List<Note> Delete(int id)
        {
            Note note = notes.Find(f => f.Id == id);
            notes.Remove(note);
            return notes;
        }
    }
}
