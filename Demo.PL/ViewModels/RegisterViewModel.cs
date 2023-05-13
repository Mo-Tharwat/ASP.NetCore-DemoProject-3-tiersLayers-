using System.ComponentModel.DataAnnotations;

namespace Demo.PL.ViewModels
{
	public class RegisterViewModel
	{
        [Required(ErrorMessage ="First Name is Required")]
        public string FName { get; set; }

		[Required(ErrorMessage = "Last Name is Required")]
		public string LName { get; set; }

        [Required(ErrorMessage ="Email is required")]
		[EmailAddress(ErrorMessage ="Invalid Email")]
        public string Email { get; set; }

		[Required(ErrorMessage ="Password is required")]
		[DataType(DataType.Password)]
        public string Password { get; set; }

		[Required(ErrorMessage ="Confirm Password is required")]
		[Compare("Password", ErrorMessage ="Confirm password field is doesn't matched with the password field")]
		[DataType(DataType.Password)]
        [Display(Name ="Confirm Password")]
        public string ConfirmPassword { get; set; }

        public bool IsAgree { get; set; }

    }
}
