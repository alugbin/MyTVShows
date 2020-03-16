using System;
using System.Collections.Generic;
using System.Text;

namespace MyTvShows.Entites
{
    public class BaseModel
    {
        public Guid Id { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
    }
}
