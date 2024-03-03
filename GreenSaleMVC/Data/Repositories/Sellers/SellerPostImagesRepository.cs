using GreenSaleMVC.Data.Entities.Sellers;
using GreenSaleMVC.Data.Interfaces;

namespace GreenSaleMVC.Data.Repositories;

public class SellerPostImagesRepository(AppDbContext appDb) 
                : Repository<SellerPostImages>(appDb), 
                    ISellerPostImages
{ }
