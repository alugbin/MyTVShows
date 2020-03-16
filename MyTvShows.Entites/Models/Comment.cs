using System;

namespace MyTvShows.Entites.Models
{
    public class Comment : BaseModel
    {
        public string By { get; set; }
        public string Text { get; set; }

        public int Rating { get; set; }
        public Guid EpisodeId { get; set; }
         
    }
}