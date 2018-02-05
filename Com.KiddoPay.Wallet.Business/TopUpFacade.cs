using Com.KiddoPay.Domains.Wallet;
using Microsoft.Azure.ServiceBus;
using Newtonsoft.Json;
using System;
using System.Text;
using System.Threading.Tasks;

namespace Com.KiddoPay.Wallet.Business
{
    public class TopUpFacade
    {
        const string ServiceBusConnectionString = "Endpoint=sb://com-kiddopay-wallet.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=X6EAYbQVkGbGZlHGDisUIKOk/K2JiVM7sBJiTj5/ogk=";
        const string QueueName = "com.kiddopay.payment/topup";
        public Task TopUpAsync(string username, decimal nominal)
        {
            IQueueClient queueClient = new QueueClient(ServiceBusConnectionString, QueueName);
            TopUpMessage topupMessage = new TopUpMessage()
            {
                Id = Guid.NewGuid().ToString("N"),
                Username = username,
                Nominal = nominal
            };

            Message message = new Message(Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(topupMessage)));
            return queueClient.SendAsync(message);
        }
    }
}
