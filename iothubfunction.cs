using IoTHubTrigger = Microsoft.Azure.WebJobs.EventHubTriggerAttribute;

using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Azure.EventHubs;
using System.Text;
using System.Net.Http;
using Microsoft.Extensions.Logging;

namespace func
{
    public class iothubfunction
    {        
        [FunctionName("iothubfunction")]
        public void Run([IoTHubTrigger("messages/events", Connection = "iothubconn", ConsumerGroup = "azfunc")]EventData message, ILogger log)
        {
            log.LogInformation($"C# IoT Hub trigger function processed a message: {Encoding.UTF8.GetString(message.Body.Array)}");
            
        }
    }
}