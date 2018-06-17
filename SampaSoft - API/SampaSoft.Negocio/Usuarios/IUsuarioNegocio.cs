using System;
using SampaSoft.Dados.Usuarios;
using System.Collections.Generic;
using SampaSoft.Infraestrutura.EDMX;

namespace SampaSoft.Negocio.Usuarios
{
    public interface IUsuarioNegocio
    {
        Usuario AlteraUsuario(Usuario usuario);
        IList<Usuario> BuscaTodosUsuarios();
        Usuario SelecionaUsuarioPorLogin(String login);
        bool SelecionaUsuarioLoginSenha(string login, string senha);
    }
}
