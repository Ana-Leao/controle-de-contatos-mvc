using ControleDeContatos.Models;

namespace ControleDeContatos.Repositorio
{
    public interface IContatoRepositorio
    {
        List<ContatoModel> BuscarTodos();
        ContatoModel Adicionar(ContatoModel contato);
        ContatoModel ListarPorID(int id);
        ContatoModel Atualizar(ContatoModel contato);
        bool Apagar(int id);
    }
}
