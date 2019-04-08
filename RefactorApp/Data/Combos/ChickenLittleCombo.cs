using RefactorApp.Data.Sandwiches;

namespace RefactorApp.Data.Combos
{
    public class ChickenLittleCombo : Combo
    {
        private Side _side;
        private Dessert _dessert;

        public ChickenLittleCombo(Side side, Dessert dessert)
        {
            _side = side;
            _dessert = dessert;
        }

        public override Sandwich Sandwich => new ChickenLittle();

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
