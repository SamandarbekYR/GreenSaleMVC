using GreenSaleMVC.Data.Entities.Buyers;
using GreenSaleMVC.Data.Interfaces;

namespace GreenSaleMVC.Data.Repositories;

public class BuyerPostImagesRepository(AppDbContext appDb) 
                : Repository<BuyerPostImages>(appDb), 
                    IBuyerPostImages
{ }
