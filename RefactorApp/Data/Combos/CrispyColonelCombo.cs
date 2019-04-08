using RefactorApp.Data.Sandwiches;

namespace RefactorApp.Data.Combos
{
    class CrispyColonelCombo : Combo
    {
        private Side _side;
        private Dessert _dessert;

        public CrispyColonelCombo(Side side, Dessert dessert)
        {
            _side = side;
            _dessert = dessert;
        }

        public override Sandwich Sandwich => new CrispyColonel();

        public override Side Side
        {
            get => _side;
            set => _side = value;
        }

        public override Dessert Dessert
        {
            get => _dessert;
            set => _dessert = value;
        }
    }
}
