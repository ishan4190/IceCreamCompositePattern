using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Interfaces;
namespace BusinessLayer.Classes
{
    public class CompositeIngredients : IIngredients 
    {
        private List<IIngredients> _ingredients;

        public CompositeIngredients()
        {
            _ingredients = new List<IIngredients>();
        }

        public void AddNewIngredient(IIngredients ingredient)
        {
            _ingredients.Add(ingredient);
        }

        public string AddIngredients()
        {
            var recipe = new StringBuilder();
            foreach(var ingredient in _ingredients)
            {
                recipe.Append(ingredient.AddIngredients());
            }

            return recipe.ToString();
        }
    }
}
