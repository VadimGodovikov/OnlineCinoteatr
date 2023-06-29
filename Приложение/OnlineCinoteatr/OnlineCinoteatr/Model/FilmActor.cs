namespace OnlineCinoteatr.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FilmActor")]
    public partial class FilmActor
    {
        [Key]
        public int ID_FilmActor { get; set; }

        public int ID_Filma { get; set; }

        public int ID_Actora { get; set; }

        public virtual Actor Actor { get; set; }

        public virtual Film Film { get; set; }
    }
}
