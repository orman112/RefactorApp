using RefactorApp.Data.Combos;

namespace RefactorApp.Data.Factories
{
    class KidMealFactory : ComboFactory
    {
        private Side _side;
        private Dessert _dessert;

        public KidMealFactory(Side side, Dessert dessert)
        {
            _side = side;
            _dessert = dessert;
        }

        public override Combo CreateComboMeal()
        {
            return new KidMealCombo(_side, _dessert);
        }
    }
}
