﻿using imobiliariaLocacao.Models;

namespace imobiliariaLocacao.Repositorio
{
    public interface IContatoRepositorio
    {
        ContatoModel Atualizar (ContatoModel contato);
        ContatoModel ListarPorId(int id);
        List<ContatoModel> BuscarTodos();
        ContatoModel Adicionar(ContatoModel contato);
        bool Apagar(int id);
    }
}
