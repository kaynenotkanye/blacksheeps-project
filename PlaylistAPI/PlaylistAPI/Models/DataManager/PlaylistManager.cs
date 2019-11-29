using PlaylistAPI.Models.Repository;
using System.Collections.Generic;
using System.Linq;

namespace PlaylistAPI.Models.DataManager
{
    public class PlaylistManager: IDataRepository<Playlist, int>
    {
        PlaylistContext _context;
        public PlaylistManager(PlaylistContext context)
        {
            _context = context;
        }

        public Playlist Get(int id)
        {
            return _context.Playlists.FirstOrDefault(b => b.Id == id);
        }

        public IEnumerable<Playlist> GetAll()
        {
            return _context.Playlists.ToList();
        }

        public int Add(Playlist playlist)
        {
            _context.Playlists.Add(playlist);
            int id = _context.SaveChanges();
            return id;
        }

        public int Delete(int id)
        {

            var playlist = _context.Playlists.FirstOrDefault(b => b.Id == id);
            if (playlist != null)
            {
                _context.Playlists.Remove(playlist);
                _context.SaveChanges();
            }
            return id;
        }

        public int Update(int id, Playlist item)
        {
            var playlist = _context.Playlists.Find(id);
            if (playlist != null)
            {
                playlist.Artist = item.Artist;
                playlist.Song = item.Song;

                _context.SaveChanges();
            }
            return id;
        }
    }
}
