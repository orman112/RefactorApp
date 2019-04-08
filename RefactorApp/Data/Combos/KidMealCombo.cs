using RefactorApp.Data.Sandwiches;

namespace RefactorApp.Data.Combos
{
    class KidMealCombo : Combo
    {
        private Side _side;
        private Dessert _dessert;

        public KidMealCombo(Side side, Dessert dessert)
        {
            _side = side;
            _dessert = dessert;
        }

        public override Sandwich SandwichType => new GrilledCheese();

        public override Side SideType
        {
            get => _side;
            set => _side = value;
        }

        public override Dessert DessertType
        {
            get => _dessert;
            set => _dessert = value;
        }
    }
}
