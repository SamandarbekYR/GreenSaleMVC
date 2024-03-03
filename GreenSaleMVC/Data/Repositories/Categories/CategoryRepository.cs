using GreenSaleMVC.Data.Entities.Categories;
using GreenSaleMVC.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GreenSaleMVC.Data.Repositories;

public class CategoryRepository(AppDbContext appDb)
                : Repository<Category>(appDb), 
                    ICategoryInterface
{ }
