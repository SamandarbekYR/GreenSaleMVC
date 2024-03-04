using GreenSaleMVC.Data.Interfaces.Messages;

namespace GreenSaleMVC.Data.Interfaces
{
    public interface IUnitOfWork  
    {
        public IUserRole UserRole { get; }
        public IUser User { get; }
        public IBuyerPost BuyerPost { get; }
        public IBuyerPostImages BuyerPostImages { get; }
        public ISellerPost SellerPost { get; }
        public ISellerPostImages SellerPostImages { get; }
        public IStoragePost StoragePost { get; }
        public IStorageImages StorageImages { get; }
        public IMessage Messages { get; }
    }
}
