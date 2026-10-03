using Contact_systems_in_MVC.Models;

namespace Contact_systems_in_MVC.Repositorio
{
    public interface IContatoRepositorio
    {
        List<ContatoModel> BuscarContatos();
        ContatoModel Adicionar(ContatoModel contato);
        ContatoModel ProcurarContatoPorId (int id);
        ContatoModel Atualizar (ContatoModel contato);
        bool Apagar(int id);
        
        
    }
}
