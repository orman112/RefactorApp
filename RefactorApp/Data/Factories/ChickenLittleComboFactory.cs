using RefactorApp.Data.Combos;

namespace RefactorApp.Data.Factories
{
    class ChickenLittleComboFactory : ComboFactory
    {
        private Side _side;
        private Dessert _dessert;

        public ChickenLittleComboFactory(Side side, Dessert dessert)
        {
            _side = side;
            _dessert = dessert;
        }

        public override Combo CreateComboMeal()
        {
            return new ChickenLittleCombo(_side, _dessert);
        }
    }
}
