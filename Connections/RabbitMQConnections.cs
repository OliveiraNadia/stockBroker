using RabbitMQ.Client;

namespace stockbroker.Connections
{
    public class ConnectionRabbit
    {
        private string HostName { get; set; }
        private string UserName { get; set; }
        private string Password { get; set; }
    }
}