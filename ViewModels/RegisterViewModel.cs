using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace InfnetMVC.ViewModels
{
    public class RegisterViewModel
    {

        [Required(ErrorMessage = "Insira um endereço de email.")]
        [EmailAddress(ErrorMessage = "Informe um endereço de e-mail válido.")]
        public string? Email {  get; set; }

        [Required(ErrorMessage = "Sua senha deve atender aos critérios de segurança.")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirme a Senha")]
        [Compare("Password", ErrorMessage = "Senhas não coincidem. Tente novamente.")]
        public string? ConfirmPassword { get; set; }

    }
}
