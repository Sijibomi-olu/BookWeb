using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookWeb.Entities;

namespace BookWeb.Interface
{
    public interface ICharacteristics
    {
        void Add(Characteristics characteristics);
        Task<bool> AddAsync(Characteristics characteristics);
        Task<bool> Update(Characteristics characteristics);
        Task<IEnumerable<Characteristics>> GetAll();
        Task<Characteristics> GetById(int Id);
        Task<bool> Delete(int Id);
    }
}
