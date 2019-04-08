using RefactorApp.Data;
using RefactorApp.Data.Repositories;
using RefactorApp.Data.Sides;
using System.Collections.Generic;
using System.Linq;

namespace RefactorApp.Services
{
    class ComboService
    {
        ComboRepository _comboRepository;

        public ComboService()
        {
            //Dependency Injection
            _comboRepository = new ComboRepository();
        }

        public void UpdateComboSide(Combo combo, Side side) //Should be domain specific logic
        {
            combo.Side = side;
        }

        public IEnumerable<Combo> GetMashedPotatoesCombo() //Should be in the repository
        {
            var combos = _comboRepository.GetAllCombos();
            var type = typeof(MashedPotato);
            return combos.Where(c => c.Side.GetType() == typeof(MashedPotato));
        }
    }
}
