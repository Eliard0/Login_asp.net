using System.ComponentModel.DataAnnotations;

namespace teste.Models
{
    public class LoginModelcs
    {
        [Required(ErrorMessage = "Digite o login")]
        public string Login { get; set; }
        
        [Required(ErrorMessage = "Digite a senha")]
        public string Senha { get; set; }
    }
}
