using GreenSaleMVC.Data.Entities.Messages;
using GreenSaleMVC.DTOs.Messages;

namespace GreenSaleMVC.BLL.Interfaces.Messages
{
    public interface IMessageService
    {
        public ValueTask<(string, bool)> Add(AddMessageDto messageDto);
        public ValueTask<(string, bool)> Delete(Guid id);
        public ValueTask<bool> SendMessageToChannel(AddMessageDto message);
    }
}
