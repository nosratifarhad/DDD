using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ByeBikari.InfraDapper.Models.JobSeekerAuthentications
{
    public class JobSeekerAuthentication
    {
        [Column("Id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int Id { get; set; }

        [Column("name")]
        [Required]
        [StringLength(100)]
        public string name{ get; set; }
        [Column("surname")]
        [Required]
        [StringLength(100)]
        public string surname { get; set; }
        [Column("username")]
        [Required]
        [StringLength(100)]
        public string username { get; set; }
    }
}
