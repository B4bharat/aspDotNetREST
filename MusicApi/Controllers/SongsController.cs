using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MusicApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MusicApi.Controllers
{
    [Route("api/[controller]")]
    public class SongsController : Controller
    {
        private static List<Song> songs = new List<Song>()
        {
            new Song(){ Id = 0, Title = "Willow", Language = "English"},
            new Song(){ Id = 1, Title = "Yellow", Language = "English"},
            new Song(){ Id = 2, Title = "Smells Like Teen Spirit", Language = "English"},
        };

        // GET: api/values
        [HttpGet]
        public IEnumerable<Song> Get()
        {
            return songs;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Song song)
        {
            songs.Add(song);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Song song)
        {
            songs[id] = song;
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            songs.RemoveAt(id);
        }
    }
}

