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
    
    public partial class Usuario
    {
        public int codUsuario { get; set; }
        public string nome { get; set; }
        public string rg { get; set; }
        public string cpf { get; set; }
        public string logradouro { get; set; }
        public string numero { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public int codMunicipio { get; set; }
        public string estado { get; set; }
        public string cep { get; set; }
        public string sexo { get; set; }
        public Nullable<System.DateTime> dataNascimento { get; set; }
        public string senha { get; set; }
        public Nullable<System.DateTime> dataCadastro { get; set; }
        public Nullable<bool> ativo { get; set; }
    }
}