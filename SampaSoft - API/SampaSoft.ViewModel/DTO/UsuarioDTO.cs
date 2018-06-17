using System;

namespace SampaSoft.ViewModel.DTO
{
    public class UsuarioDTO
    {
        public string codUsuario { get; set; }
        public string nome { get; set; }
        public string usuario { get; set; }
        public DateTime dataCadastro { get; set; }
        public bool ativo { get; set; }
    }
}
