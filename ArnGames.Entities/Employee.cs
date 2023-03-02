using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArnGames.Entities
{
   public class Employee
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(50)]
        public string City { get; set; }

        [Required]
        [StringLength(15)]
        public string IdentityNumber { get; set; }

        public DateTime StartWork { get; set; }

        public DateTime? LeaveWork { get; set; }
        public int DepartmentId { get; set; }

        [ForeignKey("DepartmentId")]
        public Department Department { get; set; }
        public bool Status { get; set; }
    }
}
