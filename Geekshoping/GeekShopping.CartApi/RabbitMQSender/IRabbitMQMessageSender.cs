using Geekshoping.MessageBus;

namespace GeekShopping.CartApi.RabbitMQSender
{
    public interface IRabbitMQMessageSender
    {
        void SendMessage(BaseMessage message, string queueName);
    }
}
