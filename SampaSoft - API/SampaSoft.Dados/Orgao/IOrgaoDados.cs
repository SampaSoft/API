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
    interface IOrgaoDados
    {
        IList<Orgao> BuscaTodosOrgaos();
        Orgao BuscaOrgao(int codSecretaria);
        Orgao SalvaOrgao(Orgao orgao);
        Orgao AlteraOrgao(Orgao orgao);
    }
}
