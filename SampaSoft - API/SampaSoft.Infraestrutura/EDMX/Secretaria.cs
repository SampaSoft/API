//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SampaSoft.Infraestrutura.EDMX
{
    using System;
    using System.Collections.Generic;
    
    public partial class Secretaria
    {
        public int codSecretaria { get; set; }
        public string cnpj { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string logradouro { get; set; }
        public string numero { get; set; }
        public string complemento { get; set; }
        public Nullable<int> codMunicipio { get; set; }
        public string telefone { get; set; }
        public Nullable<System.TimeSpan> horaAtendimentoInicial { get; set; }
        public Nullable<System.TimeSpan> horaAtendimentoFinal { get; set; }
        public bool ativo { get; set; }
    }
}
