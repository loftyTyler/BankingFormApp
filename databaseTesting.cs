namespace BankingFormApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("databaseTesting")]
    public partial class databaseTesting
    {
        [Key]
        [StringLength(50)]
        public string name { get; set; }

        [Required]
        [StringLength(50)]
        public string password { get; set; }

        [StringLength(50)]
        public string fullName { get; set; }

        [Column(TypeName = "money")]
        public decimal? accountBalance { get; set; }
    }
}
