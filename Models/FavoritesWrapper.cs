using System;
using System.Collections.Generic;

namespace RecipeBook.Models
{
    public class FavoritesWrapper
    {
        public List<Recipe> RecipeList { get; set; }

        public RegisterUser User { get; set; }

    }

}