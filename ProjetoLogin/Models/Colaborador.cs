using System.ComponentModel.DataAnnotations;

namespace ProjetoLogin.Models
{
    public class Colaborador
    {
        [Display(Name = "Código", Description = "Código")]
        public int Id { get; set; }

        [Display(Name = "Nome Completo", Description = "Nome e sobrenome")]
        public string Nome { get; set; }

        [Display(Name = "Email", Description = "Email de contato")]
        public string Email { get; set; }

        [Display(Name = "Senha", Description = "Senha")]
        public string Senha { get; set; }

        [Display(Name = "Tipo", Description = "Tipo do colaborador")]
        public string Tipo { get; set; }
    }
}
