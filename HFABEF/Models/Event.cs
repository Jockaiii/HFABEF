using System.ComponentModel.DataAnnotations;

namespace HFABEF.Models
{
    internal class Event
    {
        [Key]
        public string Code { get; set; }
        public string Explanation { get; set; }
    }
}