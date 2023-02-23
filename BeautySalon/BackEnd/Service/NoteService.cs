using BeautySalon.BackEnd.Data.Configurations;
using BeautySalon.BackEnd.Domain.Entities;
using Newtonsoft.Json;

namespace BeautySalon.BackEnd.Service
{
    public class NoteService
    {
       static public async Task CreateNote(Note note)
        {
            var notes = await File.ReadAllTextAsync(Configurations.notes);
            if (notes == "")
            {
                List<Note> cls = new List<Note>();
                cls.Add(note);
                await File.WriteAllTextAsync(Configurations.notes, JsonConvert.SerializeObject(cls));
            }
            else
            {
                List<Note> nots = JsonConvert.DeserializeObject<List<Note>>(notes);
                nots.Add(note);
                await File.WriteAllTextAsync(Configurations.notes, JsonConvert.SerializeObject(nots));
            }
        }
        static public async Task<List<Note>> GetAllNotes()
        {
            var notes = await File.ReadAllTextAsync(Configurations.notes);
            List<Note>? nots = JsonConvert.DeserializeObject<List<Note>>(notes);
            return nots;
        }
    }
}
