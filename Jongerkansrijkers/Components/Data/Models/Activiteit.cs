using System.ComponentModel.DataAnnotations;

namespace Jongerkansrijkers.Components.Data.Models
{
    public class Activiteit
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public string location { get; set; }

        public DateOnly Date { get; set; }

        public Jongeren Jongeren { get; set; }

        public User Begeleider { get; set; }

    }
}
