using GreenSaleMVC.Data.Entities.Buyers;
using GreenSaleMVC.Data.Interfaces;

namespace GreenSaleMVC.Data.Repositories;

public class BuyerPostRepository(AppDbContext appDb) 
                : Repository<BuyerPost>(appDb), IBuyerPost
{ }
