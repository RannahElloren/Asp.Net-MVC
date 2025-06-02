using ControledeContatos.Models;

namespace ControledeContatos.Repositorio
{
    public interface IContatoRepositorio
    {
        ContatoModel listarPorId(int id);
        List<ContatoModel> BuscarTodos();
        ContatoModel Adicionar(ContatoModel contato);
        ContatoModel Atualizar(ContatoModel contato);
        bool Apagar(int id);
    }
}
