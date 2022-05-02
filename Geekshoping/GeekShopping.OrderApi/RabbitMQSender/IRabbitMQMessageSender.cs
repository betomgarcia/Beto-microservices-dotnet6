using Geekshoping.MessageBus;

namespace GeekShopping.OrderApi.RabbitMQSender
{
    public interface IRabbitMQMessageSender
    {
        void SendMessage(BaseMessage message, string queueName);
    }
}
