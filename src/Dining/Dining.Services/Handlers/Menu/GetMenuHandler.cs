namespace Dining.Services.Handlers.Menu
{
    using Dining.Models.DataTransferObjects;
    using Dining.Models.Entities;
    using Dining.Repository.Interfaces;
    using MediatR;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    public class GetMenuHandler : IRequestHandler<MenuRequestDTO, MenuResponseDTO>
    {
        private readonly ISQLServerDiningRepository<Meal> mealRepository;
        public GetMenuHandler(ISQLServerDiningRepository<Meal> mealRepository)
        {
            this.mealRepository = mealRepository;
        }
       
        async Task<MenuResponseDTO> IRequestHandler<MenuRequestDTO, MenuResponseDTO>.Handle(MenuRequestDTO request, CancellationToken cancellationToken)
        {
            IQueryable<Meal> meals = mealRepository.GetAll();
            List<MenuItem> menuItems = meals.Include(c => c.Ingredients)
                .Select(a => new MenuItem
                {
                    MealName = a.Name,
                    Ingredients = a.Ingredients.Select(i => new IngredientDTO
                    {
                        IngredientName = i.IngredientName,
                        IngredientDescription = i.IngredientDescription
                    })
                }).ToList();
            MenuResponseDTO menuResponse = new MenuResponseDTO { menuItems = menuItems };
            return menuResponse;
        }
    }
}
