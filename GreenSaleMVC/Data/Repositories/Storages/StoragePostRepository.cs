using GreenSaleMVC.Data.Entities.Storages;
using GreenSaleMVC.Data.Interfaces;

namespace GreenSaleMVC.Data.Repositories;

public class StoragePostRepository(AppDbContext appDb) 
                : Repository<StoragePost>(appDb), 
                    IStoragePost
{ }
