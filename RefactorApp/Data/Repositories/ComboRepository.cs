using System.Collections.Generic;
using System.Threading.Tasks;
using RefactorApp.Data.Combos;
using RefactorApp.Data.Desserts;
using RefactorApp.Data.Repositories.Interfaces;
using RefactorApp.Data.Sides;

namespace RefactorApp.Data.Repositories
{
    public class ComboRepository : IComboRepository<Combo>
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

        public Task<Combo> AddAsync(Combo comboToAdd)
        {
            //...Some database logic to add combo
            //Assume everything went smoothly

            return Task.FromResult<Combo>(comboToAdd);
        }
    }
}
