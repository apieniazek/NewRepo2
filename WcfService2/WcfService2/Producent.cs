namespace WcfService2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Producent")]
    public partial class Producent
    {
        [Key]
        public int Id_producent { get; set; }

        [Required]
        [StringLength(40)]
        public string Nazwa { get; set; }

        [Required]
        [StringLength(40)]
        public string Zalozyciel { get; set; }

        [Column("Rok zalozenia", TypeName = "date")]
        public DateTime Rok_zalozenia { get; set; }
    }
}
