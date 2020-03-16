using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyTVShows.DataAccess.Persistence
{
    public class ShowsDbContext : DbContext
    {
        public ShowsDbContext(DbContextOptions options):base(options)
        {

        }
    }
}
