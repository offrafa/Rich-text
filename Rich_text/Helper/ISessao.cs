using Rich_text.Models;

namespace Rich_text.Helper
{
    public interface ISessao
    {
        void CriarSessaoDoUsuario(UsuarioModel usuario);

        void RemoverSessaoDoUsuario();

        UsuarioModel BuscarSessaoDoUsuario();

    }
}
