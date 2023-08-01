using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalModel.Models
{
    public class Doctor
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string FullName { get; set; }

        [Required]
        [MaxLength(100)]
        public string Email { get; set; }

        [Required]
        [MaxLength(20)]
        public string MobileNumber { get; set; }

        [Required]
        [MaxLength(100)]
        public string Specialization { get; set; }

        public string department { get; set; }
        [ForeignKey("DepartmentId")]
        public Department DepartmentId { get; set; }

    }
}
