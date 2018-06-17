using SampaSoft.Infraestrutura.EDMX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampaSoft.Negocio.OrdensCompras
{
    public interface IOrdemCompraNegocio
    {
        IList<OrdemCompra> BuscaTodosOrdensCompras();
        OrdemCompra BuscaOrdemCompra(int codOrdemCompra);
        OrdemCompra SalvaOrdemCompra(OrdemCompra ordemCompra);
        OrdemCompra AlteraOrdemCompra(OrdemCompra ordemCompra);
    }
}
