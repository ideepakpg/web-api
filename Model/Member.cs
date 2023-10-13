using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace web_api.Model
{
    [Table("MvcCore")] // mvc-core database table
    public class Member
    {
        [Key]
        public int Id { get; set; }

        public string? Name { get; set; }

        public int? Age { get; set; }

        public string? Gender { get; set; }

        public string? Email { get; set; }

        public string? Course { get; set; }

        public string? State { get; set; }
    }
}
