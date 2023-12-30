using System.Text;
using NetMQ;
using NetMQ.Sockets;

namespace NetMQChatApp
{
    public class ClientMQ
    {
        public static void SendMessage(string msg)
        {
            using (var client = new RequestSocket())
            {
                //client.Connect("tcp://localhost:5555");
                client.Connect("tcp://127.0.0.1:5556");
                client.SendFrame(msg);
                var message = client.ReceiveFrameString();
                Console.WriteLine("Received: ", message);
                
            }
        }

    }
}
