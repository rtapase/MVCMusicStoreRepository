using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcMusicStore.Models
{
    public class Album
    {
                 
        public int ArtistId { get; set; }
        public virtual Artist Artist { get; set; }
        
        public int GenreId { get; set; } 
        public virtual Genre Genre { get; set; }

        public int AlbumId { get; set; }
        public string Title { get; set; }
        public string AlbumArtUrl { get; set; }
        public decimal Price { get; set; }
    }
}