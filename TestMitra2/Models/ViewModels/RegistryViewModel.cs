using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestMitra2.Models.ViewModels
{
    public class RegistryViewModel
    {
        [Required(ErrorMessage = "Поле Логин обязательно к заполнению")]
       
        [Display(Name = "Логин")]
        public string Name { get; set; }
        
        [Required(ErrorMessage = "Поле Email обязательно к заполнению")]
        [EmailAddress(ErrorMessage = "Неправильно введён Email")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Поле Пароль обязательно для заполнения")]
        [Display(Name = "Пароль")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Пароли не совпадают!")]
        [DataType(DataType.Password)]
        [Display(Name = "Подтвердите пароль")]
        public string ConfirmPassword { get; set; }
    }
}
