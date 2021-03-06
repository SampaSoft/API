﻿using System;
using System.Collections.Generic;
using SampaSoft.Infraestrutura.EDMX;

namespace SampaSoft.Dados.Usuarios
{
    public interface IUsuarioDados
    {
        IList<Usuario> BuscaTodosUsuario();
        Usuario SalvaUsuario(Usuario usuario);
        Usuario AlteraUsuario(Usuario usuario);
        Usuario SelecionaUsuarioPorLogin(String login);
        bool SelecionaUsuarioLoginSenha(string login, string senha);
    }
}
