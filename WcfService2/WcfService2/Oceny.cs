namespace WcfService2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Oceny")]
    public partial class Oceny
    {
        [Key]
        public int Id_oceny { get; set; }

        [Column("Gry-online.pl")]
        public int Gry_online_pl { get; set; }

        public int Eurogamer { get; set; }

        public int Moja_ocena { get; set; }
    }
}
