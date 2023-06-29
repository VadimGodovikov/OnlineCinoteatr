namespace OnlineCinoteatr.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ViewsFilmsUser
    {
        [Key]
        public int ID_Views { get; set; }

        public int ID_Filma { get; set; }

        public int ID_Usera { get; set; }

        [Column(TypeName = "date")]
        public DateTime DataProsmotra { get; set; }

        public virtual Film Film { get; set; }

        public virtual User User { get; set; }
    }
}
