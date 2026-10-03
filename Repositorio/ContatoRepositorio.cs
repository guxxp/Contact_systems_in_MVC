using Contact_systems_in_MVC;
using Contact_systems_in_MVC.Data;
using Contact_systems_in_MVC.Models;

namespace Contact_systems_in_MVC.Repositorio
{


    public class ContatoRepositorio : IContatoRepositorio
    {
        /// GRAVAR BANCO DE DADOS -   QUE VAI SER O CONTEXT QUE VAI GRAVAR

        private readonly BancoContext _bancoContext;



        public ContatoRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public List<ContatoModel> BuscarContatos()
        {
            return _bancoContext.Contatos.ToList();
        }
        public ContatoModel ProcurarContatoPorId(int id)
        {
            return _bancoContext.Contatos.FirstOrDefault(x => x.Id == id);
        }

        public ContatoModel Adicionar(ContatoModel contato)
        {
            _bancoContext.Contatos.Add(contato);
            _bancoContext.SaveChanges();
            return contato;
        }
        public ContatoModel Atualizar(ContatoModel contato)
        {
            ContatoModel contatoDB = ProcurarContatoPorId(contato.Id);
            if (contatoDB == null) throw new Exception("Houve um Erro na Atualização do Contato");
            contatoDB.Nome = contato.Nome;
            contatoDB.Email = contato.Email;
            contatoDB.Telefone = contato.Telefone;


            _bancoContext.Contatos.Update(contatoDB);
            _bancoContext.SaveChanges();

            return contatoDB;

        }

        public bool Apagar(int id)
        {
            ContatoModel contatoDB = ProcurarContatoPorId(id);
            if (contatoDB == null) throw new Exception("Houve um Erro na Atualização do Contato");
            _bancoContext.Contatos.Remove(contatoDB);
            _bancoContext.SaveChanges();
            return true;
        }
    }
}
