using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jongerkansrijkers.Components.Data.Models
{
    public class Activiteit
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        public string? Location { get; set; }

        public DateOnly? Date { get; set; }


        [ForeignKey("Jongeren ")]
        public virtual List<int>? JongerenIds { get; set; }
      
        public User? Begeleider { get; set; }

    }
}
