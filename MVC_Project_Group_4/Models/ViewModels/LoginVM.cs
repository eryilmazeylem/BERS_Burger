using System.ComponentModel.DataAnnotations;

namespace MVC_Project_Group_4.Models.ViewModels
{
    public class LoginVM
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Email alanı gereklidir.")]
        [EmailAddress(ErrorMessage = "Geçerli bir email adresi giriniz.")]
        public string EMail { get; set; }

        [Required(ErrorMessage = "Parola alanı gereklidir")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}
