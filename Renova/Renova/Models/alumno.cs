namespace Renova.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("alumnos")]
    public partial class alumno
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public alumno()
        {
            asistencias = new HashSet<asistencia>();
        }

        [Key]
        public int IDAlumno { get; set; }

        [Required]
        [StringLength(60)]
        public string nombre { get; set; }

        [Required]
        [StringLength(100)]
        public string apellidos { get; set; }

        [Required]
        [StringLength(75)]
        public string universidad { get; set; }

        [Required]
        [StringLength(100)]
        public string carrera { get; set; }

        public int matricula { get; set; }

        [Required]
        [StringLength(100)]
        public string correo { get; set; }

        public DateTime? fechareg { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<asistencia> asistencias { get; set; }
    }
}
