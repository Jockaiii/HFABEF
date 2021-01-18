using System.ComponentModel.DataAnnotations;

namespace HFABEF.Models
{
    internal class Doors
    {
        [Key]
        public string Door { get; set; }
        public string Location { get; set; }
    }
}