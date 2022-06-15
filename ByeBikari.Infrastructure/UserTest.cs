using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ByeBikari.Infrastructure
{
    [Table(name: "UserTest", Schema = "dbo")]
    public class UserTest
    {
        [Column("Id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(length: 100)]
        public string Name { get; set; }
        [Required]
        [MaxLength(length: 100)]
        public string SurName { get; set; }
        [Required]
        [MaxLength(length: 100)]
        public string UserName { get; set; }
        [Required]
        [MaxLength(length: 100)]
        public string PassWord { get; set; }
        [Required]
        [MaxLength(length: 100)]
        public string Emailaddress { get; set; }
        [Required]
        [MaxLength(length: 100)]
        public string TestProp { get; set; }
        [Required]
        [MaxLength(length: 100)]
        public string TestProp2 { get; set; }
    }
}
