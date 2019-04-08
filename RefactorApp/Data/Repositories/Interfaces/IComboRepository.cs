using System.Collections.Generic;

namespace RefactorApp.Data.Repositories.Interfaces
{
    interface IComboRepository<TCombo> where TCombo : Combo
    {
        IEnumerable<TCombo> GetAllCombos();
    }
}
