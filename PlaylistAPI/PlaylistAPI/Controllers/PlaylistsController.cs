
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PlaylistAPI.Models.Repository;
using PlaylistModel = PlaylistAPI.Models;

namespace PlaylistAPI.Controllers
{
    [Route("api/[controller]")]
    public class PlaylistsController : Controller
    {
        private IDataRepository<PlaylistModel.Playlist, int> _iRepo;
        public PlaylistsController(IDataRepository<PlaylistModel.Playlist, int> repo)
        {
            _iRepo = repo;
        }

        // GET: api/Playlists
        [HttpGet]
        public IEnumerable<PlaylistModel.Playlist> Get()
        {
            return _iRepo.GetAll();
        }

        // GET api/Playlists/5
        [HttpGet("{id}")]
        public PlaylistModel.Playlist Get(int id)
        {
            return _iRepo.Get(id);
        }

        // POST api/Playlists
        [HttpPost]
        public int Post([FromBody]PlaylistModel.Playlist playlist)
        {
            return _iRepo.Add(playlist);
        }

        // POST api/playlists
        [HttpPut]
        public int Put([FromBody]PlaylistModel.Playlist playlist)
        {
            return _iRepo.Update(playlist.Id, playlist);
        }

        // DELETE api/playlists/5
        [HttpDelete("{id}")]
        public int Delete(int id)
        {
            return _iRepo.Delete(id);
        }
    }
}
