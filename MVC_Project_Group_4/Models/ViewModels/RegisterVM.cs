using System.ComponentModel.DataAnnotations;

namespace MVC_Project_Group_4.Models.ViewModels
{
    public class RegisterVM
    {

        public int ID { get; set; }
        [Required(ErrorMessage = "Email alanı gereklidir.")]
        [EmailAddress(ErrorMessage = "Geçerli bir email adresi giriniz.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Adres alanı gereklidir.")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Parola alanı gereklidir")]
        [DataType(DataType.Password)]
        //[StringLength(15, ErrorMessage = "Parola en az {2} ve en fazla {1} karakter uzunluğunda olmalıdır.", MinimumLength = 6)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&#])[A-Za-z\d@$!%*?&#]{6,}$",
            ErrorMessage = "Şifre en az 6 karakter uzunluğunda olmalı ve en az bir büyük harf, bir küçük harf, bir rakam ve bir özel karakter içermelidir.")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Parola doğrulama alanı gereklidir.")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Parola ve doğrulama parolası eşleşmiyor.")]
        public string ConfirmPassword { get; set; }
    }
}
