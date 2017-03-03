namespace Renova.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class asistencia
    {
        [Key]
        public int IDAsistencia { get; set; }

        public int IDAlumno { get; set; }

        public byte? A1 { get; set; }

        public byte? A2 { get; set; }

        public byte? A3 { get; set; }

        public byte? A4 { get; set; }

        public byte? A5 { get; set; }

        public byte? A6 { get; set; }

        public byte? A7 { get; set; }

        public byte? A8 { get; set; }

        public byte? A9 { get; set; }

        public byte? A10 { get; set; }

        [StringLength(55)]
        public string estado { get; set; }

        public virtual alumno alumno { get; set; }
    }
}
