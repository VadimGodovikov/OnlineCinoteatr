namespace OnlineCinoteatr.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FilmBuilder")]
    public partial class FilmBuilder
    {
        [Key]
        public int ID_FilmBuilder { get; set; }

        public int ID_Filma { get; set; }

        public int ID_Builder { get; set; }

        public virtual Builder Builder { get; set; }

        public virtual Film Film { get; set; }
    }
}
