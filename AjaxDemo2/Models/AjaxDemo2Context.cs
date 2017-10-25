using Microsoft.EntityFrameworkCore;

namespace AjaxDemo2.Models
{
    public class AjaxDemo2Context : DbContext
    {

        public AjaxDemo2Context()
        {

        }
        public virtual DbSet<Destination> Destinations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder
                .UseMySql(@"Server=localhost;Port=8889;database=ajax2demo;uid=root;pwd=root;");

        public AjaxDemo2Context(DbContextOptions<AjaxDemo2Context> options)
        : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }

}