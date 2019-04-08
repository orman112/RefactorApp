using RefactorApp.Data;
using RefactorApp.Data.Repositories;
using RefactorApp.Data.Sides;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RefactorApp.Services
{
    public class ComboService //TODO: needs interface
    {
        ComboRepository _comboRepository; //TODO: should use IComboRepository instead

        public ComboService() //TODO: no logging present
        {
            //TODO: Dependency Injection
            _comboRepository = new ComboRepository();
        }

        public void UpdateComboSide(Combo combo, Side side) //TODO: Should be domain specific logic
        {
            combo.SideType = side;
        }

        public IEnumerable<Combo> GetMashedPotatoesCombo() //TODO: Should be in the repository
        {
            var combos = _comboRepository.GetAllCombos();
            var type = typeof(MashedPotato);
            return combos.Where(c => c.SideType.GetType() == typeof(MashedPotato));
        }

        public async Task<Combo> PlaceOrderAsync(Combo combo) //TODO: doesn't need to be async
        {
            if (combo.Side == null ||
                combo.Dessert == null)
            {
                throw new Exception("Combo must have a side and dessert before order can be placed."); //TODO: should throw argument null exception
            }

            //TODO: set order time as DateTime.Now if null

            await _comboRepository.AddAsync(combo);
            return combo;
        }
    }
}
