namespace OnlineCinoteatr.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DeleteUser
    {
        [Key]
        public int ID_DELETED { get; set; }

        [Required]
        [StringLength(50)]
        public string Users_Surname { get; set; }

        [Required]
        [StringLength(50)]
        public string Users_Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Users_Login { get; set; }

        public DateTime? Date_Deleted { get; set; }
    }
}
