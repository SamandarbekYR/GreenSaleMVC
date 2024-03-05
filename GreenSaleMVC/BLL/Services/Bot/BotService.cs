using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace GreenSaleMVC.BLL.Services.Bot
{
    public class BotService
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly TelegramBotClient _botClient;

        public BotService(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            _botClient = new TelegramBotClient("6687082741:AAFdQfqvwQaXH5UX5s7nRRmKaPBAIlmyQSM");
        }

        public async Task SendMessage(string message, CancellationToken cancellationToken)
        {
            try
            {
                Message sentMessage = await _botClient.SendTextMessageAsync(
                    chatId: -1001925271798,
                    text: message,
                    cancellationToken: cancellationToken
                );

                // Additional processing or logging can be done here if needed

                // Example: If you want to get the message ID
                int messageId = sentMessage.MessageId;

                // Example: If you want to handle the sent message
                // HandleSentMessage(sentMessage);
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log or rethrow)
                Console.WriteLine($"Error sending message: {ex.Message}");
                throw;
            }
        }

        // Example method for handling the sent message
        private void HandleSentMessage(Message sentMessage)
        {
            // Implement your logic here based on the sent message
            Console.WriteLine($"Message sent with ID: {sentMessage.MessageId}");
        }
    }
}
