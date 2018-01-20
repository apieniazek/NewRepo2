namespace WcfService2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Gry")]
    public partial class Gry
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Tytul { get; set; }

        public int Producent_Id { get; set; }

        public int Gatunek_Id { get; set; }

        [Column(TypeName = "date")]
        public DateTime Rok_wydania { get; set; }

        [Required]
        [StringLength(20)]
        public string Kraj { get; set; }

        public int Platforma { get; set; }

        public int Ocena_Id { get; set; }
    }
}
