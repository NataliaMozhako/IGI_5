using CookingSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookingSite.Data.Interfaces
{
    interface IRecipe
    {
        public void AddRecipeDB(Recipe recipe);
        public IEnumerable<Recipe> AllRecipes();
        public void DeleteRecipe(Recipe recipe);
        public Recipe GetRecipeDB(int id);
        public void UpdateRecipe(Recipe recipe);
    }
}
