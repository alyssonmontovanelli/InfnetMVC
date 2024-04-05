using System.ComponentModel.DataAnnotations;

namespace InfnetMVC.ViewModels
{
    public class LoginViewModel
    {

        [Required(ErrorMessage = "Insira um endereço de email.")]
        [EmailAddress(ErrorMessage = "Informe um endereço de e-mail válido.")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "A senha está incorreta. Tente novamente.")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [Display(Name = "Permanecer conectado")]
        public bool RememberMe { get; set; }

    }
}
