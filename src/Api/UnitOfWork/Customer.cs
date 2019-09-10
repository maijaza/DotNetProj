namespace Api.UnitOfWork
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customer")]
    public partial class Customer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Lname { get; set; }

        public int? Age { get; set; }

        [StringLength(12)]
        public string TelNo { get; set; }

        [StringLength(10)]
        public string CreateBy { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(10)]
        public string UpdateBy { get; set; }

        public DateTime? UpdateDate { get; set; }
    }
}
