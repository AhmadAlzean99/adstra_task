using System.ComponentModel.DataAnnotations;

namespace AdstrTask.ViewModel
{


    public class UserViewModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Phone]
        public string PhoneNumber { get; set; }
        public string Role { get; set; }
        [Required]
        public string Password { get; set; }
    }

}
