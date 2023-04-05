using imobiliariaLocacao.Data;
using imobiliariaLocacao.Models;
using System.Collections.Generic;


namespace imobiliariaLocacao.Repositorio
{
    public class ContatoRepositorio : IContatoRepositorio
    {
        private readonly BancoContext _bancoContext;
        public ContatoRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }
        public ContatoModel ListarPorId(int id)
        {
            return _bancoContext.Contato.FirstOrDefault(X => X.Id == id);
        }
        public List<ContatoModel> BuscarTodos()
        {
            try
            {
               return _bancoContext.Contato.ToList();
            }
            catch (Exception ex)
            {
                return null;
            }  
        }
        public ContatoModel Adicionar(ContatoModel contato)
        {
            _bancoContext.Contato.Add(contato);
            _bancoContext.SaveChanges();

            return contato;

        }

        public ContatoModel Atualizar(ContatoModel contato)
        {
            ContatoModel contatoDB = ListarPorId(contato.Id);

            if (contatoDB == null) throw new Exception("Houve um erro na atualização do contato!");
            contatoDB.Name = contato.Name;
            contatoDB.Celular = contato.Celular;
            contatoDB.Email = contato.Email;
            contatoDB.Endereco = contato.Endereco;
            contatoDB.Cidade = contato.Cidade;
            contatoDB.Bairro = contato.Bairro;
            contatoDB.Cep = contato.Cep;
            contatoDB.Estado = contato.Estado;
            contatoDB.ValorAluguel = Math.Round(contato.ValorAluguel, 2);

            _bancoContext.Contato.Update(contatoDB);
            _bancoContext.SaveChanges();

            return contatoDB;
        }

        public bool Apagar(int id)
        {
            ContatoModel contatoDB = ListarPorId(id);

            if (contatoDB == null) throw new Exception("Houve um erro na deleção do contato!");

            _bancoContext.Contato.Remove(contatoDB);
            _bancoContext.SaveChanges();
            
            return true;
        }
    }
}
