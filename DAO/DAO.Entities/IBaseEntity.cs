using System;

namespace DAO.Entities
{
    public interface IBaseEntity<TKey>
    {
        TKey Id { get; set; }
        DateTime DataCriacao { get; set; }
        string Situacao { get; set; }
    }
}