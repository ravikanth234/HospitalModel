using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HospitalModel.Models
{
    public class Appointment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey ("ptid")]
        public int PatientId { get; set; }
        public Patient ptid { get; set; }

        [Required]
        [ForeignKey("drid")]
        public int DoctorId { get; set; }
        public Doctor drid { get; set; }

        [Required]
        public DateTime DateTime { get; set; }

        public string department { get; set; }
        [Required]
        [ForeignKey("DepartmentId")]
        public Department DepartmentId { get; set; }



    }
}
