using System;
using CCTU.Entities;
using DAO.Entities.Domains;

namespace DAO.Entities.SIG
{
    public class EnderecoFranquia : IBaseEntity<int>, IEndereco<TipoEndereco>
    {
        // IBaseEntity<int> Implementation
        #region IBaseEntity<int>
        public int Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public string Situacao { get; set; }
        #endregion

        //IEndereco<TipoEndereco>
        #region IEndereco<TipoEndereco>
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string UF { get; set; }
        public int Cidade { get; set; }
        public bool Principal { get; set; }
        public TipoEndereco TipoEndereco { get; set; }
        #endregion

        public virtual Franquia Proprietario { get; set; }
    }
}
