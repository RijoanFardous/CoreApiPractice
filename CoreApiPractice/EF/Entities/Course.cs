using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreApiPractice.EF.Entities
{
    public class Course
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [ForeignKey("Dept")]
        public int DeptId { get; set; }


        public virtual Department Dept { get; set; }
    }
}
