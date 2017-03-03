namespace Renova.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class RenoContext : DbContext
    {
        public RenoContext()
            : base("name=RenoContext")
        {
        }

        public virtual DbSet<alumno> alumnos { get; set; }
        public virtual DbSet<asistencia> asistencias { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
