using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SampaSoft.Infraestrutura.EDMX;
using System.Data.Entity;

namespace SampaSoft.Dados.Usuarios
{
    interface IUsuarioDados
    {
        IList<Usuario> BuscaTodosUsuario();
        Usuario SalvaUsuario(Usuario usuario);
        Usuario AlteraUsuario(Usuario usuario);
        Usuario SelecionaUsuarioPorLogin(String usuario);
        bool SelecionaUsuarioLoginSenha(string login, string senha);
    }
}
