namespace OnlineCinoteatr.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Podpiska")]
    public partial class Podpiska
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Podpiska()
        {
            UserPodpiskas = new HashSet<UserPodpiska>();
        }

        [Key]
        public int ID_Podpiska { get; set; }

        [Required]
        [StringLength(50)]
        public string NamePodpiska { get; set; }

        public decimal? Price { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserPodpiska> UserPodpiskas { get; set; }
    }
}
