namespace OnlineCinoteatr.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Film")]
    public partial class Film
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Film()
        {
            FilmActors = new HashSet<FilmActor>();
            FilmBuilders = new HashSet<FilmBuilder>();
            FilmZhanrs = new HashSet<FilmZhanr>();
            ViewsFilmsUsers = new HashSet<ViewsFilmsUser>();
        }

        [Key]
        public int ID_Filma { get; set; }

        [Required]
        [StringLength(100)]
        public string FilmName { get; set; }

        [Column(TypeName = "date")]
        public DateTime DataVihoda { get; set; }

        [Required]
        [StringLength(50)]
        public string Country { get; set; }

        [Required]
        [StringLength(5)]
        public string AgeRestriction { get; set; }

        [Required]
        [StringLength(1000)]
        public string FilmDescription { get; set; }

        [Required]
        [StringLength(25)]
        public string Repertuar { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FilmActor> FilmActors { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FilmBuilder> FilmBuilders { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FilmZhanr> FilmZhanrs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ViewsFilmsUser> ViewsFilmsUsers { get; set; }
    }
}
