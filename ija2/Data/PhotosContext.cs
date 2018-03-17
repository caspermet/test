using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ija2.Models;

namespace ija2.Data
{
    public class PhotosContext : DbContext
    {
        public PhotosContext(DbContextOptions<PhotosContext> options)
            : base(options)
        { }

        public DbSet<Photos> Photose { get; set; }
    }
}
