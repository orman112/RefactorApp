using RefactorApp.Data;
using RefactorApp.Data.Repositories;
using RefactorApp.Data.Sides;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RefactorApp.Services
{
    public class ComboService
    {
        ComboRepository _comboRepository;

        public ComboService()
        {
            _comboRepository = new ComboRepository();
        }

        public void UpdateComboSide(Combo combo, Side side)
        {
            combo.SideType = side;
        }

        public IEnumerable<Combo> GetMashedPotatoesCombo()
        {
            var combos = _comboRepository.GetAllCombos();
            var type = typeof(MashedPotato);
            return combos.Where(c => c.SideType.GetType() == typeof(MashedPotato));
        }

        public async Task<Combo> PlaceOrderAsync(Combo combo)
        {
            if (combo.Side == null ||
                combo.Dessert == null)
            {
                throw new Exception("Combo must have a side and dessert before order can be placed.");
            }

            await _comboRepository.AddAsync(combo);
            return combo;
        }
    }
}
