using GreenSaleMVC.Data.Entities.Storages;
using GreenSaleMVC.Data.Interfaces;

namespace GreenSaleMVC.Data.Repositories;

public class StorageImagesRepository(AppDbContext appDb) 
                : Repository<StorageImages>(appDb),
                    IStorageImages 
{ }
