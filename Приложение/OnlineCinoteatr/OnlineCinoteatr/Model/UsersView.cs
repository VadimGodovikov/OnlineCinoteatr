namespace OnlineCinoteatr.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UsersView
    {
        [Key]
        [Column("Название фильма", Order = 0)]
        [StringLength(100)]
        public string Название_фильма { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Фамилия { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string Имя { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string Логин { get; set; }

        [Key]
        [Column("Дата просмотра", Order = 4, TypeName = "date")]
        public DateTime Дата_просмотра { get; set; }
    }
}
