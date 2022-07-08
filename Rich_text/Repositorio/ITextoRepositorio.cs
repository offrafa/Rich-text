using Rich_text.Models;
using System.Collections.Generic;

namespace Rich_text.Repositorio
{
    public interface ITextoRepositorio
    {
        List<TextoModel> BucarTodos();
        List<TextoModel> BucarPorUsuario(int id);
        List<TextoModel> BucarPorUsuarioId(int id);
        TextoModel BuacarPorId(int id);
        TextoModel Adicionar(TextoModel texto);
        TextoModel Atualizar(TextoModel texto);
        
        bool Apagar(int id);
    }
}
