using SampaSoft.Infraestrutura.EDMX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampaSoft.Dados.OrdensCompras;

namespace SampaSoft.Negocio.OrdensCompras
{
    public class OrdemCompraNegocio : IOrdemCompraNegocio
    {
        private IOrdemCompraDados ordemCompraDAO = null;

        /// <summary>
        /// Metodo construtor
        /// </summary>
        /// <param name="usuarioDAO"></param>
        public OrdemCompraNegocio(IOrdemCompraDados ordemCompraDAO)
        {
            this.ordemCompraDAO = ordemCompraDAO;
        }

        public IList<OrdemCompra> BuscaTodosOrdensCompras()
        {
            return ordemCompraDAO.BuscaTodosOrdensCompras();
        }

        public OrdemCompra BuscaOrdemCompra(int codOrdemCompra)
        {
            return ordemCompraDAO.BuscaOrdemCompra(codOrdemCompra);
        }

        public OrdemCompra SalvaOrdemCompra(OrdemCompra ordemCompra)
        {
            return ordemCompraDAO.SalvaOrdemCompra(ordemCompra);
        }

        public OrdemCompra AlteraOrdemCompra(OrdemCompra ordemCompra)
        {
            return ordemCompraDAO.AlteraOrdemCompra(ordemCompra);
        }
    }
}
