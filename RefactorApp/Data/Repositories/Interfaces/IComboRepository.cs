using System.Collections.Generic;
using System.Threading.Tasks;

namespace RefactorApp.Data.Repositories.Interfaces
{
    interface IComboRepository<TCombo> where TCombo : Combo
    {
        IEnumerable<TCombo> GetAllCombos();
        Task<TCombo> AddAsync(TCombo comboToAdd);
    }
}
