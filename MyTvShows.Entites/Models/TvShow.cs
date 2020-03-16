using MyTvShows.Entites.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyTvShows.Entites.Models
{
    public class TvShow : BaseModel
    {
        public string Title { get; set; }
        public string Year { get; set; }
        public string CoverImageUrl { get; set; }

        public TVShowCategory Genre { get; set; }

        public ICollection<Season> Seasons { get; set; }
        
    }
}
