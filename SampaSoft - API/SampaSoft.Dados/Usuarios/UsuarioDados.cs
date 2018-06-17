using System;
using System.Linq;
using System.Data.Entity;
using System.Collections.Generic;
using SampaSoft.Infraestrutura.EDMX;

namespace SampaSoft.Dados.Usuarios
{
    public class UsuarioDados : IUsuarioDados
    {
        #region ATRIBUTOS E CONSTRUTOR
        private SampasoftDBEntities db = null;

        /// <summary>
        /// Metodo contrutor
        /// </summary>
        /// <param name="db"></param>
        public UsuarioDados(SampasoftDBEntities db)
        {
            this.db = db;
        }

        #endregion

        #region USUARIO

        /// <summary>
        /// Metodo responsavel por buscar todos usuarios
        /// </summary>
        /// <returns></returns>
        public IList<Usuario> BuscaTodosUsuario()
        {
            return db.Usuarios.ToList();
        }

        /// <summary>
        /// Metodo responsavel por salvar o usuario
        /// </summary>
        /// <param name="Usuario"></param>
        /// <returns></returns>
        public Usuario SalvaUsuario(Usuario usuario)
        {
            db.Usuarios.Add(usuario);
            db.SaveChanges();

            return usuario;
        }

        /// <summary>
        /// Metodo responsavel por alterar o usuario 
        /// </summary>
        /// <param name="usuario"></param>
        public Usuario AlteraUsuario(Usuario usuario)
        {
            db.Entry<Usuario>(usuario).State = EntityState.Modified;
            db.SaveChanges();
            return usuario;
        }


        /// <summary>
        /// Metodo responsavel por selecionar o Usuário
        /// </summary>
        /// <param name="Usuario"></param>
        /// <returns></returns>
        public Usuario SelecionaUsuarioPorLogin(String login)
        {
            return db.Usuarios.SingleOrDefault(x => x.cpf.Equals(login));
        }

        public bool SelecionaUsuarioLoginSenha(string login, string senha)
        {
            return db.Usuarios.Any(x => x.cpf.Equals(login) && x.senha.Equals(senha));
        }
        #endregion

    }
}
