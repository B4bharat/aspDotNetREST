﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MusicApi.Data;
using MusicApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MusicApi.Controllers
{
    [Route("api/[controller]")]
    public class SongsController : Controller
    {
        private ApiDbContext _dbContext;

        public SongsController(ApiDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<Song> Get()
        {
            return _dbContext.Songs;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Song Get(int id)
        {
            var song = _dbContext.Songs.Find(id);
            return song;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Song song)
        {
            _dbContext.Songs.Add(song);
            _dbContext.SaveChanges();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Song songObj)
        {
            var song = _dbContext.Songs.Find(id);
            song.Title = songObj.Title;
            song.Language = songObj.Language;

            _dbContext.SaveChanges();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var song = _dbContext.Songs.Find(id);
            _dbContext.Songs.Remove(song);
            _dbContext.SaveChanges();
        }
    }
}

