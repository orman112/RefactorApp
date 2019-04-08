using Newtonsoft.Json;
using System;

namespace RefactorApp.Data
{

    public abstract class Combo
    {
        [JsonIgnore]
        public abstract Sandwich SandwichType { get; }

        [JsonIgnore]
        public abstract Side SideType { get; set; }

        [JsonIgnore]
        public abstract Dessert DessertType { get; set; }

        public DateTime OrderTime { get; set; } //TODO: should be nullable

        public string Side => SideType.GetType().Name;

        public string Sandwich => SandwichType.GetType().Name;

        public string Dessert => DessertType.GetType().Name;
    }
}
