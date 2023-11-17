using System.ComponentModel.DataAnnotations;

namespace Jongerkansrijkers.Components.Data.Models
{
    public class Jongeren
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateOnly Brithdate { get; set; }
        public Instutuut Instutuut { get; set; }

    }
}
