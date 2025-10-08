using System.ComponentModel.DataAnnotations;

namespace ProjetoLogin.Models
{
    public class Cliente
    {
        [Display(Name = "Código", Description = "Código")]
        public int Id { get; set; }

        [Display(Name = "Nome Completo", Description = "Nome e sobrenome")]
        public string Nome { get; set; }

        [Display(Name = "Data de nascimento", Description = "Data de nascimento")]
        public DateTime Nascimento { get; set; }

        [Display(Name = "Sexo", Description = "Masculino ou feminino")]
        public string Sexo { get; set; }

        [Display(Name = "CPF", Description = "CPF")]
        public int CPF { get; set; }

        [Display(Name = "Telefone", Description = "Telefone de contato")]
        public int Telefone { get; set; }

        [Display(Name = "Email", Description = "Email de contato")]
        public string Email { get; set; }

        [Display(Name = "Senha", Description = "Senha")]
        public string Senha { get; set; }

        [Display(Name = "Situação", Description = "Situação")]
        public string Situacao { get; set; }
    }
}
