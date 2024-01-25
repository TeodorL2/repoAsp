using examen.Models;
using Microsoft.EntityFrameworkCore;
using examen.Models;

namespace examen.Data
{
    public class ExamenContext : DbContext
    {

        public ExamenContext(DbContextOptions<ExamenContext> options) : base(options) { }

        public DbSet<Eveniment> Evenimente { get; set; }
        public DbSet<Participant> Participanti { get; set; }
        public DbSet<EvenPart> EvenParts { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EvenPart>().HasKey(ep => new { ep.EvenimentId, ep.ParticipantId });

            modelBuilder.Entity<EvenPart>()
                        .HasOne(ep => ep.Eveniment)
                        .WithMany(e => e.EvenPart)
                        .HasForeignKey(ep => ep.EvenimentId);

            modelBuilder.Entity<EvenPart>()
                        .HasOne(ep => ep.Participant)
                        .WithMany(p => p.EvenPart)
                        .HasForeignKey(ep => ep.ParticipantId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
