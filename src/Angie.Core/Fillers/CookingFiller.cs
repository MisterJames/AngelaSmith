﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Angela.Core.Fillers
{
    class CookingFiller
    {
        public class IngredientFiller : PropertyFiller<string>
        {
            public IngredientFiller()
                : base(new[] { "object" }, new[] { "ingredient", "ingredients" })
            {
            }

            public override object GetValue()
            {
                return ValueGenerators.Cooking.Ingredients.Ingredient();
            }
        }
    }
}
