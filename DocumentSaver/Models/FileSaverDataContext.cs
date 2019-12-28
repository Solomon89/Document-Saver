using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentSaver.Models
{
    public class FileSaverDataContext:DbContext
    {
        public DbSet<FileModel> Files { get; set; }
        public FileSaverDataContext(DbContextOptions<FileSaverDataContext> options)
            : base(options)
        { }
    }
}
