using Rich_text.Models;
using System.Collections.Generic;

namespace Rich_text.Repositorio
{
    public interface IUsuarioRepositorio
    {
        List<UsuarioModel> BucarTodos();
        UsuarioModel BuacarPorId(int id);
        UsuarioModel Adicionar(UsuarioModel usuario);
        UsuarioModel Atualizar(UsuarioModel usuario);

        bool Apagar(int id);
        UsuarioModel BuscarPorLogin(string login);
    }
}
