using RefactorApp.Data.Combos;

namespace RefactorApp.Data.Factories
{
    class CrispyColonelComboFactory : ComboFactory
    {
        private Side _side;
        private Dessert _dessert;

        public CrispyColonelComboFactory(Side side, Dessert dessert)
        {
            _side = side;
            _dessert = dessert;
        }

        public override Combo CreateComboMeal()
        {
            return new CrispyColonelCombo(_side, _dessert);
        }
    }
}
