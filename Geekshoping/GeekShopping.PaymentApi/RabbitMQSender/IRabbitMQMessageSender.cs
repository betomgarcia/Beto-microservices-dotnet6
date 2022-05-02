using Geekshoping.MessageBus;

namespace GeekShopping.PaymentApi.RabbitMQSender
{
    public interface IRabbitMQMessageSender
    {
        void SendMessage(BaseMessage message);
    }
}
