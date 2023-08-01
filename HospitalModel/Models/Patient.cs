using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Emit;

namespace HospitalModel.Models
{
    public class Patient
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
        public int stateId { get; set; }

        [Required]
        public int cityId { get; set; }

        [Required]
        public int zipcodeId { get; set; }

       

        // Navigation properties for relationships
        [ForeignKey("StateId")]

        public State StateId { get; set; }

        [ForeignKey("CityId")]
        public City CityId { get; set; }

        [ForeignKey("ZipcodeId")]
        public Zipcode ZipcodeId { get; set; }

       // [ForeignKey("DepartmentId")]
       // public Department Department { get; set; }


    }

}

