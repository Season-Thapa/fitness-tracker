using System.ComponentModel.DataAnnotations;

namespace Pri.Ee.Web.Dtos
{
    public class RegisterUserRequestDto
    {
        [Required]
        public string Email { get; set; }

        public string Name { get; set; }
        [Required]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}
