namespace WcfService2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Gatunek")]
    public partial class Gatunek
    {
        [Key]
        public int Id_gatunek { get; set; }

        [Required]
        [StringLength(20)]
        public string Nazwa { get; set; }
    }
}
