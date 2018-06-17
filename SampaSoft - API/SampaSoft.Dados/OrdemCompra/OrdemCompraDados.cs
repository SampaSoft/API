using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SampaSoft.Infraestrutura.EDMX;
using System.Data.Entity;

namespace SampaSoft.Dados.OrdensCompras
{
    public class OrdemCompraDados : IOrdemCompraDados
    {
        #region ATRIBUTOS E CONSTRUTOR
        private SampasoftDBEntities db = null;

        /// <summary>
        /// Metodo contrutor
        /// </summary>
        /// <param name="db"></param>
        public OrdemCompraDados(SampasoftDBEntities db)
        {
            this.db = db;
        }

        #endregion

        #region ORDEM COMPRA

        /// <summary>
        /// Metodo responsavel por buscar todos ordens de compra
        /// </summary>
        /// <returns></returns>
        public IList<OrdemCompra> BuscaTodosOrdensCompras()
        {
            return db.OrdensCompras.ToList();
        }

        public OrdemCompra BuscaOrdemCompra(int codOrdemCompra)
        {
            return db.OrdensCompras.FirstOrDefault(x => x.codOrdemCompra == codOrdemCompra);
        }

        /// <summary>
        /// Metodo responsavel por salvar o orgao
        /// </summary>
        /// <param name="OrdemCompra"></param>
        /// <returns></returns>
        public OrdemCompra SalvaOrdemCompra(OrdemCompra ordemCompra)
        {
            db.OrdensCompras.Add(ordemCompra);
            db.SaveChanges();

            return ordemCompra;
        }

        /// <summary>
        /// Metodo responsavel por alterar o orgao 
        /// </summary>
        /// <param name="orgao"></param>
        public OrdemCompra AlteraOrdemCompra(OrdemCompra ordemCompra)
        {
            db.Entry<OrdemCompra>(ordemCompra).State = EntityState.Modified;
            db.SaveChanges();

            return ordemCompra;
        }

        #endregion

    }
}
