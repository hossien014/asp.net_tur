using System.ComponentModel.DataAnnotations;

namespace radnom_web.Models
{
    public class Custumer
    {
        [Key] // mean its primary key and identity column
        public int id {  get; set; }
        [Required] // NOTNUll
        public string Name { get; set; }
        public int Age {  get; set; }
        public DateTime BrithDay {  get; set; } =DateTime.Now;
    }
}
