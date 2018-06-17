using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SampaSoft.Infraestrutura.EDMX;
using System.Data.Entity;

namespace SampaSoft.Dados.Orgaos
{
    public class OrgaoDados : IOrgaoDados
    {
        #region ATRIBUTOS E CONSTRUTOR
        private SampasoftDBEntities db = null;

        /// <summary>
        /// Metodo contrutor
        /// </summary>
        /// <param name="db"></param>
        public OrgaoDados(SampasoftDBEntities db)
        {
            this.db = db;
        }

        #endregion

        #region ORGAO

        /// <summary>
        /// Metodo responsavel por buscar todos orgaos
        /// </summary>
        /// <returns></returns>
        public IList<Orgao> BuscaTodosOrgaos()
        {
            return db.Orgaos.ToList();
        }

        public Orgao BuscaOrgao(int codSecretaria)
        {
            return db.Orgaos.FirstOrDefault(x => x.codSecretaria == codSecretaria);
        }

        /// <summary>
        /// Metodo responsavel por salvar o orgao
        /// </summary>
        /// <param name="Orgao"></param>
        /// <returns></returns>
        public Orgao SalvaOrgao(Orgao orgao)
        {
            db.Orgaos.Add(orgao);
            db.SaveChanges();

            return orgao;
        }

        /// <summary>
        /// Metodo responsavel por alterar o orgao 
        /// </summary>
        /// <param name="orgao"></param>
        public Orgao AlteraOrgao(Orgao orgao)
        {
            db.Entry<Orgao>(orgao).State = EntityState.Modified;
            db.SaveChanges();
            return orgao;
        }

        #endregion

    }
}
