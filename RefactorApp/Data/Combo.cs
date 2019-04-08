using System;

namespace RefactorApp.Data
{
    abstract class Combo
    {
        public abstract Sandwich Sandwich { get; }
        public abstract Side Side { get; set; }
        public abstract Dessert Dessert { get; set; }
        public DateTime OrderTime => DateTime.Now;
    }
}
