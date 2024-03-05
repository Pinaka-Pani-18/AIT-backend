using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace AIT_backend.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Department { get; set; }
        public string Gender { get; set; }
        [DefaultValue("")]
        public string Role { get; set; }
        [DefaultValue(true)]
        public bool IsActive { get; set; }
    }
}
