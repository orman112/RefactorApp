using RefactorApp.Data;
using RefactorApp.Data.Repositories;
using RefactorApp.Data.Sides;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RefactorApp.Services
{
    public class ComboService //needs interface
    {
        ComboRepository _comboRepository; //should use IComboRepository instead

        public ComboService() //no logging present
        {
            //Dependency Injection
            _comboRepository = new ComboRepository();
        }

        public void UpdateComboSide(Combo combo, Side side) //Should be domain specific logic
        {
            combo.SideType = side;
        }

        public IEnumerable<Combo> GetMashedPotatoesCombo() //Should be in the repository
        {
            var combos = _comboRepository.GetAllCombos();
            var type = typeof(MashedPotato);
            return combos.Where(c => c.SideType.GetType() == typeof(MashedPotato));
        }

        public async Task<Combo> PlaceOrderAsync(Combo combo) //doesn't need to be async
        {
            if (combo.Side == null ||
                combo.Dessert == null)
            {
                throw new Exception("Combo must have a side and dessert before order can be placed."); //should throw argument null exception
            }

            //set order time as DateTime.Now if null

            await _comboRepository.AddAsync(combo);
            return combo;
        }
    }
}
