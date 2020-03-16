using System;
using System.Collections.Generic;

namespace MyTvShows.Entites.Models
{
    public class Episode : BaseModel
    {
        public string Title { get; set; }
        public string Length { get; set; }
        public string CoverUrl { get; set; }
        public Guid SeasonId { get; set; }
        public Season Season { get; set; }

        public ICollection<Comment> Comments { get; set; }
    }
}