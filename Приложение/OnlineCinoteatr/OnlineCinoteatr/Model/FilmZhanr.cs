namespace OnlineCinoteatr.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FilmZhanr")]
    public partial class FilmZhanr
    {
        [Key]
        public int ID_FilmZhanr { get; set; }

        public int ID_Filma { get; set; }

        public int ID_Zhanra { get; set; }

        public virtual Film Film { get; set; }

        public virtual Zhanr Zhanr { get; set; }
    }
}
