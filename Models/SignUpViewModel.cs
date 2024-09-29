using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.Models
{
    public class SignUpViewModel
    {
		public string FullName { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public string ConfirmPassword { get; set; }
		public string PhoneNumber { get; set; }

		// ConfirmPassword ve Password'ün eşleşip eşleşmediğini kontrol etmek için metot eklenebilir
		public bool IsPasswordMatch()
		{
			return Password == ConfirmPassword;
		}
	}
}
