using System;
using System.ComponentModel.DataAnnotations;

namespace ArnGames.Entities
{
    public class Department
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        public bool Status { get; set; }
    }
}
