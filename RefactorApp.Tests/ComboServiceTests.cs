using Microsoft.VisualStudio.TestTools.UnitTesting;
using RefactorApp.Data.Combos;
using RefactorApp.Data.Desserts;
using RefactorApp.Data.Sides;
using RefactorApp.Services;

namespace RefactorApp.Tests
{
    [TestClass]
    public class ComboServiceTests
    {
        [TestMethod]
        public void UpdateComboSide_NewSide_ShouldReplaceOldSide()
        {
            var combo = new ChickenLittleCombo(new MashedPotato(), new Brownie());
            var comboService = new ComboService();

            comboService.UpdateComboSide(combo, new MacAndCheese());

            Assert.IsInstanceOfType(combo.Side, typeof(MacAndCheese));
        }

        //TODO: Create unit test for checking nullable dates and setting to DateTime.Now
    }
}
