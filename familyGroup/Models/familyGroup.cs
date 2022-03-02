namespace familyGroup.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("familyGroup")]
    public partial class familyGroup
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Required]
        [StringLength(150)]
        public string name { get; set; }

        [Required]
        [StringLength(150)]
        public string last_name { get; set; }

        public int document_number { get; set; }

        public byte? gender { get; set; }

        [StringLength(50)]
        public string relationship { get; set; }

        public int age { get; set; }

        public byte? younger { get; set; }

        [Required]
        [StringLength(50)]
        public string user_name { get; set; }

        [Column(TypeName = "date")]
        public DateTime? birthday { get; set; }

        public DateTime? created_at { get; set; }

        public int? user_id { get; set; }

        public DateTime? updated_at { get; set; }
    }
}
