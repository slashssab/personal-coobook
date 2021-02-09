namespace Cookbook.Common.Models
{
    public class CookBookItem
    {
        public int Id {get; set;} 
        public int IngredientId { get; set; }
        public int RecipeId { get; set; }
        public Recipe Recipe {get; set;}
        public Ingredient Ingredient {get;set;}
    }
}
