using System.ComponentModel.DataAnnotations;

namespace Pri.Ee.Api.Dtos
{
    public class RegisterUserRequestDto : LoginUserRequestDto
    {
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
        public string Name { get; set; }
   
    }
}
