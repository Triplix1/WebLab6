using System.ComponentModel.DataAnnotations;

namespace Web_Labs.Models
{
    public class AccordoinModel
    {
        public int Id { get; set; }
        [UIHint("number")]
        public int Position { get; set; }
        public string Content { get; set; }
    }
}
