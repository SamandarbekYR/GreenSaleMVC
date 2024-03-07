using GreenSaleMVC.Data.Interfaces;
using GreenSaleMVC.Data.Interfaces.Messages;
using GreenSaleMVC.Data.Repositories.Messages;

namespace GreenSaleMVC.Data.Repositories
{
    public class UnitOfWork(AppDbContext appDb) : IUnitOfWork, IDisposable
    {
        public IUserRole UserRole { get; } = new UserRoleRepository(appDb);

        public IUser User { get; } = new UserRepository(appDb);

        public IBuyerPost BuyerPost { get; } = new BuyerPostRepository(appDb);

        public IBuyerPostImages BuyerPostImages { get; } = new BuyerPostImagesRepository(appDb);

        public ISellerPost SellerPost { get; } = new SellerPostRepository(appDb);

        public ISellerPostImages SellerPostImages { get; } = new SellerPostImagesRepository(appDb);

        public IStoragePost StoragePost { get; } = new StoragePostRepository(appDb);

        public IStorageImages StorageImages { get; } = new StorageImagesRepository(appDb);
       
        public IMessage Messages { get; } = new MessageRepository(appDb);

        public ICategoryInterface Category { get; } = new CategoryRepository(appDb);
        
        public void Dispose()
        {
            appDb.Dispose();
        }
    }
}
