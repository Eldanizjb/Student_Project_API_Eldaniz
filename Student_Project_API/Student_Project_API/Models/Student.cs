using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Student_Project_API.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(30)]
        public string Name { get; set; }
        [MaxLength(30)]
        public string Surname { get; set; }
        public byte Age { get; set; }
        public byte Class { get; set; }
        public DateTime CreatedDate { get; set; }
        [ForeignKey("Specialty")]
        public int specialtyId { get; set; }
        public Specialty Specialty { get; set; }
    }
}
