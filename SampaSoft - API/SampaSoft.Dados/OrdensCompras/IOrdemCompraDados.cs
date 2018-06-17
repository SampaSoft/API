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
    public interface IOrdemCompraDados
    {
        IList<OrdemCompra> BuscaTodosOrdensCompras();
        OrdemCompra BuscaOrdemCompra(int codOrdemCompra);
        OrdemCompra SalvaOrdemCompra(OrdemCompra ordemCompra);
        OrdemCompra AlteraOrdemCompra(OrdemCompra ordemCompra);
    }
}
