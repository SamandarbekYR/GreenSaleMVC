using AutoMapper;
using GreenSaleMVC.BLL.Interfaces.Messages;
using GreenSaleMVC.BLL.Services.Bot;
using GreenSaleMVC.Data.Entities.Messages;
using GreenSaleMVC.Data.Interfaces;
using GreenSaleMVC.DTOs.Messages;

namespace GreenSaleMVC.BLL.Services.Messages
{
    public class MessageService(IUnitOfWork unitOfWork, IMapper mapper, BotService botService) : IMessageService
    {
        public IUnitOfWork _dbSet = unitOfWork;
        public IMapper _mapper = mapper;
        public readonly BotService _messageService = botService;
        public async ValueTask<(string, bool)> Add(AddMessageDto messageDto)
        {
            try
            {
                Message entity = _mapper.Map<Message>(messageDto);
                int result = await _dbSet.Messages.Add(entity);

                if (result > 0)
                {
                    bool res = await SendMessageToChannel(messageDto);

                    if (res)
                    {
                        return ("Habaringiz muvaffaqiyatli yuborildi tez orada sizga aloqaga chiqamiz", true);
                    }
                }

                return ("Nomalum xatolik yuz berdi qaytadan urunib ko'ring", false);
            }

            catch (Exception ex)
            {
                return ("Xatolik yuz berdi, iltimos ma'lumotlarni boshqatdan jo'nating ", false);
            }
        }

        public ValueTask<(string, bool)> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public async ValueTask<bool> SendMessageToChannel(AddMessageDto message)
        {
            try
            {
                string letter = $"""
                            ----------------------------------------
                            😎 FI:{message.FI}
                            ☎️ Phone number:{message.PhoneNumber}

                            ♾️Title:{message.Title}
                            {message.Letter}

                            """;

                using CancellationTokenSource cts = new();
                await _messageService.SendMessage(letter, cts.Token);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
