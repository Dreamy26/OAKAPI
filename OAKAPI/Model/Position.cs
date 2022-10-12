using System.ComponentModel.DataAnnotations;

namespace OAKAPI.Model
{
    public class Position
    {
        public Position()
        {
            Persons = new HashSet<Person>();
        }
        [Key]
        public int PositionId { get; set; }
        [Required]
        public string Name { get; set; }
        public virtual ICollection<Person> Person { get; set; }


    }
}
