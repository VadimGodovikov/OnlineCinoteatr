namespace OnlineCinoteatr.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Zhanr")]
    public partial class Zhanr
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Zhanr()
        {
            FilmZhanrs = new HashSet<FilmZhanr>();
        }

        [Key]
        public int ID_Zhanra { get; set; }

        [Required]
        [StringLength(50)]
        public string ZhanrName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FilmZhanr> FilmZhanrs { get; set; }
    }
}
