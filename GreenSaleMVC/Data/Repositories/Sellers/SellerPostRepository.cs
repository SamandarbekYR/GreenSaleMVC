using GreenSaleMVC.Data.Entities.Sellers;
using GreenSaleMVC.Data.Interfaces;

namespace GreenSaleMVC.Data.Repositories;

public class SellerPostRepository(AppDbContext appDb) 
                : Repository<SellerPost>(appDb), 
                    ISellerPost
{ }
