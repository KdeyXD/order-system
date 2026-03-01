using DecoratorDrink.Data;
using DecoratorDrink.Model;
namespace DecoratorDrink.Service
{
    public class DrinkService
    {
        private readonly DrinkRepository _drinkRepository;

        public DrinkService()
        {
            _drinkRepository = new DrinkRepository();
        }

        public List<Drink> GetAllDrinks()
        {
            return _drinkRepository.GetAllDrinks();
        }
    }
}
