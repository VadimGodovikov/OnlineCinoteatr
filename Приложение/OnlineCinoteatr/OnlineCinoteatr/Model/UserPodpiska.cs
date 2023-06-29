namespace OnlineCinoteatr.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserPodpiska")]
    public partial class UserPodpiska
    {
        [Key]
        public int ID_UserPodpiska { get; set; }

        public int ID_Usera { get; set; }

        public int ID_Podpiska { get; set; }

        [StringLength(50)]
        public string SrokDeistvia { get; set; }

        public virtual Podpiska Podpiska { get; set; }

        public virtual User User { get; set; }
    }
}
