using imobiliariaLocacao.Models;
using imobiliariaLocacao.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace imobiliariaLocacao.Controllers
{

    public class ContatoController : Controller
    {
   
        private readonly IContatoRepositorio _contatoRepositorio;
        public ContatoController(IContatoRepositorio contatoRepositorio)
        {
            _contatoRepositorio = contatoRepositorio;
        }
        public IActionResult Index()
        {
            _contatoRepositorio.BuscarTodos();
            List<ContatoModel> Contatos = _contatoRepositorio.BuscarTodos();
            return View(Contatos);
        }

        public IActionResult Criar()
        {
            return View();
        }
        public IActionResult Editar(int id )
        {
           ContatoModel contato= _contatoRepositorio.ListarPorId( id );
            return View(contato);
        }
        public IActionResult ApagarConfirmacao (int id)
        {
            ContatoModel contato = _contatoRepositorio.ListarPorId(id);
            return View(contato);
        }
        public IActionResult Apagar(int id) 
        {
            try
            {
                _contatoRepositorio.Apagar(id);
                TempData["MensagemSucesso"] = "Contato excluído com sucesso";
                return RedirectToAction("Index");
            }
            catch (System.Exception erro) 
            {
                return RedirectToAction("Index");
                TempData["MensagemError"] = $"Desculpe! Não conseguimos excluir este contato. Detalhe do erro:{erro.Message} ";
            }
           
           
        }

      
        [HttpPost]
        public IActionResult Criar(ContatoModel contato) 
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _contatoRepositorio.Adicionar(contato);
                    TempData["MensagemSucesso"] = "Contato cadastrado com sucesso";

                    return RedirectToAction("Index");
                }

                return View(contato);
            } 
            catch (System.Exception erro) 
            {
                TempData["MensagemError"] = $"Desculpe! Não conseguimos cadastrar seu contato. Detalhe do erro:{erro.Message} ";
                return RedirectToAction("Index");
            }

           
        }
        [HttpPost]
        public IActionResult Alterar(ContatoModel contato)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _contatoRepositorio.Atualizar(contato);
                    TempData["MensagemSucesso"] = "Dados atualizados com sucesso";

                    return RedirectToAction("index");
                }

                return View("Editar", contato);

            }
            catch(System.Exception erro)
            {
                TempData["MensagemError"] = $"Desculpe! Não conseguimos atualizar seus dados. Detalhe do erro:{erro.Message} ";
                return RedirectToAction("Index");
            }

            
         
        }
    }
}
