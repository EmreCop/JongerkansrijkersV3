using System.ComponentModel.DataAnnotations;

namespace Jongerkansrijkers.Components.Data.Models
{
    public class Instutuut
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}