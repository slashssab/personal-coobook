using CookBook.Database.Models;

namespace Cookbook.Database.Repositories
{
    public class IngredientsRepository : IIngredientsRepository
    {
        private readonly CookbookContext _dbContext;
        public IngredientsRepository(CookbookContext context)
        {
            _dbContext = context;
        }

        public void Delete(int id)
        {
            var ingredientToRemove = this.GetById(id);
            if(ingredientToRemove != null)
            {
                _dbContext.Ingredients.Remove(ingredientToRemove);
                _dbContext.SaveChanges();
            }
        }

        public IEnumerable<Ingredient> GetAll()
        {
            return _dbContext.Ingredients;
        }

        public Ingredient GetById(int id)
        {
            return _dbContext.Ingredients.SingleOrDefault(r => r.Id == id);          
        }

        public IEnumerable<Ingredient> GetByQuery(Func<Ingredient, bool> query)
        {
            return _dbContext.Ingredients.Where(query);
        }

        public void Insert(Ingredient item)
        {
            _dbContext.Ingredients.Add(item);
            _dbContext.SaveChanges();
        }
    }
}