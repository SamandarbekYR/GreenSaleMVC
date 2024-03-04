using GreenSaleMVC.Data.Entities.Messages;
using GreenSaleMVC.Data.Interfaces.Messages;

namespace GreenSaleMVC.Data.Repositories.Messages
{
    public class MessageRepository(AppDbContext appDb) 
                    : Repository<Message>(appDb), 
                        IMessage
    { }
}
