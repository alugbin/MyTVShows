using System;
using System.Collections.Generic;
using System.Text;

namespace MyTvShows.Entites.Models
{
    public class Season : BaseModel
    {
        public string Title { get; set; }

        public string CoverImageUrl { get; set; }

        public Guid TvShowId { get; set; }

        public TvShow TvShow { get; set; }

        public ICollection<Episode> Episodes { get; set; }
    }
}
