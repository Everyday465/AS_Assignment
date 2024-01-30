using System.ComponentModel.DataAnnotations;

namespace AS_Assignment.ViewModels
{
    public class Login
    {

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid Email.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is requtttired.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
