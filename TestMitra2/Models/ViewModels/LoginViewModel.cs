using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TestMitra2.Models.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Поле Логин обязательно к заполнению")]
        [Display(Name = "Логин")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Поле Пароль обязательно к заполнению")]
        [Display(Name = "Пароль")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Запомнить?")]
        public bool RememberMe { get; set; }

        public string ReturnUrl { get; set; } = string.Empty;

        public string ErrorMessage { get; set; } = string.Empty;

    }
}

