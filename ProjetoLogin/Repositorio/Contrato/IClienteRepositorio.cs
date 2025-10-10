using ProjetoLogin.Models;

namespace ProjetoLogin.Repositorio.Contrato
{
    public interface IClienteRepositorio
    {
        //Login Cliente
        Cliente Login(string Email, string Senha);

        //CRUD
        void Cadastrar(Cliente cliente);

        void Atualizar(Cliente cliente);

        void Ativar(int Id);

        void Desativar(int Id);

        void Excluir(int Id);

        Cliente ObterCliente(int Id);

        Cliente BuscaCpfCliente(string CPF);

        Cliente BuscaEmailCliente(string email);

        IEnumerable<Cliente> ObterTodosClientes();
        //IPagedList<Cliente> ObterTodosClientes(int? pagina, string pesquisa);
    }
}
