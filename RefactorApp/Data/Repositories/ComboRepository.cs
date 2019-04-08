using System.Collections.Generic;
using System.Linq;
using RefactorApp.Data.Combos;
using RefactorApp.Data.Desserts;
using RefactorApp.Data.Repositories.Interfaces;
using RefactorApp.Data.Sides;

namespace RefactorApp.Data.Repositories
{
    class ComboRepository : IComboRepository<Combo>
    {
        public IEnumerable<Combo> GetAllCombos()
        {
            var chickenLittleCombo = new ChickenLittleCombo(new MashedPotato(), new Brownie());
            var crispyColonelCombo = new CrispyColonelCombo(new MacAndCheese(), new Cookie());
            var kidMealCombo = new KidMealCombo(new FrenchFry(), new IceCream());

            var listOfCombos = new List<Combo>();
            listOfCombos.Add(chickenLittleCombo);
            listOfCombos.Add(crispyColonelCombo);
            listOfCombos.Add(kidMealCombo);

            return listOfCombos;
        }
    }
}
