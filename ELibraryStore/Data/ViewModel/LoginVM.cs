using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ELibraryStore.Data.ViewModel
{
    public class LoginVM
    {
        [Required(ErrorMessage ="Email Address is Required")]
        [DisplayName("Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is Required")]
        [DisplayName("Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }    
    }
}
